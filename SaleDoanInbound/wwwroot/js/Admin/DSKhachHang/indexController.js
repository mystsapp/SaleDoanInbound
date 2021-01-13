﻿var indexController = {
    init: function () {
        indexController.registerEvent();
    },

    registerEvent: function () {
        //////////////////////////////////////////////////////////////////////////////// CreateKhachPartial

        // create new
        $('#btnNewKhachHang').off('click').on('click', function () {

            tourid = $(this).data('tourid');

            $('#sDSKhach').hide(500);

            var url = '/DSKhachHangs/KhachHangCreatePartial';
            $.get(url, { tourid: tourid }, function (response) {

                $('#khachHangCreatePartial').show(500);

                $('#khachHangCreatePartial').html(response);

            });
        });
        // create new

        //// close create partial
        //$('#btnCloseKhachCreatePartial').off('click').on('click', function () {
        //    $('#sDSKhach').show(500);
        //});
        //$('#btnBackKhachHangCreatePartial').off('click').on('click', function () {
        //    $('#khachHangCreatePartial').hide(500);
        //    $('#sDSKhach').show(500);
        //});
        //// close create invoice partial

        //////////////////////////////////////////////////////////////////////////////// CreateKhachPartial

        //$.each($('.invoice-cursor-pointer'), function (i, item) {

        //    var huy = $(item).data('huy');
        //    //console.log(huy);
        //    if (huy === 'True') {
        //        $(this).addClass('bg-secondary');
        //    }

        //});

        //$('.tdInvoiceVal').click(function () {
        //    id = $(this).data('id');
        //    $('#hidId').val(id);
        //    var page = $('.active .page-link').text();
        //    //var page = $('.active span').text();
        //    $('#hidPage').val(page);
        //    //$.ajax({
        //    //    url: '/CapThes/Index',
        //    //    data: {
        //    //        maCT: id
        //    //    },
        //    //    dataType: 'json',
        //    //    type: 'GET',
        //    //    success: function (response) {
                    
        //    //    }
        //    //});

        //    $('#btnSubmit').click();
        //});

        //$('#btnNewCTVAT').off('click').on('click', function (e) {
        //    invoiceId = $(this).data('id');
        //    if (invoiceId === '') {
        //        e.preventDefault();
        //        bootbox.alert({
        //            title: "Information",
        //            size: "small",
        //            message: "Bạn chưa chọn invoice nào!"
        //        });
        //    }
        //});
        //$('#btnNewCTInvoice').off('click').on('click', function (e) {
        //    invoiceId = $(this).data('id');
        //    if (invoiceId === '') {
        //        e.preventDefault();
        //        bootbox.alert({
        //            title: "Information",
        //            size: "small",
        //            message: "Bạn chưa chọn invoice nào!"
        //        });
        //    }
        //});
        //$('#btnCopyCTVAT').off('click').on('click', function (e) {
        //    invoiceId = $(this).data('id');

        //    if (invoiceId === '') {
                
        //        bootbox.alert({
        //            title: "Information",
        //            size: "small",
        //            message: "Bạn chưa chọn invoice nào!"
        //        });
        //    }
        //    else {

        //        // check CTInvoice xem co ton tai trong CTVAT chua
        //        //$.ajax({
        //        //    url: '/CTVATs/CheckExist',
        //        //    data: {
        //        //        invoiceId: invoiceId
        //        //    },
        //        //    dataType: 'json',
        //        //    type: 'GET',
        //        //    success: function (response) {
        //        //        if (response) {
        //        //            bootbox.alert({
        //        //                title: "Information",
        //        //                size: "small",
        //        //                message: "Đã tồn tại 1 item nào đó!"
        //        //            });
        //        //            window.location.reload();
        //        //        }
        //        //        console.log(response);
        //        //    }
        //        //});
        //    // check CTInvoice xem co ton tai trong CTVAT chua

        //        $('#frmCopyCTVAT').submit();
        //    }

        //});


        //$('.btnHuyInvoice').off('click').on('click', function () {
        //    id = $(this).data('id');
        //    strUrl = $(this).data('url');

        //    $.get('/Invoices/HuyInvoicePartialIndex', { id: id, strUrl: strUrl }, function (response) {

        //        console.log(response);
        //        $('#huyInvoiceModal').modal('show');
        //        $('.huyInvoicePartial').html(response);
        //        $('#huyInvoiceModal').draggable();
        //    });
        //});


    }
};
indexController.init();