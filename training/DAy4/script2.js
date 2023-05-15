var btnGet = document.getElementById("btnGet");
btnGet.addEventListener('click', Get);

var btnInsert = document.getElementById("btnInsert");
btnInsert.addEventListener('click', Insert);
console.log("Ajax Calls")

var xhr = new XMLHttpRequest();
 
function Insert()
{
    xhr.open("POST", "https://reqres.in/api/users", true);
    xhr.getResponseHeader('Content-Type', 'application/json');
    params = {
        "name": "Anamika Sawhney",
        "job": "Consultant"
};

    xhr.onload = function  ()
{
    alert("a");
    console.log(xhr.responseText);
    document.getElementById("div1").innerHTML = xhr.responseText;
}
     // Send the Request
    xhr.send(params);

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