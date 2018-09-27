$(function(){
    // 再买一次
    $(".J_BuyAgain").on("click", function(){
        var order_id = $(this).data("order-id");
        if (confirm("再次购买?")) {
            $.post(
                "/trade/buyAgain",
                {
                    "order_id": order_id
                },
                function(result){
                    if (result.error) {
                        build("red",result.info,order_id);
                    }
                    else {
                        if (confirm(result.info + "，是否前往购物车?")) {
                            location.href = "http://" + DOMAIN["main"] + "/cart1";
                        }
                    }
                },
                "json"
            );
        }
        return false;
    });


    // 再买一次
    $(".J_BuyOneAgain").on("click", function(){
        var detail_id = $(this).data("detail-id");
        if (confirm("再次购买该商品?")) {
            $.post(
                "/trade/buyOneAgain",
                {
                    "detail_id":detail_id
                },
                function(result){
                    if (result.error) {
                        build("red",result.info,detail_id);
                    }
                    else {
                        if (confirm(result.info + "，是否前往购物车?")) {
                            location.href = "http://" + DOMAIN["main"] + "/cart1";
                        }
                    }
                },
                "json"
            );
        }
        return false;
    });
    
        var data={}
        data.info=[
            {content:"确定要上架商品吗？",title:"上架商品",url:"0113-01.png"},
            {content:"确定要下架商品吗？",title:"下架商品",url:"0113-01.png"},
            {content:"是否取消定单",title:"取消定单",url:"0113-02.png"},
            {content:"是否确认审核通过？",title:"审核通过",url:"0113-03.png"},
        ];    
        data.render=function(i){
            $('.overlay .wrapper .content').text(data.info[i].content);
            $('.overlay .wrapper .title').text(data.info[i].title);
            $('.overlay .wrapper .title').css("background","url(/statics/images/buyer/"+data.info[i].url+") no-repeat"); 
            $('.overlay').show();
        }
        data.callback=function(msg){          
            $('.overlay .wrapper .content').text('');
            $('.overlay .wrapper .title').text(msg);
            $('.overlay .wrapper .title').css("background","url(/statics/images/buyer/0113-03.png) no-repeat"); 
            $('.influone').hide();
            $('.influtwo').show();
            $('.overlay').show();
        }
    // 申请取消订单
    $(".J_ApplyCancelOrder").on("click", function(){
        data.order_id= $(this).data("order-id");
        $('overlay').show();
        data.render(2);
        return false;
    });
    $('.btn-confirm').on('click',function(){
        $('.overlay').hide();
        $.post(
            "/trade/applyCancel",
            {
                "order_id": data.order_id
            },
            function(result){
                data.callback(result.info);
                if (!result.error) {
                    location.reload();
                }
            },
            "json"
        );
    })
    $('.btn-close').on('click',function(){
        $('.overlay').hide();
    })

});
//
// 
