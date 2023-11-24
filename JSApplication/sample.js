function GetValue() {
    var department = document.getElementById("department");
    var book = document.getElementById("book");
    var email = document.getElementById("email");
    var name = document.getElementById("name");
    var publish = document.getElementById("published");
    var price = document.getElementById("price");

    if (department.value.trim() == "" || book.value.trim() == "" || email.value.trim() == "" || name.value.trim() == "" || publish.value.trim() == "" || price.value.trim() == "") {
        alert("Values cannot be empty or spaces.Fill all the details");
        return false;
    }
    else {
        alert("Details uploaded successfully");
        return true;
    }
}

function Cancel() {
    var department = document.getElementById("department").innerHTML = "";
    var book = document.getElementById("book").innerHTML = "";
    var email = document.getElementById("email").innerHTML = "";
    var name = document.getElementById("name").innerHTML = "";
    var publish = document.getElementById("published").innerHTML = "";
    var price = document.getElementById("price").innerHTML = "";
}

function Show() {
    var department = document.getElementById("department").value;
    var book = document.getElementById("book").value;
    var email = document.getElementById("email").value;
    var name = document.getElementById("name").value;
    var publish = document.getElementById("published").value;
    var price = document.getElementById("price").value;
    document.writeln("Department : "+department+"<br/>");
    document.writeln("Book : "+book+"<br/>");
    document.writeln("Email : "+email+"<br/>");
    document.writeln("Published : "+publish+"<br/>");
    document.writeln("Name : "+name+"<br/>");
    document.writeln("Price : "+price+"<br/>");
}
