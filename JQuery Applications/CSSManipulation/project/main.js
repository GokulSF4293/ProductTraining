$(document).ready(function () {
    $("#button2").click(function(){
        $("#title2").css({
            fontSize: "30px",
            color: "blue",
        })
        $("#para2").css({
            fontSize: "18px",
            color: "red",
        })
        $("#button2").css({
            borderColor: "red",
            backgroundColor: "black",
        })
    })
    $("#button3").click(function(){
        $("#title3").css({
            fontSize: "40px",
            color: "yellow",
        })
        $("#para3").css({
            fontSize: "25px",
            color: "green",
        })
        $("#button3").css({
            border: "5px solid black",
            color: "white",
            backgroundColor: "red",
        })
    })
});