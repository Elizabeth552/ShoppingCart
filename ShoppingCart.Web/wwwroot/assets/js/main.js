/*
 *****************************************************
 *	CUSTOM JS DOCUMENT                              *
 *	Single window load event                        *
 *  "use strict" mode on                            *
 *****************************************************
 */
$(window).on('load', function() {
    "use strict";

    var preloader = $('.preloader');
    var fancyboxImg = $('.fancybox');
    var accordionFAQ = $("#accordion");
    var comingSoon = $('#demo');
    var gmap_canvas = $('#gmap_canvas');
    var comingProduct = $('#demo-product');
    var slidernewsNav = $('#slidernews.owl-theme .owl-nav');


    /*
    ========================================
     Preloder Setting
    ========================================
    */
    if (preloader.length) {
        preloader.fadeOut();
    }

    /*
    ========================================
     Model-Box Setting
    ========================================
    */
    var modelBox = '$(document)';
    var myModelBox = $("#myModal_two");
    if (modelBox.length) {
        myModelBox.modal('show');
    };
    /*
	========================================
     Owl Carousel functions Calling
    ======================================== 	
	*/
    owlCarouselInit();

    /*
    ========================================
     Search Setting
    ========================================
    */

    var viewSearch = $('.clicksearch');
    var backicon = $('.close-search');
    var searchClose = $('#searchclose');

    if (viewSearch.length) {
        viewSearch.on('click', function(e) {
            e.preventDefault();
            if ($(this).children('i').hasClass('fa-search')) {
                $(this).children('i').removeClass('fa-search').addClass('fa-times');
            } else {
                $(this).children('i').removeClass('fa-times').addClass('fa-search');
            }
            if (searchClose.hasClass('serch-open')) {
                searchClose.removeClass('serch-open');
            } else {
                searchClose.addClass('serch-open');
            }
        });

    }

    /*
    ========================================
     Grid Setting
    ========================================
    */
    var searchAnchor = $('a[href="#search1"]');
    var searchID = $('#search1');
    var searchInput = $('#search1 > form > input[type="search1"]');
    var searchElement = $('#search1, #search1 button.close');
    var sLide = $('.slide');
    var fadeIn = $('#fade-in');

    searchAnchor.on('click', function(event) {
        searchID.addClass('open');
        searchInput.focus();
    });
    searchElement.on('click keyup', function(event) {
        if (event.target == this || event.target.className == 'close' || event.keyCode == 27) {
            $(this).removeClass('open');
        }
    });

    if (sLide.length) {
        sLide.on('click', function() {
            fadeIn.toggleClass('show');
        });
    }
    /*
    ========================================
     Sticky-Header Setting
    ========================================
    */
    var Stickyheader = $(window);

    Stickyheader.scroll(function() {
        if ($(this).scrollTop() > 50) {
            $('header').addClass("sticky");
        } else {
            $('header').removeClass("sticky");
        }
    });

    /*
    ========================================
     Product Setting
    ========================================
    */

    var productGrid = $('.col-2');
    var productlist = $('.col-3');
    var productimg = $('.col-4');

    if (productGrid.length) {
        productGrid.on('click', function() {
            document.getElementById('col-2-img').style.display = 'block';
            document.getElementById('col-3-img').style.display = 'none';
            document.getElementById('col-4-img').style.display = 'none';
        });
    }
    if (productlist.length) {
        productlist.on('click', function() {
            document.getElementById('col-2-img').style.display = 'none';
            document.getElementById('col-3-img').style.display = 'block';
            document.getElementById('col-4-img').style.display = 'none';
        });
    }
    if (productimg.length) {
        productimg.on('click', function() {
            document.getElementById('col-2-img').style.display = 'none';
            document.getElementById('col-3-img').style.display = 'none';
            document.getElementById('col-4-img').style.display = 'block';
        });
    }

    // Login

    var viewPassword = $('.view-password');
    var backLogin = $('.backto');

    if (viewPassword.length) {
        viewPassword.on('click', function(e) {
            e.preventDefault();
            document.getElementById('forget').style.display = 'block';
            document.getElementById('loginbox').style.display = 'none';
        });

    }
    if (backLogin.length) {
        backLogin.on('click', function() {
            document.getElementById('forget').style.display = 'none';
            document.getElementById('loginbox').style.display = 'block';
        });
    }

    // check out

    var clickLogin = $('.check-click');
    var checkShow = $('.check-show');

    if (clickLogin.length) {
        clickLogin.on('click', function(e) {
            e.preventDefault();
            checkShow.slideToggle("slow");
        });
    }

    // Account

    var accountShow = $('#chkk1');
    var accountPassword = $('.acc-password');

    if (accountShow.length) {
        accountShow.on('change', function() {
            accountPassword.slideToggle();
        });
    }

    // Address

    var addressFormShow = $('#chkk3');
    var addressFormSec = $('.address-sec');

    if (addressFormShow.length) {
        addressFormShow.on('change', function() {
            addressFormSec.slideToggle();
        });
    }

    /*
    ========================================
     Fancybox Setting
    ========================================
    */

    if (fancyboxImg.length) {
        fancyboxImg.fancybox();
    }

    /*
    ========================================
     Accordion Setting
    ========================================
    */

    if (accordionFAQ.length) {
        accordionFAQ.accordion();
    }
    /*
    ========================================
     Increse Decrese Setting
    ========================================
    */
    var addPlus = $('.add');
    var removeMinus = $('.minus');

    addPlus.on('click', function() {
        var $qty = $(this).closest('ul').find('.qty');
        var currentVal = parseInt($qty.val(), 10);
        if (!isNaN(currentVal)) {
            $qty.val(currentVal + 1);
        }
    });

    removeMinus.on('click', function() {
        var $qty = $(this).closest('ul').find('.qty');
        var currentVal = parseInt($qty.val(), 10);
        if (!isNaN(currentVal) && currentVal > 0) {
            $qty.val(currentVal - 1);
        }
    });

    /*
    ========================================
     Map Setting
    ========================================
    */
    if (gmap_canvas.length) {
        // Map initialization function Calling 
        initMap();
    }
    /*
    ================================
     CommingSoon Timer
    ================================
    */
    if (comingSoon.length) {
        comingSoonTimer();
    }
    /*
    ================================
     CommingSoon Product Timer
    ================================
    */
    if (comingProduct.length) {
        comingSoonProductTimer();
    };
    /*
    ================================
     Slider news Nav
    ================================
    */
    if (slidernewsNav.length) {
        customdiv();
    }
});

