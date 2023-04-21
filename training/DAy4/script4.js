console.log("Cll back functions")

// console.log("Start")
// console.log("In bet")
// console.log("End")

// console.log("STart");
// setTimeout(   ()=>
// {
//     console.log("In bet")
// }, 1000);
// console.log("End")

 console.log("STart");

  function GetName(name, callback)
 {
     setTimeout(()=>
     {
        console.log("INside GetNAme");
       
        callback(name);
     }, 2000);
     
 }


 GetName("AJay", (name)=>
 {
    console.log(name);
 });
// console.log(name);
console.log("End");

 