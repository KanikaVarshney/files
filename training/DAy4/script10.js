  async function func1()
{
       return await "A";
     
}

// console.log(func1().then(res=> console.log(res)));
// console.log("B")
// console.log("C")

async function Get()
{
var res = await fetch("https://jsonplaceholder.typicode.com/posts/1");
var data =await res.json();
return data;
}
console.log("A")

 Get().then(res=> console.log(res));

 console.log("B")