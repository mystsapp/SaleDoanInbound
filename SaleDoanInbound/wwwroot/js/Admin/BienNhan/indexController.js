﻿var indexController = {
    init: function () {
        indexController.registerEvent();
    },

    registerEvent: function () {
        $('.tdVal').click(function () {
            id = $(this).data('id');
            $('#hidId').val(id);
            //var page = $('.active .page-link').text();
            //var page = $('.active span').text();
            //$('#hidPage').val(page);
            //$.ajax({
            //    url: '/CapThes/Index',
            //    data: {
            //        maCT: id
            //    },
            //    dataType: 'json',
            //    type: 'GET',
            //    success: function (response) {
                    
            //    }
            //});

            $('#btnSubmit').click();
        });

        $('#btnNewCTBienNhan').off('click').on('click', function (e) {
            bienNhanId = $(this).data('id');
            if (bienNhanId === '') {
                e.preventDefault();
                bootbox.alert({
                    title: "Information",
                    size: "small",
                    message: "Bạn chưa chọn biên nhận nào nào!"
                });
            }
        });
    }
};
indexController.init();