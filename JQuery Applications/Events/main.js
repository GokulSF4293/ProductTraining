$(document).ready(function(){
    $("form").submit(function(){
      alert($("input[name='message']").val());
      return false;
    });
});
