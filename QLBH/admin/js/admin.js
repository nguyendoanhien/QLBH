$(document).ready(function () {
    loadInputProducts();
    $("[id$='outputCombo']").on('keyup mouseup',
        '.quantity',
        function () {
            getMoneyBefore();
            $("[id$='percent']").keyup();
        });

    $("[id$='percent']").on('keyup mouseup',
        function (e) {
            debugger;
            if (parseInt($(this).val()) > parseInt($(this).attr('max'))
                && e.keyCode !== 46 // keycode for delete
                && e.keyCode !== 8 // keycode for backspace
            ) {
                e.preventDefault();
                $(this).val(100);
            }
            $("[id$='moneyafter']").val((100 - $(this).val()) * $("[id$='moneybefore']").val() / 100);
        });
    function loadInputProducts() {
        debugger;
        $(".overlay").show();
        var fcAjax = {};
        $.ajax({
            type: "POST",
            url: "/Default.aspx/GetProductsAdmin",
            data: {},
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {

                var obj = JSON.parse(data.d);
                var cont = "";
                $.each(obj,
                    function (i, val) {

                        cont += "<tr>";
                        cont += "<td><input type = 'checkbox' value = '" + val.MaSp + "' ></td>";
                        cont += "<td><img class='img-responsive' src='/product_images/" + val.HinhSp + "'></td>";
                        cont += "<td>" + val.TenSp + "</td>";
                        cont += "<td class='price'>" + val.DonGia + "</td>";
                        cont += "</tr>";
                    });


                $("[id$='inputCombo'] > tbody").html(cont);
                $(".overlay").hide();
            }
        });
    }
    function getMoneyBefore() {
        debugger;
        var moneyBefore = 0;
        $.each($("[id$='outputCombo'] > tbody > tr"),
            function () {
                debugger;
                moneyBefore += $(this).find(".price").html() * $(this).find('.quantity').val();
            });
        $("[id$='moneybefore']").val(moneyBefore);
    }
    $("[id$='btnInputThem']").on('click',
        function () {

            var $selectedRowHtml = $("[id$='inputCombo'] input:checked").parents('tr');
            var outputHtml;

            $.each($selectedRowHtml,
                function (i, val) {
                    $(val).clone().appendTo($("[id$='outputCombo'] > tbody")).append("<td><input type='number' class='quantity' value='1' style='width:75%'></td>");

                });
            //$("[id$='outputCombo'] > tbody").html($("[id$='outputCombo'] > tbody").html() + outputHtml);

            $selectedRowHtml.remove();
            getMoneyBefore();
        });


    $("[id$='btnOutputXoa']").on('click',
        function () {

            var $selectedRowHtml = $("[id$='outputCombo'] input:checked").parents('tr');
            var outputHtml;

            $.each($selectedRowHtml,
                function (i, val) {
                    $(val).clone().appendTo($("[id$='inputCombo'] > tbody")).find('td:last').remove();

                });
            //$("[id$='outputCombo'] > tbody").html($("[id$='outputCombo'] > tbody").html() + outputHtml);

            $selectedRowHtml.remove();
            getMoneyBefore();
        });

    $("[id$='btnlaphoadon']").on('click',
        function () {
            var objList = new Array();

            $("[id$='outputCombo'] tr").each(function () {
                var maSp = $(this).find('input[type=checkbox]').val();
                var soLuong = $(this).find('.quantity').val();
                if (typeof maSp !== 'undefined' && typeof soLuong !== 'undefined') {
                    objList.push(new Array(maSp, soLuong));
                }


            });
            var phantram = $("[id$='percent']").val();
            var tienGiam = $("[id$='moneybefore']").val();
            $.ajax({
                type: "POST",
                url: "/admin/DonHang.aspx/LapHoaDon",
                data: "{ data:'"+ JSON.stringify(objList) +"',phanTram:'"+phantram+"',tienGiam:'"+tienGiam+"'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    alert("Đã lập hóa đơn");


                }
            });

        });
});