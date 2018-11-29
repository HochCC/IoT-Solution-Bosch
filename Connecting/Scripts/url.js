/*  
JS 操作 URL 函数使用说明：

初始化 var myurl=new objURL(); //也可以自定义URL： var myurl=new objURL('http://www.111cn.net'); 

读取url参数值 var val=myurl.get('abc'); // 读取参数abc的值

设置url参数 myurl.set("arg",data); // 新增/修改 一个arg参数的值为data

移除url参数 myurl.remove("arg"); //移除arg参数

获取处理后的URL myurl.url();//一般就直接执行转跳 location.href=myurl.url();

调试接口：myurl.debug(); //修改该函数进行调试

 */

             function objURL(url) {

                  var ourl = url || window.location.href;

                  var href = "";//?前面部分

                  var params = {};//url参数对象

                  var jing = "";//#及后面部分

                  var init = function () {

                       var str = ourl;

                       var index = str.indexOf("#");

                       if (index > 0) {

                            jing = str.substr(index);

                            str = str.substring(0, index);

                       }

                       index = str.indexOf("?");

                       if (index > 0) {

                            href = str.substring(0, index);

                            str = str.substr(index + 1);

                            var parts = str.split("&");

                            for (var i = 0; i < parts.length; i++) {

                                 var kv = parts[i].split("=");

                                 params[kv[0]] = kv[1];

                            }

                       } else {

                            href = ourl;

                            params = {};

                       }

                  };

                  this.set = function (key, val) {

                       params[key] = encodeURIComponent(val);

                  };

                  this.remove = function (key) {

                       if (key in params) params[key] = undefined;

                  };

                  this.get = function (key) {

                       return params[key];

                  };

                  this.url = function (key) {

                       var strurl = href;

                     var objps = [];

                     for (var k in params) {

                         if (params[k]) {

                             objps.push(k + "=" + params[k]);

                         }

                     }

                     if (objps.length > 0) {

                         strurl += "?" + objps.join("&");

                     }

                     if (jing.length > 0) {

                         strurl += jing;

                     }

                     return strurl;

                  };

                  this.debug = function () {

                       // 以下调试代码自由设置

                       var objps = [];

                       for (var k in params) {

                            objps.push(k + "=" + params[k]);

                       }

                       alert(objps);//输出params的所有值

                  };

                  init();

             }