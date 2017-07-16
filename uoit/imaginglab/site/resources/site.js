var page = (function () {

    var _ready = [];

    var _page = {
        data: {
            title: '',
            updated: '',
            teachings: [],
            people: [],
            publications: [],
            publicationTypes: []
        },

        ready: function (fn) {
            _ready.push(fn);
        },

        render: render
    };


    function render() {
        $('a[href^="https://"]:not([target]),a[href^="http://"]:not([target])').attr('target', '_blank');
    };

    
    function initialize() {
        render();
        $.ajax('data/data.json?' + Math.random())
            .done(function (d) {

                var pubTypes = d.publicationTypes

                _page.data = d;

                for (var i = 0; i < _ready.length; i++) {
                    _ready[i](d);
                }
            });
    };


    function initGoogleAnalytics() {
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date(); a = s.createElement(o),
                m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
        })(window, document, 'script', 'https://www.google-analytics.com/analytics.js', 'ga');

        ga('create', 'UA-45081905-1', 'uoit.ca');
        ga('send', 'pageview');
    };


    $(window).load(function () {
        try {
            $('#slider').nivoSlider();
            initGoogleAnalytics();
        }
        catch (e) { }
    });


    $(document).ready(initialize);

    return _page;
})();