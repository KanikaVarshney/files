const students = [
    { name: "Deepak", subject: "Maths" },
    { name: "Sahil", subject: "English" }

]

function func1()
{
  return new Promise(function (resolve, reject)
  {
     
     setTimeout(()=>
     {
   const error = false;
   EntrollStudent({name:"Gagan", subject:"Eng"});
   if(!error)
    resolve("Rec has been inserted")
    else
    reject("error");
     }, 3000)
})
}

function EntrollStudent(student, GetStudents)
{
 
     setTimeout(()=>
     {
        students.push(student);
    //   GetStudents();

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
  
    
    }, 2000)
}


   func1().then((msg)=>
   {
    console.log(msg)
    GetStudents();
   }).catch((error)=>
   {
     console.log(error)
   })

