// JavaScript Document
var menucode = "\
<ul class='nav'>\
<li><a href='#' target='_self'>天然氣業者基本資料</a>\
<ul class='navSa'>\
<li><a href='gas-firmA001.html' target='_self'>事業單位基本資料表</a></li>\
<li><a href='gas-firmA002.html' target='_self'>用戶管線定期檢查計畫及檢查結果</a></li>\
<li><a href='gas-firmA003.html' target='_self'>轄區管線示意圖</a></li>\
<li><a href='gas-firmA004.html' target='_self'>場站管線流程圖(PFD)</a></li>\
<li><a href='gas-firmA005.html' target='_self'>場站概況分佈圖</a></li>\
</ul>\
</li>\
<!--<li><a href='gas-firmA101.html' target='_self'>二、天然氣儲槽設施資料</a></li>-->\
\
<li><a href='#' target='_self'>管線管理</a>\
<ul class='navSb'>\
<li><a href='gas-firmA201.html' target='_self'>管線基本資料</a></li>\
<!--<li><a href='gas-firmA202.html' target='_self'>(二)、管線路徑環境特質</a></li>-->\
<li><a href='gas-firmA203.html' target='_self'>管線完整性管理作為</a></li>\
<li><a href='gas-firmA204.html' target='_self'>智慧型通管器檢查(ILI)</a></li>\
<!--<li><a href='gas-firmA205.html' target='_self'>(五)、緊密電位檢測(CIPS)</a></li>-->\
<!--<li><a href='gas-firmA206.html' target='_self'>(六)、異常整流站</a></li>-->\
<li><a href='gas-firmA207.html' target='_self'>管線巡檢\t</a></li>\
<li><a href='gas-firmA208.html' target='_self'>管線維修或開挖</a></li>\
<li><a href='gas-firmA209.html' target='_blank'>風險評估</a></li>\
<li><a href='gas-firmA210.html' target='_self'>內部稽核</a></li>\
</ul>\
</li>\
<!--<li><a href='gas-firmA301.html' target='_self'>四、控制室</a></li>-->\
<li><a href='gas-firmA401.html' target='_self'>事故學習</a></li>\
<li><a href='gas-firmA-checkform.html' target='_blank'>查核項目自評</a></li>\
<li><a href='#' target='_self'>查核簡報上傳</a></li>\
</ul>\
";

//將選單程式引入HTML
$("#navmenuV").html(menucode);
//插入中文編碼
var serarrA = ["一、","二、","三、","四、","五、","六、","七、","八、","九、","十、","十一、","十二、"];
var serarrB = ["(一)、","(二)、","(三)、","(四)、","(五)、","(六)、","(七)、","(八)、","(九)、","(十)、","(十一)、","(十二)、"];
var serarrAnum = $("#navmenuV > ul >li").length;
var serarrSanum = $(".navSa >li").length;
var serarrSbnum = $(".navSb >li").length;
for(i=0;i<serarrAnum; i++){
    var j = i + 1;
    $("<span class='navsernum'>"+ serarrA[i] +"</span>").insertBefore("#navmenuV > ul >li:nth-child(" + j + ") > a");
}
for(i=0;i<serarrSanum; i++){
    var j = i + 1;
    $("<span class='navsernum'>"+ serarrB[i] +"</span>").insertBefore(".navSa >li:nth-child(" + j + ") > a");
}
for(i=0;i<serarrSbnum; i++){
    var j = i + 1;
    $("<span class='navsernum'>"+ serarrB[i] +"</span>").insertBefore(".navSb >li:nth-child(" + j + ") > a");
}


var filecode = "\
<div class=\"font-size4 font-normal\"><i class=\"fa fa-file-word-o IconCc\" aria-hidden=\"true\"></i><a href=\"doc/附件3、110年天然氣生產進口事業查核填寫內容.docx\" target=\"_blank\">查核填寫內容下載</a> <i class=\"fa fa-file-powerpoint-o IconCc\" aria-hidden=\"true\"></i><a href=\"doc/查核配合事項(天然氣).pptx\" target=\"_blank\">查核配合事項下載</a> <i class=\"fa fa-file-powerpoint-o IconCc\" aria-hidden=\"true\"></i><a href=\"doc/附件4、110年天然氣生產、進口事業輸儲設備查核簡報大綱.pptx\" target=\"_blank\">簡報大綱下載</a></div>\
";

//將選單程式引入HTML
$("#filedown").html(filecode);

	