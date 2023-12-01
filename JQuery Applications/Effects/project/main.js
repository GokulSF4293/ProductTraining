var msg1 = document.getElementById("para1");
var msg2 = document.getElementById("para2");
var msg3 = document.getElementById("para3");
$(document).ready(function(){
    $(".button1").click(function(){ 
        $("#container2").fadeOut(3000);
        $(".card").css("background-color","black");
    })
    $(".button2").click(function(){
        document.getElementById("para1").innerHTML = "Peafowl is a common name for two bird species in the genera Pavo and Afropavo within the tribe Pavonini of the family Phasianidae . All species of peafowl are believed to be polygamous.";
        document.getElementById("para2").innerHTML = "The lion (Panthera leo) is a large cat of the genus Panthera native to Africa and India. It has a muscular, broad-chested body; short, rounded head; round ears; and a hairy tuft at the end of its tail.";
        document.getElementById("para3").innerHTML = "The tiger (Panthera tigris) is the largest living cat species and a member of the genus Panthera. It is most recognisable for its dark vertical stripes on orange fur with a white underside.";
    })
    $(".button3").click(function(){
        document.getElementById("para2").innerHTML = "Peafowl is a common name for two bird species in the genera Pavo and Afropavo within the tribe Pavonini of the family Phasianidae . All species of peafowl are believed to be polygamous.";
        document.getElementById("para3").innerHTML = "The lion (Panthera leo) is a large cat of the genus Panthera native to Africa and India. It has a muscular, broad-chested body; short, rounded head; round ears; and a hairy tuft at the end of its tail.";
        document.getElementById("para1").innerHTML = "The tiger (Panthera tigris) is the largest living cat species and a member of the genus Panthera. It is most recognisable for its dark vertical stripes on orange fur with a white underside.";
    })
})