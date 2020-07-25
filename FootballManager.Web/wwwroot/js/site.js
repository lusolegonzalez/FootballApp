﻿// Write your Javascript code.

; (function ($) {

    'use strict';

    $('.alert[data-auto-dismiss]').each(function (index, element) {
        var $element = $(element),
            timeout = $element.data('auto-dismiss') || 5000;

        setTimeout(function () {
            //$element.alert('close');
            $element.fadeTo(1000, 500).slideUp(500, function () {
                $element.alert('close');
            });
        }, timeout);
    });

    var mySkins = [
        'skin-blue',
        'skin-black',
        'skin-grey',
        'skin-blue-light',
        'skin-black-light',
        'skin-grey-light'
    ];

    /*
     * Get a prestored setting
     * @param String name Name of of the setting
     * @returns String The value of the setting | null
     */
    function get(name) {
        if (typeof (Storage) !== 'undefined') {
            return localStorage.getItem(name);
        }
    }

    /*
     * Store a new settings in the browser
     * @param String name Name of the setting
     * @param String val Value of the setting
     * @returns void
     */
    function store(name, val) {
        if (typeof (Storage) !== 'undefined') {
            localStorage.setItem(name, val);
        }
    }

    /*
     * Toggles layout classes
     * @param String cls the layout class to toggle
     * @returns void
     */
    function changeLayout(cls) {
        $('body').toggleClass(cls);
        $layout.fixSidebar();
        if ($('body').hasClass('fixed') && cls == 'fixed') {
            $pushMenu.expandOnHover();
            $layout.activate();
        }
        $controlSidebar.fix();
    }

    /*
     * Replaces the old skin with the new skin
     * @param String cls the new skin class
     * @returns Boolean false to prevent link's default action
     */
    function changeSkin(cls) {
        $.each(mySkins,
            function(i) {
                $('body').removeClass(mySkins[i])
            });

        $('body').addClass(cls);
        store('skin', cls);
        return false;
    }

    /*
     * Retrieve default settings and apply them to the template
     * @returns void
     */
    function setup() {
        var tmp = get('skin');
        if (tmp && $.inArray(tmp, mySkins))
            changeSkin(tmp);

        // Add the change skin listener
        $('[data-skin]').on('click',
            function(e) {
                if ($(this).hasClass('knob'))
                    return;
                e.preventDefault()
                changeSkin($(this).data('skin'));
            });

        // Add the layout manager
        $('[data-layout]').on('click',
            function() {
                changeLayout($(this).data('layout'));
            });

        $('[data-controlsidebar]').on('click',
            function() {
                changeLayout($(this).data('controlsidebar'));
                var slide = !$controlSidebar.options.slide;

                $controlSidebar.options.slide = slide;
                if (!slide)
                    $('.control-sidebar').removeClass('control-sidebar-open');
            });

        $('[data-sidebarskin="toggle"]').on('click',
            function() {
                var $sidebar = $('.control-sidebar');
                if ($sidebar.hasClass('control-sidebar-dark')) {
                    $sidebar.removeClass('control-sidebar-dark');
                    $sidebar.addClass('control-sidebar-light');
                } else {
                    $sidebar.removeClass('control-sidebar-light');
                    $sidebar.addClass('control-sidebar-dark');
                }
            });

        $('[data-enable="expandOnHover"]').on('click',
            function() {
                $(this).attr('disabled', true);
                $pushMenu.expandOnHover()
                if (!$('body').hasClass('sidebar-collapse'))
                    $('[data-layout="sidebar-collapse"]').click();
            });

        //  Reset options
        if ($('body').hasClass('fixed')) {
            $('[data-layout="fixed"]').attr('checked', 'checked');
        }
        if ($('body').hasClass('layout-boxed')) {
            $('[data-layout="layout-boxed"]').attr('checked', 'checked');
        }
        if ($('body').hasClass('sidebar-collapse')) {
            $('[data-layout="sidebar-collapse"]').attr('checked', 'checked');
        }
    }

    setup();

    $('[data-toggle="tooltip"]').tooltip();

})(jQuery);