function owlCarouselInit() {
    "use strict";
    /*
	========================================
     owl carousels settings
	======================================== 
	*/
    var mainSlider = $('#yoga-slider');
    var instaSlider = $('#insta-slider');
    var beautifullSlider = $('#beauty-slider');
    var fashionSlider = $('#fashion-slider');
    var collectionSlider = $('#collection-slider');
    var productSlider = $('#product-slider');
    var verticalSlider = $('.vertical_slider');
    var horizontalSlider = $('#horizantal_slider_one');
    var nextNav = '<i class="fa fa-angle-right" aria-hidden="true"></i>';
    var prevNav = '<i class="fa fa-angle-left" aria-hidden="true"></i>';

    // Slider-1
    if (mainSlider.length) {
        mainSlider.owlCarousel({
            items: 2,
            merge: true,
            loop: true,
            margin: 0,
            dots: false,
            nav: true,
            navText: [prevNav, nextNav],
            lazyLoad: true,
            center: true,
            autoplay: false,
            responsive: {
                0: {
                    items: 1
                },
                600: {
                    items: 2
                },
                1000: {
                    items: 2
                }
            }
        })
    };

    // Slider-2	
    if (instaSlider.length) {
        instaSlider.owlCarousel({
            autoplay: false,
            loop: true,
            margin: 30,
            dots: false,
            nav: true,
            navText: [prevNav, nextNav],
            responsive: {
                0: {
                    items: 1
                },
                600: {
                    items: 3
                },
                1000: {
                    items: 5
                }
            }
        })
    };

    // Slider-3
    if (beautifullSlider.length) {
        beautifullSlider.owlCarousel({
            autoplay: false,
            loop: true,
            margin: 0,
            dots: false,
            nav: true,
            navText: [prevNav, nextNav],
            responsive: {
                0: {
                    items: 1
                },
                600: {
                    items: 1
                },
                1000: {
                    items: 1
                }
            }
        })
    };

    // Slider-4
    if (fashionSlider.length) {
        fashionSlider.owlCarousel({
            autoplay: true,
            loop: true,
            margin: 10,
            dots: false,
            nav: true,
            navText: [prevNav, nextNav],
            responsive: {
                0: {
                    items: 2
                },
                600: {
                    items: 3
                },
                1000: {
                    items: 6
                }
            }
        })
    };

    // Slider-5
    if (collectionSlider.length) {
        collectionSlider.owlCarousel({
            autoplay: true,
            loop: true,
            margin: 30,
            dots: false,
            nav: true,
            navText: [prevNav, nextNav],
            responsive: {
                0: {
                    items: 1
                },
                600: {
                    items: 1
                },
                1000: {
                    items: 1
                }
            }
        })
    };

    // Slider-6
    if (verticalSlider.length) {
        verticalSlider.bxSlider({
            mode: 'vertical',
            slideWidth: 300,
            minSlides: 4,
            slideMargin: 20,
            pager: false,
        });
    }

    // Slider-7
    if (horizontalSlider.length) {
        horizontalSlider.owlCarousel({
            loop: true,
            margin: 4,
            dots: false,
            nav: true,
            navText: [prevNav, nextNav],
            autoplay: true,
            responsive: {
                0: {
                    items: 3
                },
                600: {
                    items: 3
                },
                1000: {
                    items: 4
                }
            }
        });
    }

    // Slider-8
    if (productSlider.length) {
        productSlider.owlCarousel({
            autoplay: true,
            loop: true,
            margin: 30,
            dots: false,
            nav: true,
            navText: [prevNav, nextNav],
            responsive: {
                0: {
                    items: 1
                },
                600: {
                    items: 3
                },
                1000: {
                    items: 4
                }
            }
        })
    };
}

