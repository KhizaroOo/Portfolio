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

    { // Art Shuffle

        try {
            var ArtShuffle = new Shuffle(document.querySelector('.shuffle-wrapper-art'), {
                itemSelector: '.shuffle-item',
                buffer: 1
            });

            jQuery('.shuffle-wrapper-art input[name="shuffle-filter"]').on('change', function (evt) {
                var input = evt.currentTarget;
                if (input.checked) {
                    ArtShuffle.filter(input.value);
                }
            });

            $('.shuffle-wrapper-art .portfolio-gallery').each(function () {
                $(this).find('.popup-gallery').magnificPopup({
                    type: 'image',
                    gallery: {
                        enabled: true
                    }
                });
            });
        }
        catch (E) { console.log("Art Shuffle"); }

    }

    { // Tech Shuffle

        try {
            var TechShuffle = new Shuffle(document.querySelector('.shuffle-wrapper-tech'), {
                itemSelector: '.shuffle-item',
                buffer: 1
            });

            jQuery('.shuffle-wrapper-tech input[name="shuffle-filter"]').on('change', function (evt) {
                var input = evt.currentTarget;
                if (input.checked) {
                    TechShuffle.filter(input.value);
                }
            });

            $('.shuffle-wrapper-tech .portfolio-gallery').each(function () {
                $(this).find('.popup-gallery').magnificPopup({
                    type: 'image',
                    gallery: {
                        enabled: true
                    }
                });
            });
        }
        catch (E) { console.log("Tech Shuffle"); }

    }

    { // Animated Text

        var TxtRotate = function (el, toRotate, period) {
            this.toRotate = toRotate;
            this.el = el;
            this.loopNum = 0;
            this.period = parseInt(period, 10) || 2000;
            this.txt = '';
            this.tick();
            this.isDeleting = false;
        };

        TxtRotate.prototype.tick = function () {
            var i = this.loopNum % this.toRotate.length;
            var fullTxt = this.toRotate[i];

            if (this.isDeleting) {
                this.txt = fullTxt.substring(0, this.txt.length - 1);
            } else {
                this.txt = fullTxt.substring(0, this.txt.length + 1);
            }

            this.el.innerHTML = '<span class="wrap">' + this.txt + '</span>';

            var that = this;
            var delta = 300 - Math.random() * 100;

            if (this.isDeleting) { delta /= 2; }

            if (!this.isDeleting && this.txt === fullTxt) {
                delta = this.period;
                this.isDeleting = true;
            } else if (this.isDeleting && this.txt === '') {
                this.isDeleting = false;
                this.loopNum++;
                delta = 500;
            }

            setTimeout(function () {
                that.tick();
            }, delta);
        };

        var elements = document.getElementsByClassName('txt-rotate');

        for (var i = 0; i < elements.length; i++) {
            var toRotate = elements[i].getAttribute('data-rotate');
            var period = elements[i].getAttribute('data-period');
            if (toRotate) {
                new TxtRotate(elements[i], JSON.parse(toRotate), period);
            }
        }
        // INJECT CSS
        var css = document.createElement("style");
        css.type = "text/css";
        css.innerHTML = ".txt-rotate > .wrap { border-right: 0.08em solid #666 }";
        document.body.appendChild(css);

    }

})(jQuery);