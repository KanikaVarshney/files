console.log("Ajax Calls")

var xhr = new XMLHttpRequest();
console.log(xhr.readyState);
// xhr.open("get", "text.txt");
// xhr.open("get", "emp.json");
xhr.open("get", "https://jsonplaceholder.typicode.com/posts")
xhr.onreadystatechange = handleRequestStateChange;
xhr.send(null);



function handleRequestStateChange()
{
    console.log("inside handleRequestStateChange " + xhr.readyState);
    if(xhr.readyState==4 && xhr.status==200)
    console.log(xhr.responseText);
    document.getElementById("div1").innerHTML = xhr.responseText;
}