// var btnGet = document.getElementById("btnGet");
// btnGet.addEventListener('click', Get);

// var btnInsert = document.getElementById("btnInsert");
// btnInsert.addEventListener('click', Insert);
console.log("Ajax Calls")

var xhr = new XMLHttpRequest();
 
function Insert()
{
    xhr.open("POST", "http://localhost:3000/posts", true);
    xhr.setRequestHeader('Content-Type', 'application/json');
    params = {
        "name": "Kanika Varshney",
        "job": "Intern"
};

    xhr.onload = function()
{
    alert("Hello");
    console.log(xhr.responseText);
    document.getElementById("div1").innerHTML = xhr.responseText;
}
     // Send the Request
    xhr.send(JSON.stringify(params));
            
}
 function Get()
 {
    xhr.open("get", " db.json")
   
    xhr.onload = function  ()
    {
       alert("a");
       console.log(xhr.responseText);
       document.getElementById("div1").innerHTML = xhr.responseText;
    }
 }
 function Delete(){
xhr.open("delete","http://localhost:3000/posts/3")
xhr.send(null);
xhr.onload=function(){
    alert("selected record deleted");
    console.log(xhr.responseText);
    document.getElementById("div1").innerHTML=xhr.responseText;

}
 }
 function Update(){
    xhr.open("put", "http://localhost:3000/posts/2");
    xhr.setRequestHeader('Content-Type', 'application/json');
    params = {
        "id":2,
        "name": "Anurika Varshney",
        "job": "Baby"
};
    xhr.send(JSON.stringify(params));
    xhr.onload = function()
{
    alert("Updated Data");
    console.log(xhr.responseText);
    document.getElementById("div1").innerHTML = xhr.responseText;
}
     // Send the Request
    
            
}
 