function customdiv() {
    "use strict";
    var slidernewsNav = $('#slidernews.owl-theme .owl-nav');
    slidernewsNav.wrap('<div class="custom-nav"></div>');
}

// Contact Map function
function initMap() {
    "use strict";

    var mapDiv = $('#gmap_canvas');

    if (mapDiv.length) {
        var myOptions = {
            zoom: 10,
            scrollwheel: false,
            center: new google.maps.LatLng(-37.81614570000001, 144.95570680000003),
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        var map = new google.maps.Map(document.getElementById('gmap_canvas'), myOptions);
        var marker = new google.maps.Marker({
            map: map,
            position: new google.maps.LatLng(-37.81614570000001, 144.95570680000003)
        });
        var infowindow = new google.maps.InfoWindow({
            content: '<strong>Envato</strong><br>Envato, King Street, Melbourne, Victoria<br>'
        });
        google.maps.event.addListener(marker, 'click', function() {
            infowindow.open(map, marker);
        });

        infowindow.open(map, marker);
    }
}


/*
========================================
 Timer Setting
========================================
*/

// Product Timer
function comingSoonProductTimer() {
	"use strict";
    var comingProduct = $('#demo-product');
    
    // Set the date we're counting down to
    var countDownDate = new Date("June 5, 2018 15:37:25").getTime();

    // Update the count down every 1 second
    var x = setInterval(function() {

        // Get todays date and time
        var now = new Date().getTime();

        // Find the distance between now an the count down date
        var distance = countDownDate - now;

        // Time calculations for days, hours, minutes and seconds
        var days = Math.floor(distance / (1000 * 60 * 60 * 24));
        var hrs = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var mins = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
        var secs = Math.floor((distance % (1000 * 60)) / 1000);

        // Output the result in an element with id="demo"
        document.getElementById("demo-product").innerHTML = "<div class='col-md-3 col-sm-3 col-xs-3'><div class='timer'>" + days + "</div><span>days</span></div><div class='col-md-3 col-sm-3 col-xs-3'><div class='timer'>" + hrs + "</div><span>hrs</span></div><div class='col-md-3 col-sm-3 col-xs-3'><div class='timer'> " + mins + "</div><span>mins </span></div> <div class='col-md-3 col-sm-3 col-xs-3'><div class='timer'>" + secs + "</div><span>secs </span></div> ";

        // If the count down is over, write some text 
        if (distance < 0) {
            clearInterval(x);
            document.getElementById("demo-product").innerHTML = "EXPIRED";
        }
    }, 1000);
}

// Coming Soon Timer

function comingSoonTimer() {
    "use strict";
    // Set the date we're counting down to
    var countDownDate = new Date("June 5, 2018 15:37:25").getTime();

    // Update the count down every 1 second
    var x = setInterval(function() {

        // Get todays date and time
        var now = new Date().getTime();

        // Find the distance between now an the count down date
        var distance = countDownDate - now;

        // Time calculations for days, hours, minutes and seconds
        var days = Math.floor(distance / (1000 * 60 * 60 * 24));
        var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
        var seconds = Math.floor((distance % (1000 * 60)) / 1000);

        // Output the result in an element with id="demo"
        document.getElementById("demo").innerHTML = "<div class='col-md-3 col-sm-3 col-xs-6 time'><div class='timer'>" + days + "</div><span>days</span></div><div class='col-md-3 col-sm-3 col-xs-6 time'><div class='timer'>" + hours + "</div><span>hours</span></div><div class='col-md-3 col-sm-3 col-xs-6 time'><div class='timer'> " + minutes + "</div><span>minutes </span></div> <div class='col-md-3 col-sm-3 col-xs-6'><div class='timer'>" + seconds + "</div><span>seconds </span></div> ";

        // If the count down is over, write some text 
        if (distance < 0) {
            clearInterval(x);
            document.getElementById("demo").innerHTML = "EXPIRED";
        }
    }, 1000);
}
/*
 *****************************************************
 *	END OF THE JS DOCUMENT	*
 *****************************************************
 */