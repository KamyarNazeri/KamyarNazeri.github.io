$(window).load(function () {
    try {
        $('#slider').nivoSlider();

        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date(); a = s.createElement(o),
                m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
        })(window, document, 'script', 'http://www.google-analytics.com/analytics.js', 'ga');

        ga('create', 'UA-45081905-1', 'uoit.ca');
        ga('send', 'pageview');
    }
    catch (e) { }
});


$(document).ready(function () {
    $('a[href^="https://"],a[href^="http://"]').attr("target", "_blank");
});