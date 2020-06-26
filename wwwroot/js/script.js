
$(document).ready(function () {

    // cell
    
    $(".cash ").mouseover(function () {
        $(".add_to_card ").removeClass("show")
        $("span").addClass("show")
    })
    $(".card .cash").mouseout(function () {
        $(".add_to_card ").addClass("show")
        $("span").removeClass("show")
    })

    // $(".card_two .two .cash").mouseover(function () {
    //     $(".add_to_card ").removeClass("show")
    //     $("span").addClass("show")
    // })

    // $(".card_two .two .cash").mouseout(function () {
    //     $(".add_to_card ").addClass("show")
    //     $("span").removeClass("show")
    // })

    // $(".card_three a img ").mouseover(function () {
    //     $(".three .cash .add_to_card ").removeClass("show")
    //     $(".three .cash span").addClass("show")
    // })

    // $(".card_three a img").mouseout(function () {
    //     $(".three .cash .add_to_card ").addClass("show")
    //     $(".three .cash span").removeClass("show")
    // })

    // $(".card_four a img ").mouseover(function () {
    //     $(".four .cash .add_to_card ").removeClass("show")
    //     $(".four .cash span").addClass("show")
    // })

    // $(".card_four a img").mouseout(function () {
    //     $(".four .cash .add_to_card ").addClass("show")
    //     $(".four .cash span").removeClass("show")
    // })

    // $(".card_five a img ").mouseover(function () {
    //     $(".five .cash .add_to_card ").removeClass("show")
    //     $(".five .cash span").addClass("show")
    // })

    // $(".card_five a img").mouseout(function () {
    //     $(".five .cash .add_to_card ").addClass("show")
    //     $(".five .cash span").removeClass("show")
    // })

    // $(".card_six a img ").mouseover(function () {
    //     $(".six .cash .add_to_card ").removeClass("show")
    //     $(".six .cash span").addClass("show")
    // })

    // $(".card_six a img").mouseout(function () {
    //     $(".six .cash .add_to_card ").addClass("show")
    //     $(".six .cash span").removeClass("show")
    // })

    // $(".card_seven a img ").mouseover(function () {
    //     $(".seven .cash .add_to_card ").removeClass("show")
    //     $(".seven .cash span").addClass("show")
    // })

    // $(".card_seven a img").mouseout(function () {
    //     $(".seven .cash .add_to_card ").addClass("show")
    //     $(".seven .cash span").removeClass("show")
    // })

    // $(".card_eight a img ").mouseover(function () {
    //     $(".eight .cash .add_to_card ").removeClass("show")
    //     $(".eight .cash span").addClass("show")
    // })

    // $(".card_eight a img").mouseout(function () {
    //     $(".eight .cash .add_to_card ").addClass("show")
    //     $(".eight .cash span").removeClass("show")
    // })

    // filter in shelf
    // $(".filter_menu").hide();
    // $(".filter").click(function () {
    //     $(".filter_menu").removeClass("d-none");
    //     $(".filter_menu").toggle(1000)
    // })


    // accardion
    $(".first").click(function () {
        $(".first_body").not($(this).next()).slideUp(500);
        $(this).next().slideToggle(500);
    });

    $(".card-header").click(function () {
        $(".first div").removeClass("color")
        $(this).addClass("color");
    })

    $(".second").click(function () {
        $(".second_body").not($(this).next()).slideUp(500);
        $(this).next().slideToggle(500);
    });

    $(".card-header").click(function () {
        $(".second div").removeClass("color")
        $(this).addClass("color");
    })

    $(".third").click(function () {
        $(".third_body").not($(this).next()).slideUp(500);
        $(this).next().slideToggle(500);
    });

    $(".card-header").click(function () {
        $(".third div").removeClass("color")
        $(this).addClass("color");
    })

    $(".fourth").click(function () {
        $(".fourth_body").not($(this).next()).slideUp(500);
        $(this).next().slideToggle(500);
    });

    $(".card-header").click(function () {
        $(".fourth div").removeClass("color")
        $(this).addClass("color");
    })



    // tab
    $("#tab_item a").click(function () {
        $(".tab div").hide();
        $(".tab div").filter(this.hash).show();
        $("#tab_item a").removeClass("show");
        $(this).addClass("show");
    })

    $("#tab_item2 a").click(function () {
        $(".tab2 div").hide();
        $(".tab2 div").filter(this.hash).show();
        $("#tab_item2 a").removeClass("show");
        $(this).addClass("show");
    })

    $("#tab_item3 a").click(function () {
        $(".tab3 div").hide();
        $(".tab3 div").filter(this.hash).show();
        $("#tab_item3 a").removeClass("show");
        $(this).addClass("show");
    })

    $("#tab_item4 a").click(function () {
        $(".tab4 div").hide();
        $(".tab4 div").filter(this.hash).show();
        $("#tab_item4 a").removeClass("show");
        $(this).addClass("show");
    })

    // shop_list
    $(".first_image").mouseover(function () {
        $(".first").removeClass("show")
    })
    $(".first_image").mouseout(function () {
        $(".first").addClass("show")
    })

    $(".second_image").mouseover(function () {
        $(".second").removeClass("show")
    })
    $(".second_image").mouseout(function () {
        $(".second").addClass("show")
    })

    $(".third_image").mouseover(function () {
        $(".third").removeClass("show")
    })
    $(".third_image").mouseout(function () {
        $(".third").addClass("show")
    })

    $(".fourth_image").mouseover(function () {
        $(".fourth").removeClass("show")
    })
    $(".fourth_image").mouseout(function () {
        $(".fourth").addClass("show")
    })


    // shop_list_slider
    $(".first_picture ").mouseover(function () {
        $(".about .first a").removeClass("slide")
        $(".about .first span").addClass("slide")
    })

    $(".first_picture").mouseout(function () {
        $(".about .first a").addClass("slide")
        $(".about .first span").removeClass("slide")
    })

    $(".second_picture ").mouseover(function () {
        $(".about .second a").removeClass("slide")
        $(".about .second span").addClass("slide")
    })

    $(".second_picture").mouseout(function () {
        $(".about .second a").addClass("slide")
        $(".about .second span").removeClass("slide")
    })

    $(".third_picture ").mouseover(function () {
        $(".about .third a").removeClass("slide")
        $(".about .third span").addClass("slide")
    })

    $(".third_picture").mouseout(function () {
        $(".about .third a").addClass("slide")
        $(".about .third span").removeClass("slide")
    })

    $(".fourth_picture ").mouseover(function () {
        $(".about .fourth a").removeClass("slide")
        $(".about .fourth span").addClass("slide")
    })

    $(".fourth_picture").mouseout(function () {
        $(".about .fourth a").addClass("slide")
        $(".about .fourth span").removeClass("slide")
    })

    $(".fifth_picture ").mouseover(function () {
        $(".about .fifth a").removeClass("slide")
        $(".about .fifth span").addClass("slide")
    })

    $(".fifth_picture").mouseout(function () {
        $(".about .fifth a").addClass("slide")
        $(".about .fifth span").removeClass("slide")
    })


    $('.multiple-items').slick({
        infinite: true,
        slidesToShow: 4,
        slidesToScroll: 1,
        dots: true,
        autoplay: true,
        autoplaySpeed: 1000
    });

    // product_list

    $("#list_item a").click(function () {
        $(".list div").hide();
        $(".list div").filter(this).show();
        $("#list_item a").removeClass("show");
        $(this).addClass("show");
    })
});
// выбор товара
document.querySelectorAll('.btn-counter').forEach(btn => {
    btn.addEventListener('click', obj => {

        let operation = obj.currentTarget.getAttribute('data-action');
        let counterObj = document.getElementById('counter');
        counterObj.value = 1 * counterObj.value + (operation === 'inc' ? 1 : -1) * 1;
        if (1 * counterObj.value < 0) counterObj.value = 0;
        if (1 * counterObj.value > 99) counterObj.value = 99;
    });
})
// стрелка наверх
$(document).ready(function () {
    $('body').append('<a href="#" id="go_to_head" title="up"><i class="fas fa-chevron-up"></i></a>');
});

$(function () {
    $.fn.scrollToTop = function () {
        $(this).hide().removeAttr("href");
        if ($(window).scrollTop() >= "250") $(this).fadeIn("slow")
        let scrollDiv = $(this);
        $(window).scroll(function () {
            if ($(window).scrollTop() <= "250") $(scrollDiv).fadeOut("slow")
            else $(scrollDiv).fadeIn("slow")
        });
        $(this).click(function () {
            $("html, body").animate({ scrollTop: 0 }, "slow")
        })
    }
});

$(function () {
    $("#go_to_head").scrollToTop();
});



// basket

