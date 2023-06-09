/*
    Website     https://www.khizooo.com
    LinkedIn    https://www.linkedin.com/in/khizar-imtiaz
    Facebook    https://www.facebook.com/khizoooartist
    Twitter	    https://twitter.com/khizaroo
    Instagram   https://www.instagram.com/khizooo_art
    Pinterest   https://www.pinterest.com/KhizoOo_
    Blogger     https://khizooo.blogspot.com
    OpenSea     https://opensea.io/KhizoOo_
*/



(function ($) {

    'use strict';

    // GENERAL
    var Shuffle = window.Shuffle;
    var jQuery = window.jQuery;
    

    { // Animate On Scroll Library

        try
        {
            AOS.init({ once: true });
        }
        catch (E) { console.log("Animate On Scroll Library"); }
        
    }

    { // Progress Bar

        try {
            $(window).on('load', function () {

                $('.progress-bar').each(function () {
                    var width = $(this).data('percent');
                    $(this).css({ 'transition': 'width 3s' });
                    $(this).appear(function () {
                        console.log('hello');
                        $(this).css('width', width + '%');
                        $(this).find('.count').countTo({
                            from: 0,
                            to: width,
                            speed: 3000,
                            refreshInterval: 50
                        });
                    });
                });

                debugger

                document.querySelector('video').play();

            });
        }
        catch (E) { console.log("Progress Bar"); }

    }

    { // OWL Carousel

        try {
            $('.owl-carousel').owlCarousel({
                items: 1,
                loop: true,
                autoplay: true,
                dots: false,
                autoplayTimeout: 8000
            });
        }
        catch (E) { console.log("OWL Carousel"); }

    }

    { // Swipers

        try {
            const swiper = new Swiper('.Art-Swiper', {
                direction: 'vertical',
                mousewheel: {},
                effect: 'cube',
                keyboard: {
                    enabled: true,
                    onlyInViewport: true
                }
            });
        }
        catch (E) { console.log("Art Swipers"); }

        try {
            const swiper = new Swiper('.Tech-Swiper', {
                direction: 'vertical',
                mousewheel: {},
                effect: 'cube',
                keyboard: {
                    enabled: true,
                    onlyInViewport: true
                }
            });
        } 
        catch (E) { console.log("Tech Swipers"); }

    }

    { // Images Galleery

        // Shuffle js filter and masonry
        var Shuffle = window.Shuffle;
        var jQuery = window.jQuery;

        var myShuffle = new Shuffle(document.querySelector('.shuffle-wrapper'), {
            itemSelector: '.shuffle-item',
            buffer: 1
        });

        jQuery('input[name="shuffle-filter"]').on('change', function (evt) {
            var input = evt.currentTarget;
            if (input.checked) {
                myShuffle.filter(input.value);
            }
        });

    }

})(jQuery);