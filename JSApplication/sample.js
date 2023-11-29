var data;
var department;
var book;
var email;
var authorName;
var publish;
var price;
var temp = true;
function BookValidate() {
    store = document.getElementById("book");
    error = document.getElementById("bookError");
    check = /^[A-Za-z]+$/;
    if (store.value.trim() == "") {
        document.getElementById("bookError").innerHTML = "Book name required.";
        store.style.borderColor = "red";
        book = false;
    }
    else if (check.test(store.value) == false) {
        store.style.borderColor = "red";
        error.innerHTML = "Numeric values and special characters are not allowed.";
        book = false;
    }
    else if ((store.value).length > 50) {
        store.style.borderColor = "red";
        error.innerHTML = "Book name length should not checkceed 50.";
        book = false;
    }
    else {
        error.innerHTML = "";
        book = true;
    }
}
function NameValidate() {
    store = document.getElementById("name");
    error = document.getElementById("nameError");
    check = /^[A-Za-z]+$/;
    check1 = /^[a-zA-Z0-9]+$/;
    if (store.value.trim() == "") {
        document.getElementById("nameError").innerHTML = "Author name required.";
        store.style.borderColor = "red";
        authorName = false;
    }
    else if ((store.value).length > 50) {
        error.innerHTML = "Author name should not checkceed 50.";
        store.style.borderColor = "red";
        authorName = false;
    }
    else if (check.test(store.value) == false) {
        error.innerHTML = "Numeric values and special characters not allowed.";
        store.style.borderColor = "red";
        authorName = false;
    }
    else if (check1.test(store.value) == false) {
        error.innerHTML = "Special characters not allowed.";
        store.style.borderColor = "red";
        authorName = false;
    }
    else {
        error.innerHTML = "";
        authorName = true;
    }
}
function MailValidate() {
    store = document.getElementById("email");
    error = document.getElementById("mailError");
    check = /[`!@#$%^&*()_\-+=\[\]{};':"\\|,.<>\/?~]/;
    if (store.value.trim() == "") {
        document.getElementById("mailError").innerHTML = "Please enter mailID";
        store.style.borderColor = "red";
        email = false;
    }
    else if (check.test(store.value) == false) {
        error.innerHTML = "Please enter valid mail address";
        store.style.borderColor = "red";
        email = false;
    }
    else {
        error.innerHTML = "";
        email = true;
    }
}
function PublishValidate() {
    store = document.getElementById("published");
    error = document.getElementById("publishedError");
    check = /^[0-9]*$/;
    if (store.value.trim() == "") {
        document.getElementById("publishedError").innerHTML = "Please enter the published year.";
        store.style.borderColor = "red";
        publish = false;
    }
    else if (check.test(store.value) == false) {
        error.innerHTML = "Please enter the valid Published Error.";
        store.style.borderColor = "red";
        publish = false;
    }
    else {
        error.innerHTML = "";
        publish = true;
    }
}
function PriceValidate() {
    store = document.getElementById("price");
    error = document.getElementById("priceError");
    check = /^[0-9]*$/;
    if (store.value.trim() == "") {
        document.getElementById("priceError").innerHTML = "Please enter the price";
        store.style.borderColor = "red";
        price = false;
    }
    else if (check.test(store.value) == false) {
        error.innerHTML = "Please enter the published year.";
        store.style.borderColor = "red";
        price = false;
    }
    else {
        error.innerHTML = "";
        price = true;
    }
}
function GetValue() {
    department = document.getElementById("department");
    book = document.getElementById("book");
    email = document.getElementById("email");
    authorName = document.getElementById("name");
    publish = document.getElementById("published");
    price = document.getElementById("price");
    //if (department == true && book == true && authorName == true && email == true && publish == true && price == true) {
        data = {
            department: document.getElementById("department").value,
            book: document.getElementById("book").value,
            authorMail: document.getElementById("email").value,
            authorName: document.getElementById("name").value,
            published: document.getElementById("published").value,
            price: document.getElementById("price").value,
        }
        CreateOne(data);
    }
//}
function CreateOne(data) {
    localStorage.setItem("Data", JSON.stringify(data));
    alert("Details uploaded successfully");
}
function Cancel() {
    department = "IT"
    book = document.getElementById("book").innerHTML = "";
    email = document.getElementById("email").innerHTML = "";
    authorName = document.getElementById("name").innerHTML = "";
    publish = document.getElementById("published").innerHTML = "";
    price = document.getElementById("price").innerHTML = "";
    alert("Details cleared successfully.");
}

function Show() {
    var Data = JSON.parse(localStorage.getItem("Data"));
    document.getElementById("bookHeading").innerHTML = Data.book;
    document.getElementById("showDept").innerHTML = Data.department;
    document.getElementById("showBook").innerHTML = Data.book;
    document.getElementById("showMail").innerHTML = Data.authorMail;
    document.getElementById("showName").innerHTML = Data.authorName;
    document.getElementById("showPublish").innerHTML = Data.published;
    document.getElementById("showPrice").innerHTML = Data.price;
}
