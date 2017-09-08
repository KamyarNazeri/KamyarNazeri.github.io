(function () {

    var _canvas;
    var _context;
    var _paths = [];

    var LINE_COLOR = "blue";
    var LINE_WIDTH = 10;


    function init() {
        initializeCanvas();
        document.getElementById('button_clear').addEventListener("click", clear);
        document.getElementById('button_recognize').addEventListener("click", recognize);
    };


    function clear() {
        _paths = [];
        _context.clearRect(0, 0, _canvas.width, _canvas.height);
        document.getElementById('div_output').innerHTML = '';
        document.getElementById('div_stats').innerHTML = '';
    };


    function sigmoid(z) {
        return 1 / (1 + Math.exp(-z));
    };


    function softmax(input) {
        var max3 = Math.max(...input);
        var nominators = input.map(t => Math.exp(t - max3));
        var denominator = nominators.reduce((a, b) => a + b);
        var output = nominators.map(t => t / denominator);
        return output;
    };


    function recognize() {
        // takes the image in the canvas, centers & resizes it, then puts into 10x10 px bins
        // to give a 28x28 grayscale image; then, computes class probability via neural network

        var t1 = new Date();

        // convert RGBA image to a grayscale array, then compute bounding rectangle and center of mass
        var imgData = _context.getImageData(0, 0, 280, 280);
        var grayscaleImg = imageDataToGrayscale(imgData);
        var boundingRectangle = getBoundingRectangle(grayscaleImg, 0.01);
        var trans = getCenterOfMass(grayscaleImg);



        // copy image to hidden canvas, translate to center-of-mass, then
        // scale to fit into a 200x200 box 
        var canvasCopy = document.createElement("canvas");
        canvasCopy.width = imgData.width;
        canvasCopy.height = imgData.height;
        var copyCtx = canvasCopy.getContext("2d");
        var brW = boundingRectangle.maxX + 1 - boundingRectangle.minX;
        var brH = boundingRectangle.maxY + 1 - boundingRectangle.minY;
        var scaling = 190 / (brW > brH ? brW : brH);

        // scale
        copyCtx.translate(_canvas.width / 2, _canvas.height / 2);
        copyCtx.scale(scaling, scaling);
        copyCtx.translate(-_canvas.width / 2, -_canvas.height / 2);

        // translate to center of mass
        copyCtx.translate(trans.transX, trans.transY);


        for (var p = 0; p < _paths.length; p++) {
            for (var i = 0; i < _paths[p][0].length - 1; i++) {
                var x1 = _paths[p][0][i];
                var y1 = _paths[p][1][i];
                var x2 = _paths[p][0][i + 1];
                var y2 = _paths[p][1][i + 1];
                draw(copyCtx, LINE_COLOR, LINE_WIDTH / scaling, x1, y1, x2, y2);
            }
        }



        // now bin image into 10x10 blocks (giving a 28x28 image)
        imgData = copyCtx.getImageData(0, 0, 280, 280);
        grayscaleImg = imageDataToGrayscale(imgData);
        var nnInput = new Array(784);
        for (var y = 0; y < 28; y++) {
            for (var x = 0; x < 28; x++) {
                var mean = 0;
                for (var v = 0; v < 10; v++) {
                    for (var h = 0; h < 10; h++) {
                        mean += grayscaleImg[y * 10 + v][x * 10 + h];
                    }
                }
                mean = (1 - mean / 100); // average and invert
                nnInput[x * 28 + y] = (mean - .5) / .5;
            }
        }

        var t2 = new Date();
        var nnOutput = computeNeuralNetwork(nnInput, w1, bias1, w2, bias2);
        var stats = nnOutput.map((t, i) => i + ": " + (Math.round(t * 1000) / 1000)).join("<br \>");

        stats += '<br \><br /> NN time: ' + (new Date() - t2) + 'ms <br /> recognize time: ' + (new Date() - t1) + 'ms';
        document.getElementById('div_stats').innerHTML = stats;
        document.getElementById('div_output').innerHTML = nnOutput.findIndex(t => t == Math.max(...nnOutput));
    };


    function initializeCanvas() {

        var prevX = 0;
        var currX = 0;
        var prevY = 0;
        var currY = 0;
        var paintFlag = false;

        _canvas = document.getElementById('canvas_text');
        _context = _canvas.getContext("2d");

        function _moveHandler(e) {
            e.preventDefault();
            if (paintFlag) {
                prevX = currX;
                prevY = currY;

                var pageX = e.pageX;
                var pageY = e.pageY;

                if (e.touches && e.touches.length) {
                    pageX = e.touches[0].pageX;
                    pageY = e.touches[0].pageY;
                }

                if (pageX !== undefined && pageY !== undefined) {
                    currX = pageX - _canvas.offsetLeft;
                    currY = pageY - _canvas.offsetTop;
                }

                _paths[_paths.length - 1][0].push(currX);
                _paths[_paths.length - 1][1].push(currY);

                draw(_context, LINE_COLOR, LINE_WIDTH, prevX, prevY, currX, currY);
            }
        }

        function _startHandler(e) {
            e.preventDefault()
            if (e.pageX != undefined && e.pageY != undefined) {
                currX = e.pageX - _canvas.offsetLeft;
                currY = e.pageY - _canvas.offsetTop;
            }

            else {
                currX = e.clientX + document.body.scrollLeft
                    + document.documentElement.scrollLeft
                    - _canvas.offsetLeft;

                currY = e.clientY + document.body.scrollTop
                    + document.documentElement.scrollTop
                    - _canvas.offsetTop;
            }
            //draw a circle
            _context.beginPath();
            _context.lineWidth = 1;
            _context.arc(currX, currY, LINE_WIDTH / 2, 0, 2 * Math.PI);
            _context.stroke();
            _context.closePath();
            _context.fill();

            _paths.push([[currX], [currY]]);
            paintFlag = true;
        };

        function _endHandler(e) {
            paintFlag = false;
        }

        _canvas.addEventListener("mousemove", _moveHandler, false);
        _canvas.addEventListener("touchmove", _moveHandler, false);

        _canvas.addEventListener("mousedown", _startHandler, false);
        _canvas.addEventListener("touchstart", _startHandler, false);

        _canvas.addEventListener("mouseup", _endHandler, false);
        _canvas.addEventListener("touchend", _endHandler, false);

        _canvas.addEventListener("mouseout", _endHandler, false);
        _canvas.addEventListener("touchcancel", _endHandler, false);
    };


    function draw(context, color, lineWidth, x1, y1, x2, y2) {
        context.beginPath();
        context.strokeStyle = color;
        context.lineWidth = lineWidth;
        context.lineCap = 'round';
        context.lineJoin = 'round';
        context.moveTo(x1, y1);
        context.lineTo(x2, y2);
        context.stroke();
        context.closePath();
    }


    // neural net with one hidden layer; sigmoid for hidden, softmax for output
    function computeNeuralNetwork(data, w1, bias1, w2, bias2) {
        // compute layer2 output (sigmoid)
        var out2 = [];
        for (var i = 0; i < w1.length; i++) {
            out2[i] = bias1[i];
            for (var j = 0; j < w1[i].length; j++) {
                out2[i] += data[j] * w1[i][j];
            }
            out2[i] = sigmoid(out2[i]);
        }


        //compute layer3 activation
        var out3 = [];
        for (var i = 0; i < w2.length; i++) {
            out3[i] = bias2[i];
            for (var j = 0; j < w2[i].length; j++) {
                out3[i] += out2[j] * w2[i][j];
            }
        }


        // compute layer3 output (softmax)
        var output = softmax(out3);

        return output;
    }



    // computes center of mass of digit
    function getCenterOfMass(img) {

        // note 1 stands for black (0 white) so we have to invert.

        var meanX = 0;
        var meanY = 0;
        var rows = img.length;
        var columns = img[0].length;
        var sumPixels = 0;

        for (var y = 0; y < rows; y++) {
            for (var x = 0; x < columns; x++) {
                var pixel = (1 - img[y][x]);
                sumPixels += pixel;
                meanY += y * pixel;
                meanX += x * pixel;
            }
        }
        meanX /= sumPixels;
        meanY /= sumPixels;

        var dY = Math.round(rows / 2 - meanY);
        var dX = Math.round(columns / 2 - meanX);
        return { transX: dX, transY: dY };
    }


    // find bounding rectangle of digit defined by above-threshold surrounding
    function getBoundingRectangle(img, threshold) {
        var rows = img.length;
        var columns = img[0].length;
        var minX = columns;
        var minY = rows;
        var maxX = -1;
        var maxY = -1;
        for (var y = 0; y < rows; y++) {
            for (var x = 0; x < columns; x++) {
                if (img[y][x] < threshold) {
                    if (minX > x) minX = x;
                    if (maxX < x) maxX = x;
                    if (minY > y) minY = y;
                    if (maxY < y) maxY = y;
                }
            }
        }
        return { minY: minY, minX: minX, maxY: maxY, maxX: maxX };
    }


    // take canvas image and convert to grayscale.
    function imageDataToGrayscale(imgData) {
        var grayscaleImg = [];

        for (var y = 0; y < imgData.height; y++) {
            grayscaleImg[y] = [];
            for (var x = 0; x < imgData.width; x++) {

                // data is stored in RGBA, need to offset 4

                var offset = y * 4 * imgData.width + 4 * x;
                var alpha = imgData.data[offset + 3];

                if (alpha == 0) {
                    imgData.data[offset] = 255;
                    imgData.data[offset + 1] = 255;
                    imgData.data[offset + 2] = 255;
                }
                imgData.data[offset + 3] = 255;
                grayscaleImg[y][x] = imgData.data[offset] / 255;
            }
        }
        return grayscaleImg;
    }


    window.onload = init;
})();