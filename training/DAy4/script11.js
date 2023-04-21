
// async function func1()
// {
//     console.log("Firstst")
//       return  await  "A";
//       console.log("Last")

// }

// // console.log(func1());
// func1().then(res=> console.log(res));
// console.log("B");
// console.log("C")
// console.log("B");
// console.log("C")


async function GetRecords()
{
    console.log("Inside")
 var response=  await fetch("https://jsonplaceholder.typicode.com/posts/1");
 var data = await response.json();
    return data;
}


GetRecords().then(res=> console.log(res));
console.log("A");
console.log("B")







