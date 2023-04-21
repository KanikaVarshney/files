console.log("Fetch api through db.json")
var list="";
fetch('http://localhost:3000/posts')
.then(response=>response.json())
.then(json=>{console.log(json)
    list = json;
    // console.log(json.length)
PopulateList();}
)

fetch("http://localhost:3000/posts", 
 { method: 'POST', 
 body: JSON.stringify({ title: 'foo',
 autore: 'bar'}), 
  headers: { "Content-type": "application/json" 
} }) 
  .then(response => response.json()) 
  .then(json => {console.log(json)
// list = json;
  }
  )


  function PopulateList()
  {

    var str="";
    
    str+= "";

    // console.log("Len is " + list.length)
    // console.log(list[1].title);
    for(var i=0;i<list.length;i++)
  {

     str+= `<li> ${list[i].title} </li>`;
 }
 document.getElementById("aa").innerHTML = str;
}