var page = (function () {

    var _ready = [];

    var _page = {
        data: {
            title: '',
            updated: '',
            teaching: [],
            people: [],
            publications: [],
            publicationTypes: []
        },
        ready: function (fn) {
            _ready.push(fn);
        },

        appendPublications: appendPublications
    };


    function initialize() {
        $('a[href^="https://"],a[href^="http://"]').attr('target', '_blank');
        $.ajax('data/data.json')
            .done(function (d) {

                var pubTypes = d.publicationTypes

                _page.data = d;

                for (var i = 0; i < _ready.length; i++) {
                    _ready[i](d);
                }
            });
    };

    function appendPublications(parent, title, items) {
        var item = $('<div><h3>' + title + '</h3></div>');
        var ul = $("<ul>").css({ 'list-style': 'none' }).appendTo(item);

        for (var i = 0; i < items.length; i++) {
            var p = items[i];
            var li = $('<li>').appendTo(ul);
            li.append('[' + p.code + '] ');
            li.append(p.contributors);
            li.append(' (' + p.year + '). ');
            li.append(p.title);
            li.append('<br />');

            var links = $('<div>').appendTo(li);

            if (p.pdf) {
                links.append('<a href="' + p.pdf + '" target="_blank" title="PDF"> [PDF] </a>');
            }

            if (p.url) {
                links.append('<a href="' + p.url + '" target="_blank" title="URL"> [URL] </a>');
            }
            
            if (p.bibtex) {
                var bibtex = p.bibtex.replace(/\n/ig, "<br/>");
                var bibtexLink = $('<a href="javascript:void(0)" title="Bibtex"> [Bibtex] </a>').appendTo(links);
                var bintexContent = $('<div>').addClass('bibtex').appendTo(links);

                bibtexLink.click(function () {
                    bintexContent.html(bibtex);
                    bintexContent.slideToggle();
                });
            }

            li.append('<br />');
        };

        item.appendTo(parent);
    }


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