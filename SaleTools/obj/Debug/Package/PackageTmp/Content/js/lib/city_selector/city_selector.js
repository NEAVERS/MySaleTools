(function($){

    // ajax url
    var p_ajax_url = "http://"+DOMAIN.ajax+"/city/getProvList";
    var c_ajax_url = "http://"+DOMAIN.ajax+"/city/getCityListByProvId";
    var a_ajax_url = "http://"+DOMAIN.ajax+"/city/getAreaListByCityId";

    // cache
    var prov_cache = null;
    var city_cache = {};
    var area_cache = {};

    $.fn.CitySelector = function(options){
        // 配置参数
        $.extend($.fn.CitySelector.configs, options);
        
        // 容器
        $.fn.CitySelector.container = this;

        // 模式
        $.fn.CitySelector.multMode = this.length > 1 ? true : false;

        // 初始化
        $.fn.CitySelector.initialize();
    }

    $.extend($.fn.CitySelector, {
        /**
         * 容器
         */
        container: null,
        /**
         * 多模式
         */
        multMode: false,
        /**
         * 默认配置
         */
        configs: {
            editable: true, // 是否可编辑
            welcome_tip: "请选择省市区", // 提示语
            afterProvSelect: function(prov_id){},
            afterCitySelect: function(city_id){},
            afterAreaSelect: function(area_id){}
        },
        /**
         * 初始化
         */
        initialize: function() {
            // 创建元素
            this.createElements();
            if (this.configs.editable) {
                // 绑定事件
                this.bindEvents();
            }

            // 创建模板
            this.template();

            // 省市区初始化
            this.cityInit();
        },
        /**
         * 创建元素
         */
        createElements: function(){
            var that = this;

            $(this.container).each(function(index){
                var pid = parseInt($(this).data("pid"));
                var cid = parseInt($(this).data("cid"));
                var aid = parseInt($(this).data("aid"));

                pid = isNaN(pid) ? 0 : pid;
                cid = isNaN(cid) ? 0 : cid;
                aid = isNaN(aid) ? 0 : aid;

                that.elements[index] = {};

                that.elements[index].header = $("<div>", {"class": "wgt_city_select_hd"});
                that.elements[index].title = $("<div>", {"class": "wgt_city_title", "text": that.configs.welcome_tip});
                that.elements[index].icon = $("<i>", {"class": "iconfont", "html": "&#xe607;"});

                that.elements[index].body = $("<div>", {"class": "wgt_city_select_bd"});
                that.elements[index].tabs = $("<div>", {"class": "wgt_city_select_tabs"});
                that.elements[index].ptab = $("<a>", {"class": "wgt_city_select_tab cur", "href": "javascript:;", "text": "省份"});
                that.elements[index].ctab = $("<a>", {"class": "wgt_city_select_tab", "href": "javascript:;", "text": "城市"});
                that.elements[index].atab = $("<a>", {"class": "wgt_city_select_tab", "href": "javascript:;", "text": "区县"});
                that.elements[index].contents = $("<div>", {"class": "wgt_city_select_contents"});
                that.elements[index].pcontent = $("<div>", {"class": "wgt_city_select_content wgt_city_select_content_show"});
                that.elements[index].ccontent = $("<div>", {"class": "wgt_city_select_content"});
                that.elements[index].acontent = $("<div>", {"class": "wgt_city_select_content"});
                that.elements[index].pdl = $("<dl>");
                that.elements[index].pdd = $("<dd>", {"class": "clearfix"});
                that.elements[index].cdl = $("<dl>");
                that.elements[index].cdd = $("<dd>", {"class": "clearfix"});
                that.elements[index].adl = $("<dl>");
                that.elements[index].add = $("<dd>", {"class": "clearfix"});

                if (that.multMode) {
                    that.elements[index].phidden = $("<input>", {"type": "hidden", "name": "prov_id_"+index, "value": pid});
                    that.elements[index].chidden = $("<input>", {"type": "hidden", "name": "city_id_"+index, "value": cid});
                    that.elements[index].ahidden = $("<input>", {"type": "hidden", "name": "area_id_"+index, "value": aid});
                }
                else {
                    that.elements[index].phidden = $("<input>", {"type": "hidden", "name": "prov_id", "value": pid});
                    that.elements[index].chidden = $("<input>", {"type": "hidden", "name": "city_id", "value": cid});
                    that.elements[index].ahidden = $("<input>", {"type": "hidden", "name": "area_id", "value": aid});
                }
            });
        },
        /**
         * 事件绑定
         */
        bindEvents: function() {
            var that = this;

            $(this.container).each(function(index){
                var elements = that.elements[index];

                // 内容显示
                elements.header.on("click", function(){
                    elements.body.css({"display": "block"});
                });
                
                // tab切换
                elements.ptab.on("click", function(){
                    if ($(this).hasClass("cur")) {
                        return false;
                    }
                    that.tabShow(index, 1);
                });
                elements.ctab.on("click", function(){
                    if ($(this).hasClass("cur")) {
                        return false;
                    }
                    that.tabShow(index, 2);
                });
                elements.atab.on("click", function(){
                    if ($(this).hasClass("cur")) {
                        return false;
                    }
                    that.tabShow(index, 3);
                });

                // content dd a
                elements.pdd.on("click", "a", function(){
                    var _this = $(this);
                    if (!_this.hasClass("cur")) {
                        var pid = parseInt(_this.data("id"));
                        elements.cdd.html("");
                        elements.add.html("");
                        elements.chidden.val(0);
                        elements.chidden.data("name", "");
                        elements.ahidden.val(0);
                        elements.ahidden.data("name", "");

                        that.getCityList(pid, function(result){
                            var html_str = "";
                            for (var k in result) {
                                html_str += "<a href=\"javascript:;\" data-id=\""+result[k].number+"\">"+result[k].name+"</a>";
                            }

                            elements.cdd.html(html_str);
                            _this.addClass("cur");
                            _this.siblings("a").removeClass("cur");
                            elements.phidden.val(pid);
                            elements.phidden.data("name", _this.text());
                            that.tabShow(index, 2);
                            that.tipShow(index);

                            // callback
                            that.configs.afterProvSelect(pid);
                        });
                    }
                    return false;
                });
                elements.cdd.on("click", "a", function(){
                    var _this = $(this);
                    if (!_this.hasClass("cur")) {
                        var cid = parseInt(_this.data("id"));
                        elements.add.html("");
                        elements.ahidden.val(0);
                        elements.ahidden.data("name", "");

                        that.getAreaList(cid, function(result){
                            var html_str = "";
                            for (var k in result) {
                                html_str += "<a href=\"javascript:;\" data-id=\""+result[k].number+"\">"+result[k].name+"</a>";
                            }

                            elements.add.html(html_str);
                            _this.addClass("cur");
                            _this.siblings("a").removeClass("cur");
                            elements.chidden.val(cid);
                            elements.chidden.data("name", _this.text());
                            that.tabShow(index, 3);
                            that.tipShow(index);

                            // callback
                            that.configs.afterCitySelect(cid);
                        });
                    }
                    return false;
                });
                elements.add.on("click", "a", function(){
                    var _this = $(this);
                    var aid = parseInt(_this.data("id"));

                    _this.addClass("cur");
                    _this.siblings("a").removeClass("cur");
                    elements.ahidden.val(aid);
                    elements.ahidden.data("name", _this.text());

                    that.tipShow(index);

                    // callback
                    that.configs.afterAreaSelect(aid);
                });

            });

            // 隐藏
            $(document.body).on("click", function(e){
                var current_index = -1;
                var is_find = false;
                for (var key in that.elements) {
                    for (var k in that.elements[key]) {
                        if (that.elements[key][k][0] === e.target) {
                            current_index = parseInt(key);
                            is_find = true;
                            break;
                        }
                    }
                    if (is_find) {
                        break;
                    }
                }
                $(that.container).each(function(index){
                    if (index == current_index) {
                        return true;
                    }
                    that.elements[index].body.css({"display": "none"});
                });
            });
        },
        /**
         * 创建模板
         */
        template: function() {
            var that = this;

            $(this.container).each(function(index){
                $(this)
                    .append(
                        that.elements[index].header
                            .append(that.elements[index].title)
                            .append(that.elements[index].icon)
                    )
                    .append(
                        that.elements[index].body
                            .append(
                                that.elements[index].tabs
                                    .append(that.elements[index].ptab)
                                    .append(that.elements[index].ctab)
                                    .append(that.elements[index].atab)
                            )
                            .append(
                                that.elements[index].contents
                                    .append(
                                        that.elements[index].pcontent
                                            .append(
                                                that.elements[index].pdl.append(that.elements[index].pdd)
                                            )
                                    )
                                    .append(
                                        that.elements[index].ccontent
                                            .append(
                                                that.elements[index].cdl.append(that.elements[index].cdd)
                                            )
                                    )
                                    .append(
                                        that.elements[index].acontent
                                            .append(
                                                that.elements[index].adl.append(that.elements[index].add)
                                            )
                                    )
                            )
                    )
                    .append(that.elements[index].phidden)
                    .append(that.elements[index].chidden)
                    .append(that.elements[index].ahidden);
            });
        },
        /**
         * 节点元素
         */
        elements: {},
        /**
         * tab切换
         */
        tabShow: function(index, mode){
            var elements = this.elements[index];
            if (elements == undefined) {
                return false;
            }
            switch (mode) {
                case 1:
                    elements.ptab.addClass("cur");
                    elements.ctab.removeClass("cur");
                    elements.atab.removeClass("cur");
                    elements.pcontent.addClass("wgt_city_select_content_show");
                    elements.ccontent.removeClass("wgt_city_select_content_show");
                    elements.acontent.removeClass("wgt_city_select_content_show");
                    break;
                case 2:
                    elements.ptab.removeClass("cur");
                    elements.ctab.addClass("cur");
                    elements.atab.removeClass("cur");
                    elements.pcontent.removeClass("wgt_city_select_content_show");
                    elements.ccontent.addClass("wgt_city_select_content_show");
                    elements.acontent.removeClass("wgt_city_select_content_show");
                    break;
                case 3:
                    elements.ptab.removeClass("cur");
                    elements.ctab.removeClass("cur");
                    elements.atab.addClass("cur");
                    elements.pcontent.removeClass("wgt_city_select_content_show");
                    elements.ccontent.removeClass("wgt_city_select_content_show");
                    elements.acontent.addClass("wgt_city_select_content_show");
                    break;
            }
            return true;
        },
        /**
         * 显示提示
         */
        tipShow: function(index){
            var elements = this.elements[index];
            if (elements == undefined) {
                return false;
            }

            var tip = "";
            var pname = $.trim(elements.phidden.data("name"));
            var cname = $.trim(elements.chidden.data("name"));
            var aname = $.trim(elements.ahidden.data("name"));

            if (pname.length > 0) {
                tip += pname;
                if (cname.length > 0) {
                    tip += "<span style=\"color:#cccccc;\">&nbsp;/&nbsp;</span>" + cname;
                    if (aname.length > 0) {
                        tip += "<span style=\"color:#cccccc;\">&nbsp;/&nbsp;</span>" + aname;
                    }
                }

                elements.title.addClass("wgt_city_title_select").html(tip);
            }

            return true;
        },
        /**
         * 省市区初始化
         */
        cityInit: function() {
            var that = this;

            this.getProvList(function(result){
                $(that.container).each(function(index){
                    var elems = that.elements[index];
                    var pid = parseInt(elems.phidden.val());
                    var html = "";
                    var cur_class = "";

                    pid = isNaN(pid) ? 0 : pid;

                    for (var k in result) {
                        cur_class = "";
                        if (result[k].number == pid) {
                            cur_class = "class=\"cur\"";
                            elems.phidden.data("name", result[k].name);
                        }
                        html += "<a href=\"javascript:;\" "+cur_class+" data-id=\""+result[k].number+"\">"+result[k].name+"</a>";
                    }

                    elems.pdd.html(html);
                    that.tipShow(index);

                    if (pid > 0) {
                        // callback
                        that.configs.afterProvSelect(pid);

                        // 初始化城市信息
                        that.getCityList(pid, function(result){
                            var cid = parseInt(elems.chidden.val());
                            var html = "";
                            var cur_class = "";

                            cid = isNaN(cid) ? 0 : cid;

                            for (var k in result) {
                                cur_class = "";
                                if (result[k].number == cid) {
                                    cur_class = "class=\"cur\"";
                                    elems.chidden.data("name", result[k].name);
                                }
                                html += "<a href=\"javascript:;\" "+cur_class+" data-id=\""+result[k].number+"\">"+result[k].name+"</a>";
                            }

                            elems.cdd.html(html);
                            that.tipShow(index);
                            that.tabShow(index, 2);

                            if (cid > 0) {
                                // callback
                                that.configs.afterCitySelect(cid);

                                that.getAreaList(cid, function(result){
                                    var aid = parseInt(elems.ahidden.val());
                                    var html = "";
                                    var cur_class = "";

                                    aid = isNaN(aid) ? 0 : aid;

                                    for (var k in result) {
                                        cur_class = "";
                                        if (result[k].number == aid) {
                                            cur_class = "class=\"cur\"";
                                            elems.ahidden.data("name", result[k].name);
                                        }
                                        html += "<a href=\"javascript:;\" "+cur_class+" data-id=\""+result[k].number+"\">"+result[k].name+"</a>";
                                    }

                                    elems.add.html(html);
                                    that.tipShow(index);
                                    that.tabShow(index, 3);

                                    // callback
                                    that.configs.afterAreaSelect(aid);
                                });
                            }
                        });
                    }
                });
            });
        },
        /**
         * 获取省份信息列表
         */
        getProvList: function(callback){
            if (prov_cache != null) {
                callback(prov_cache);
            }
            else {
                $.ajax({
                    type: "post",
                    url: p_ajax_url,
                    dataType: "jsonp",
                    success: function(result){
                        prov_cache = result;
                        callback(result);
                    }
                });
            }
        },
        /**
         * 获取城市信息列表
         */
        getCityList: function(prov_id, callback){
            if (city_cache[prov_id] != undefined) {
                callback(city_cache[prov_id]);
            }
            else {
                $.ajax({
                    type: "post",
                    url: c_ajax_url,
                    dataType: "jsonp",
                    data: {
                        prov_id: prov_id
                    },
                    success: function(result){
                        city_cache[prov_id] = result;
                        callback(result);
                    }
                });
            }
        },
        /**
         * 获取县区信息列表
         */
        getAreaList: function(city_id, callback){
            if (area_cache[city_id] != undefined) {
                callback(area_cache[city_id]);
            }
            else {
                $.ajax({
                    type: "post",
                    url: a_ajax_url,
                    dataType: "jsonp",
                    data: {
                        city_id: city_id
                    },
                    success: function(result){
                        area_cache[city_id] = result;
                        callback(result);
                    }
                });
            }
        }

    });


    // load css file
    var script_file_info = $.help.lastScriptFileInfo();
    var css_filename = script_file_info.filename.replace(".js", ".css");
    var css_file = script_file_info.path + css_filename;
    $.help.loadCss(css_file);

})(jQuery);