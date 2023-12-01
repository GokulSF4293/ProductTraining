var title 
var content
$(document).ready(function () {
    title = document.getElementById("title");
    content = document.getElementById("content");
    $("#box1").click(function(){
        $("#title1").empty()
        $("#para1").empty()
        $("#title1").append(title.value)
        $("#para1").append(content.value)
    })
    $("#box2").click(function(){
        $("#title2").empty()
        $("#para2").empty()
        $("#title2").append(title.value)
        $("#para2").append(content.value)
    })
    $("#box3").click(function(){
        $("#title3").empty()
        $("#para3").empty()
        $("#title3").append(title.value)
        $("#para3").append(content.value)
    })
});