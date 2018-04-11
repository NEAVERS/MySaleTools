(function($){

    $.yunmayi = $.yunmayi || {};

    $.yunmayi.city = function(options){

        $.extend(this, {
            // 配置参数
            configs: {
                containerId: "", // 容器id
                editable: true, // 是否可编辑
                welcomeTip: "请选择省市区", // 提示语
                afterProvSelect: function(id, name){},
                afterCitySelect: function(id, name){},
                afterAreaSelect: function(id, name){}
            },

            // 容器jquery对象
            container: null,

            // 元素节点
            elements: {},

            // index
            index: $.yunmayi.city.index
        });

        // 自定义配置
        options = options || {};

        // 合并配置参数
        $.extend(this.configs, options);

        // 容器
        this.container = $(this.configs.containerId);

        // 自动初始化
        if (this.configs.autoInit) {
            this.initialize();
        }

        ++$.yunmayi.city.index;
    }

    $.extend($.yunmayi.city.prototype, {
        // 初始化
        initialize: function(){
            this.createElements();
            this.createHtml();
            this.bindEvent();
            this.provInit();
        },
        provInit: function(){
            var that = this;
            var pid = parseInt(this.elements.phidden.val());

            this.getProvList(function(result){
                var html_str = "";
                var cur_class = "";
                var pname = "";

                for (var k in result) {
                    cur_class = "";
                    if (result[k].number == pid) {
                        cur_class = "class=\"cur\"";
                        pname = result[k].name;
                        that.elements.phidden.data("name", pname);
                    }
                    html_str += "<a href=\"javascript:;\" "+cur_class+" data-id=\""+result[k].number+"\">"+result[k].name+"</a>";
                }

                that.elements.pdd.html(html_str);
                that.tipShow();

                that.configs.afterProvSelect(pid, pname);

                that.cityInit();
            });
        },
        cityInit: function(){
            var that = this;
            var pid = parseInt(this.elements.phidden.val());

            if (pid > 0) {
                this.getCityList(pid, function(result){
                    var cid = parseInt(that.elements.chidden.val());
                    var cname = "";
                    var html_str = "";
                    var cur_class = "";

                    for (var k in result) {
                        cur_class = "";
                        if (result[k].number == cid) {
                            cur_class = "class=\"cur\"";
                            cname = result[k].name;
                            that.elements.chidden.data("name", cname);
                        }
                        html_str += "<a href=\"javascript:;\" "+cur_class+" data-id=\""+result[k].number+"\">"+result[k].name+"</a>";
                    }

                    that.elements.cdd.html(html_str);
                    that.tabShow(2);
                    that.tipShow();

                    that.configs.afterCitySelect(cid, cname);

                    that.areaInit();
                });
            }
        },
        areaInit: function(){
            var that = this;
            var cid = parseInt(that.elements.chidden.val());

            if (cid > 0) {
                this.getAreaList(cid, function(result){
                    var aid = parseInt(that.elements.ahidden.val());
                    var aname = "";
                    var html_str = "";
                    var cur_class = "";

                    for (var k in result) {
                        cur_class = "";
                        if (result[k].number == aid) {
                            cur_class = "class=\"cur\"";
                            aname = result[k].name;
                            that.elements.ahidden.data("name", aname);
                        }
                        html_str += "<a href=\"javascript:;\" "+cur_class+" data-id=\""+result[k].number+"\">"+result[k].name+"</a>";
                    }

                    that.elements.add.html(html_str);
                    that.tabShow(3);
                    that.tipShow();

                    that.configs.afterAreaSelect(aid, aname);
                });
            }
        },
        // 创建元素
        createElements: function(){
            var that = this;
            var endTip = this.index == 0 ? "" : "_" + this.index;
            var pid = parseInt(this.container.data("pid"));
            var cid = parseInt(this.container.data("cid"));
            var aid = parseInt(this.container.data("aid"));

            pid = isNaN(pid) ? 0 : pid;
            cid = isNaN(cid) ? 0 : cid;
            aid = isNaN(aid) ? 0 : aid;

            this.elements.header = $("<div>", {"class": "wgt_city_select_hd"});
            this.elements.title = $("<div>", {"class": "wgt_city_title", "text": that.configs.welcomeTip});
            this.elements.icon = $("<i>", {"class": "iconfont", "html": "&#xe607;"});

            this.elements.body = $("<div>", {"class": "wgt_city_select_bd"});
            this.elements.tabs = $("<div>", {"class": "wgt_city_select_tabs"});
            this.elements.ptab = $("<a>", {"class": "wgt_city_select_tab cur", "href": "javascript:;", "text": "省份"});
            this.elements.ctab = $("<a>", {"class": "wgt_city_select_tab", "href": "javascript:;", "text": "城市"});
            this.elements.atab = $("<a>", {"class": "wgt_city_select_tab", "href": "javascript:;", "text": "区县"});
            this.elements.contents = $("<div>", {"class": "wgt_city_select_contents"});
            this.elements.pcontent = $("<div>", {"class": "wgt_city_select_content wgt_city_select_content_show"});
            this.elements.ccontent = $("<div>", {"class": "wgt_city_select_content"});
            this.elements.acontent = $("<div>", {"class": "wgt_city_select_content"});
            this.elements.pdl = $("<dl>");
            this.elements.pdd = $("<dd>", {"class": "clearfix"});
            this.elements.cdl = $("<dl>");
            this.elements.cdd = $("<dd>", {"class": "clearfix"});
            this.elements.adl = $("<dl>");
            this.elements.add = $("<dd>", {"class": "clearfix"});

            this.elements.phidden = $("<input>", {"type": "hidden", "name": "prov_id"+endTip, "value": pid, "data-name": ""});
            this.elements.chidden = $("<input>", {"type": "hidden", "name": "city_id"+endTip, "value": cid, "data-name": ""});
            this.elements.ahidden = $("<input>", {"type": "hidden", "name": "area_id"+endTip, "value": aid, "data-name": ""});
        },
        // 生成html模板
        createHtml: function(){
            var that = this;

            this.container
                .append(
                    this.elements.header
                        .append(this.elements.title)
                        .append(this.elements.icon)
                )
                .append(
                    this.elements.body
                        .append(
                            this.elements.tabs
                                .append(this.elements.ptab)
                                .append(this.elements.ctab)
                                .append(this.elements.atab)
                        )
                        .append(
                            this.elements.contents
                                .append(
                                    this.elements.pcontent
                                        .append(
                                            this.elements.pdl.append(this.elements.pdd)
                                        )
                                )
                                .append(
                                    this.elements.ccontent
                                        .append(
                                            this.elements.cdl.append(this.elements.cdd)
                                        )
                                )
                                .append(
                                    this.elements.acontent
                                        .append(
                                            this.elements.adl.append(this.elements.add)
                                        )
                                )
                        )
                )
                .append(this.elements.phidden)
                .append(this.elements.chidden)
                .append(this.elements.ahidden);
        },
        // 事件绑定
        bindEvent: function(){
            var that = this;

            // 内容显示
            this.elements.header.on("click", function(){
                that.elements.body.css({"display": "block"});
            });

            // tab
            this.elements.ptab.on("click", function(){
                that.tabShow(1);
            });
            this.elements.ctab.on("click", function(){
                that.tabShow(2);
            });
            this.elements.atab.on("click", function(){
                that.tabShow(3);
            });

            // content
            this.elements.pdd.on("click", "a", function(){
                if (!$(this).hasClass("cur")) {
                    var _t = $(this);
                    var pid = parseInt(_t.data("id"));
                    var pname = _t.text();

                    that.elements.cdd.html("");
                    that.elements.add.html("");
                    that.elements.chidden.val(0);
                    that.elements.chidden.data("name", "");
                    that.elements.ahidden.val(0);
                    that.elements.ahidden.data("name", "");

                    that.getCityList(pid, function(result){
                        var html_str = "";
                        for (var k in result) {
                            html_str += "<a href=\"javascript:;\" data-id=\""+result[k].number+"\">"+result[k].name+"</a>";
                        }

                        that.elements.phidden.val(pid);
                        that.elements.phidden.data("name", pname);
                        that.tabShow(2);
                        that.tipShow();
                        that.elements.cdd.html(html_str);
                        _t.addClass("cur")
                        _t.siblings("a").removeClass("cur");

                        that.configs.afterProvSelect(pid, pname);
                    });
                }

                return false;
            });
            this.elements.cdd.on("click", "a", function(){
                if (!$(this).hasClass("cur")) {
                    var _t = $(this);
                    var cid = parseInt(_t.data("id"));
                    var cname = _t.text();

                    that.elements.add.html("");
                    that.elements.ahidden.val(0);
                    that.elements.ahidden.data("name", "");

                    that.getAreaList(cid, function(result){
                        var html_str = "";
                        for (var k in result) {
                            html_str += "<a href=\"javascript:;\" data-id=\""+result[k].number+"\">"+result[k].name+"</a>";
                        }

                        that.elements.chidden.val(cid);
                        that.elements.chidden.data("name", cname);
                        that.tabShow(3);
                        that.tipShow();
                        that.elements.add.html(html_str);
                        _t.addClass("cur");
                        _t.siblings("a").removeClass("cur");

                        that.configs.afterCitySelect(cid, cname);
                    });
                }
            });
            this.elements.add.on("click", "a", function(){
                if (!$(this).hasClass("cur")) {
                    var _t = $(this);
                    var aid = parseInt(_t.data("id"));
                    var aname = _t.text();

                    that.elements.ahidden.val(aid);
                    that.elements.ahidden.data("name", aname);
                    that.tipShow();
                    _t.addClass("cur");
                    _t.siblings("a").removeClass("cur");

                    that.configs.afterAreaSelect(aid, aname);

                    that.elements.body.css({"display": "none"});
                }
            });


            // 不隐藏
            this.container.on("click", function(){
                return false;
            });

            // 隐藏
            $(document).on("click", function(e){
                that.elements.body.css({"display": "none"});
            });
        },
        // tab切换
        tabShow: function(mode){
            switch (mode) {
                case 1:
                    this.elements.ptab.addClass("cur");
                    this.elements.ctab.removeClass("cur");
                    this.elements.atab.removeClass("cur");
                    this.elements.pcontent.addClass("wgt_city_select_content_show");
                    this.elements.ccontent.removeClass("wgt_city_select_content_show");
                    this.elements.acontent.removeClass("wgt_city_select_content_show");
                    break;
                case 2:
                    this.elements.ptab.removeClass("cur");
                    this.elements.ctab.addClass("cur");
                    this.elements.atab.removeClass("cur");
                    this.elements.pcontent.removeClass("wgt_city_select_content_show");
                    this.elements.ccontent.addClass("wgt_city_select_content_show");
                    this.elements.acontent.removeClass("wgt_city_select_content_show");
                    break;
                case 3:
                    this.elements.ptab.removeClass("cur");
                    this.elements.ctab.removeClass("cur");
                    this.elements.atab.addClass("cur");
                    this.elements.pcontent.removeClass("wgt_city_select_content_show");
                    this.elements.ccontent.removeClass("wgt_city_select_content_show");
                    this.elements.acontent.addClass("wgt_city_select_content_show");
                    break;
            }
        },
        // 显示提示
        tipShow: function(){
            var tip = "";
            var pname = this.elements.phidden.data("name");
            var cname = this.elements.chidden.data("name");
            var aname = this.elements.ahidden.data("name");

            if (pname.length > 0) {
                tip += pname;
                if (cname.length > 0) {
                    tip += "<span style=\"color:#cccccc;\">&nbsp;/&nbsp;</span>" + cname;
                    if (aname.length > 0) {
                        tip += "<span style=\"color:#cccccc;\">&nbsp;/&nbsp;</span>" + aname;
                    }
                }
                this.elements.title.addClass("wgt_city_title_select").html(tip);
            }
        },
        // 获取省份信息列表
        getProvList: function(callback){
            if ($.yunmayi.city.cache.prov != null) {
                callback($.yunmayi.city.cache.prov);
            }
            else {
                $.ajax({
                    type: "POST",
                    url: $.yunmayi.city.url.prov,
                    dataType: "jsonp",
                    success: function(result){
                        $.yunmayi.city.cache.prov = result;
                        callback($.yunmayi.city.cache.prov);
                    }
                });
            }
        },
        // 获取城市信息列表
        getCityList: function(provId, callback){
            if ($.yunmayi.city.cache.city[provId] != undefined) {
                callback($.yunmayi.city.cache.city[provId]);
            }
            else {
                $.ajax({
                    type: "POST",
                    url: $.yunmayi.city.url.city,
                    dataType: "jsonp",
                    data: {
                        prov_id: provId
                    },
                    success: function(result){
                        $.yunmayi.city.cache.city[provId] = result;
                        callback($.yunmayi.city.cache.city[provId]);
                    }
                });
            }
        },
        // 获取县区信息列表
        getAreaList: function(cityId, callback) {
            if ($.yunmayi.city.cache.area[cityId] != undefined) {
                callback($.yunmayi.city.cache.area[cityId]);
            }
            else {
                $.ajax({
                    type: "POST",
                    url: $.yunmayi.city.url.area,
                    dataType: "jsonp",
                    data: {
                        city_id: cityId
                    },
                    success: function(result){
                        $.yunmayi.city.cache.area[cityId] = result;
                        callback($.yunmayi.city.cache.area[cityId]);

                    }
                });
            }
        },
        // 获取当前选中的省份信息
        getCurProvInfo: function(){
            var provId = parseInt(this.elements.phidden.val());
            var provName = this.elements.phidden.data("name");

            return {
                "provId": provId,
                "provName": provName
            };
        }
    });

    $.yunmayi.city.index = 0;

    $.yunmayi.city.cache = {
        prov: null,
        city: {},
        area: {}
    };

    $.yunmayi.city.url = {
        prov: "http://"+DOMAIN.ajax+"/city/getProvList",
        city: "http://"+DOMAIN.ajax+"/city/getCityListByProvId",
        area: "http://"+DOMAIN.ajax+"/city/getAreaListByCityId"
    };

    // load css file
    var script_file_info = $.help.lastScriptFileInfo();
    var css_filename = script_file_info.filename.replace(".js", ".css");
    var css_file = script_file_info.path + css_filename;
    $.help.loadCss(css_file);

})(jQuery);