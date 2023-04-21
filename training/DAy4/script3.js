var btnGet = document.getElementById("btnGet");
btnGet.addEventListener('click', Get);

var btnInsert = document.getElementById("btnInsert");
btnInsert.addEventListener('click', Insert);
console.log("Ajax Calls")

var xhr = new XMLHttpRequest();
 
function Insert()
{
    xhr.open("POST", "http://localhost:3000/posts", false);
    xhr.setRequestHeader("Content-type", "application/json");
    params = {
        "title": "post1",
        "author": "Consultant"
};

 
    xhr.onload = function  ()
{
     console.log(xhr.responseText);
    document.getElementById("div1").innerHTML = xhr.responseText;
}
console.log(params);
     // Send the Request
     xhr.send(JSON.stringify(params));     

}
 function Get()
 {
xhr.open("get", "http://localhost:3000/posts")

xhr.send(null);

 xhr.onload = function  ()
{
    alert("a");
    console.log(xhr.responseText);
    document.getElementById("div1").innerHTML = xhr.responseText;
}
 }

// Delete();
 function Delete()
 {
xhr.open("delete", "http://localhost:3000/posts/2")

xhr.send(null);

 xhr.onload = function  ()
{
    alert("a");
    console.log(xhr.responseText);
    document.getElementById("div1").innerHTML = xhr.responseText;
}
 }