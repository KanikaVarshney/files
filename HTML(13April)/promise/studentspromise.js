const students = [
    { name: "Deepak", subject: "Maths" },
    { name: "Sahil", subject: "English" }
]

function func1()
{
    return new Promise(function(resolve, reject)
    {
        const error=false;
        setTimeout(()=>
        {
            if(!error)
            {
                EnrollStudent({name:"Gagan", subject:"Eng"});
                resolve("STudent has been inserted");
            }
            else 
            reject("SOme error")
        },3000);

    })
}
function EnrollStudent(student, GetStudents)
{
 
     setTimeout(()=>
     {
        students.push(student);
  
     }, 2000)
}

function GetStudents()
{
         setTimeout(()=>
        {   
                 let str = "";
            students.forEach(function (student) {
                str += `<li>${student.name} </li>`
            });
            document.getElementById("list").innerHTML = str;
            console.log("Students are fetched");
            }
      , 2000)
    
}


// EnrollStudent({name:"Gagan", subject:"Eng"}, GetStudents);

func1().then((msg)=>
{   console.log(msg)
    GetStudents();

}).catch((error)=>
{
    console.log(error)
})
// GetStudents().then(() => {
//     console.log("Resolved");
// }).catch(() => {
//     console.log("rejected");
// }).finally(() => {

// })