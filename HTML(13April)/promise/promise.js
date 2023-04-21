console.log("Promise")

// Producing Code
function func1()
{
    return new Promise(function(resolve, rejected)
    {
        setTimeout(()=>
        {
            const error=true;
            if(!error)
            resolve("Promise has been fulfilled");
            else 
            rejected("Primise has not been fulfilled")

        }, 2000);
        
    })
}

// Consuming Code
func1().then((response)=>
{
    console.log(response)
    console.log("Resolved");
}).catch((error)=>
{
    console.log(error)
  console.log("Cancelled");
}).finally()
{

};