$(document).ready(function () {
    $(".sidebar-menu").tree();
});

$("div [data-spy='affix']").on("affix.bs.affix", function () {
    if ($("body").hasClass("sidebar-collapse")) {
        $(this).addClass("affix-sidebar-collapse");
    } else {
        $(this).removeClass("affix-sidebar-collapse");
    }
});

$("div [data-spy='affix']").on("affix-top.bs.affix", function () {
    $(this).removeClass("affix-sidebar-collapse");
});

$(document).on("expanded.pushMenu", function () {
    if ($("div [data-spy='affix']").hasClass("affix")) {
        $("div [data-spy='affix']").removeClass("affix-sidebar-collapse");
    }
});

$(document).on("collapsed.pushMenu", function () {
    if ($("div [data-spy='affix']").hasClass("affix") && $(window).width() > 767) {
        $("div [data-spy='affix']").addClass("affix-sidebar-collapse");
    }
});

