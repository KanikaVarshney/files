async function GetRecords(){
    console.log("get records")
    var response= await fetch("http://localhost:3000/posts");
    var data= await response.json();
    return data;
}

GetRecords().then(res=>console.log(res));
console.log("kanika")
console.log("Varshney")


async function PostRecords(){
    console.log("post method")
     var response=await fetch("http://localhost:3000/posts",
     { method: 'POST', 
     body: JSON.stringify({ title: 'foo',
     body: 'bar',
       }), 
      headers: { "Content-type": "application/json" 
    } });
     var data= await response.json();
     return data;
}
PostRecords().then(res=>console.log(res));



async function DeleteRecords(){
    console.log("delete method")
     var response=await fetch("http://localhost:3000/posts/2",
     { method: 'DELETE'})
     var data= await response.json();
     return data;
}
DeleteRecords().then(res=>console.log(res));


async function PutRecords(){
    console.log("put method")
     var response=await fetch("http://localhost:3000/posts/4",
     { method: 'PUT', body: JSON.stringify({ title: 'kanika',
     body: 'varshney',
    }), 
    headers: { "Content-type": "application/json" }})
     var data= await response.json();
     return data;
}
PutRecords().then(res=>console.log(res));








