var a = 10
var b = 20


add = (a,b)=>
 {
    console.log(a)
    console.error("There is an eror")
    console.warn("This is a warning")
    console.assert(a<16 , "VALUE OF A CANNOT BE LES TAN 6")
    var res = a+b;
    return res;
 }
 
 subtract = (a,b)=>
 {
    var res = a-b;
    return res;
 }

 
debugger;
 console.log(add(a,b));
 console.log(subtract(a,b));