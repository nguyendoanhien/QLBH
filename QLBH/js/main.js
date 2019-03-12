$(document).ready(function() {

    cat();
    brand();
    product();
    appStatus();

    function appStatus() {

        window.$.ajax({
            type: "POST",
            //url: "Default.aspx/GetAppStatus",
            data: {},
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function(data) {
                window.$("#get_appstatus").html(data.d);
            }
        });

    }

    function cat() {

        window.$.ajax({
            type: "POST",
            url: "Default.aspx/GetLeftMenus",
            data: {},
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function(data) {

                window.$("#get_category").html(data.d);
            }
        });

    }

    function brand() {
        $.ajax({
            type: "POST",
            url: "Default.aspx/GetBrands",
            data: {},
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function(data) {

                $("#get_brand").html(data.d);
            }
        });
    }

    function product() {
        var fcAjax = {};
        getProducts(fcAjax);
    }

    $("body").delegate(".category",
        "click",
        function(event) {

            $("#get_product").html("<h3>Loading...</h3>");
            event.preventDefault();
            var cid = $(this).attr("cid");
            var fcAjax = {
                cat_id: cid
            };
            getProducts(fcAjax);
        });

    function getProducts(fcAjax) {
        $(".overlay").show();
        $.ajax({
            type: "POST",
            url: "Default.aspx/GetProducts",
            data: JSON.stringify({ fc: fcAjax }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function(data) {
                page();
                $("[id$='get_product']").html(data.d);
                $(".overlay").hide();
            }
        });
    }

    $("body").delegate(".selectBrand",
        "click",
        function(event) {

            $("#get_product").html("<h3>Loading...</h3>");
            event.preventDefault();
            var cid = $(this).attr("cid");
            var fcAjax = {
                brand_id: cid
            };
            getProducts(fcAjax);

        });
    $("body").delegate("#product",
        "click",
        function(event) {
            var pid = $(this).attr("pid");
            event.preventDefault();
            $(".overlay").show();
            var fcAjax = {
                productid: pid
            };

            $.ajax({
                type: "POST",
                url: "Default.aspx/ProductsClick",
                data: JSON.stringify({ fc: fcAjax }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function(data) {

                    countItem();
                    getCartItem();
                    $("#product_msg").html(data.d);
                    $(".overlay").hide();
                }
            });

        });
    $("[id$='search_btn']").click(function() {
        $("[id$='get_product']").html("<h3>Loading...</h3>");
        var keyword = $("#search").val();
        if (keyword !== "") {
            var fcAjax = {
                searchkey: keyword
            };
            getProducts(fcAjax);

        }
        return false;
    });
    $("#login").on("submit",
        function(event) {
            event.preventDefault();
            var fcAjax = {
                email: $("#email").val(),
                password: $("#password").val()
            };
            alert($("#login").serialize());
            $.ajax({
                type: "POST",
                url: "Default.aspx/Login",
                data: JSON.stringify({ fc: fcAjax }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function() {
                    aler(123);
                }
            });
            return false;
        });
    $("body").delegate("[id$='get_product_all']",
        "click",
        function() {
            var fcAjax = {
            };
            getProducts(fcAjax);

        });
    $("#signup_form").on("submit",
        function(event) {
            event.preventDefault();
            //$(".overlay").show();
            $.ajax({
                url: "register.php",
                method: "POST",
                data: $("#signup_form").serialize(),
                success: function(data) {
                    $(".overlay").hide();
                    if (data === "register_success") {
                        window.location.href = "cart.php";
                    } else {
                        $("#signup_msg").html(data);
                    }

                }
            });
        });
    countItem();

    function countItem() {
        var fcAjax = {};
        $.ajax({
            type: "POST",
            url: "Default.aspx/CountItem",
            data: JSON.stringify({ fc: fcAjax }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function(data) {
                $(".badge").html(data.d);
            }
        });
    }

    getCartItem();

    function getCartItem() {
        var fcAjax = {};
        var acAjax = { LaySanPhamGioHang:true};
        $.ajax({
            type: "POST",
            url: "Default.aspx/GetCartItems",
            data: JSON.stringify({ fc: fcAjax,ac:acAjax }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function(data) {
                $("#cart_product").html(data.d);
            }
        });


    }

    $("body").delegate(".qty",
        "keyup",
        function(event) {
            event.preventDefault();
            var row = $(this).parent().parent();
            var price = row.find(".price").val();
            var qty = row.find(".qty").val();
            if (isNaN(qty)) {
                qty = 1;
            };
            if (qty < 1) {
                qty = 1;
            };
            var total = price * qty;
            row.find(".total").val(total);
            var net_total = 0;
            $(".total").each(function() {
                net_total += ($(this).val() - 0);
            });
            $(".net_total").html("Total : $ " + net_total);

        });
    $("body").delegate(".remove",
        "click",
        function() {
            var remove = $(this).parent().parent().parent();
            var removeId = remove.find(".remove").attr("remove_id");
            $.ajax({
                url: "action.php",
                method: "POST",
                data: { removeItemFromCart: 1, rid: removeId },
                success: function(data) {
                    $("#cart_msg").html(data);
                    checkOutDetails();
                }
            });
        });
    $("body").delegate(".update",
        "click",
        function() {
            var update = $(this).parent().parent().parent();
            var updateId = update.find(".update").attr("update_id");
            var qty = update.find(".qty").val();
            $.ajax({
                url: "action.php",
                method: "POST",
                data: { updateCartItem: 1, update_id: updateId, qty: qty },
                success: function(data) {
                    $("#cart_msg").html(data);
                    checkOutDetails();
                }
            });


        });
    checkOutDetails();
    net_total();

    function checkOutDetails() {
        //$('.overlay').show();
        var fcAjax = {};
        var acAjax = { LaySanPhamGioHangCheckOut:true};
        $.ajax({
            type: "POST",
            url: "Default.aspx/GetCartItems",
            data: JSON.stringify({ fc: fcAjax,ac:acAjax }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function(data) {
                $(".overlay").hide();
                $("#cart_checkout").html(data.d);
                net_total();
            }
        });

    }

    function net_total() {
        var net_total = 0;
        $(".qty").each(function() {
            var row = $(this).parent().parent();
            var price = row.find(".price").val();
            var total = price * $(this).val() - 0;
            row.find(".total").val(total);
        });
        $(".total").each(function() {
            net_total += ($(this).val() - 0);
        });
        $(".net_total").html("Total : $ " + net_total);
    }

    function page() {

        $.ajax({
            type: "POST",
            url: "Default.aspx/GetPages",
            data: {},
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function(data) {

                $("[id$='pageno']").html(data.d);
            }
        });
    }

    $("body").delegate("#page",
        "click",
        function() {
            var pn = $(this).attr("page");
            var fcAjax = {
                page_id: pn
            };
            $.ajax({
                type: "POST",
                url: "Default.aspx/GetProducts",
                data: JSON.stringify({ fc: fcAjax }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function(data) {

                    $("[id$='get_product']").html(data.d);
                }
            });
            return false;


        });
})