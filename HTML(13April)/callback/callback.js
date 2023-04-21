const students = [
    { name: "Deepak", subject: "Maths" },
    { name: "Sahil", subject: "English" }

]

function EntrollStudent(student, GetStudents)
{
 
     setTimeout(()=>
     {
        students.push(student);
      GetStudents();

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
  
    
    }, 1000)
}


EntrollStudent({name:"Gagan", subject:"Eng"}, GetStudents);
// GetStudents();
