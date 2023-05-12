// Step 1
//using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Xml.Linq;
// Parameterized Queries
SqlConnection connection = null;
SqlCommand command = null;
CreateDatabase();
byte ch;
char choice = 'y';
while (choice == 'y')
{
    Console.WriteLine("MAIN MENU");
    Console.WriteLine("1. Add Record");
    Console.WriteLine("2. Delete Record");
    Console.WriteLine("3. Edit Record");
    Console.WriteLine("4. List of Employees");
    Console.WriteLine("5. Search Employee by ID");
    Console.WriteLine("Enter your choice");
    ch = byte.Parse(Console.ReadLine());

    switch (ch)
    {
        case 1:
            {
                Console.WriteLine("Enter ID");
                //int age = byte.Parse(Console.ReadLine());
                int id = byte.Parse(Console.ReadLine());

                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter EmpType");
                // string address = Console.ReadLine();
                string emptype = Console.ReadLine();
                break;



                if (emptype == "payroll")
                {
                    Console.WriteLine("Enter joinig date");
                    int joiningDate = byte.Parse(Console.ReadLine());

                    Console.WriteLine("Enter experience");
                    int experience = byte.Parse(Console.ReadLine());

                    Console.WriteLine("Enter basic salary");
                    int basicSalary = byte.Parse(Console.ReadLine());

                    Console.WriteLine("Enter DA");
                    int DA = byte.Parse(Console.ReadLine());

                    Console.WriteLine("Enter HRA");
                    int HRA = byte.Parse(Console.ReadLine());


                    AddEmployee(id: id, name: name, emptype: emptype);
                    Addpayroll(joiningDate: joiningDate, experience: experience, basicSalary: basicSalary, DA: DA, HRA: HRA);
                    break;

                }
                else if (emptype == "oncontract")
                {
                    Console.WriteLine("Enter Contract date");
                    int contractDate = byte.Parse(Console.ReadLine());

                    Console.WriteLine("Enter duration");
                    int duration = byte.Parse(Console.ReadLine());

                    Console.WriteLine("Enter charges");
                    int charges = byte.Parse(Console.ReadLine());



                    AddEmployee(id: id, name: name, emptype: emptype);
                    Addcontractroll(contractDate: contractDate, duration: duration, charges: charges);
                    break;

                }






            }
        case 2:
            {
                Console.WriteLine("Enter Id for which to delete record");
                int id = byte.Parse(Console.ReadLine());
                DeleteEmployee(id: id); break;
            }
        case 3:
            {
                Console.WriteLine("Enter Id for which to edit record");
                int id = byte.Parse(Console.ReadLine());
                Console.WriteLine("ENter new Address");
                string address = Console.ReadLine();
                Console.WriteLine("ENter new Dept");
                string dept = Console.ReadLine();
                EditEmployee(id, address, dept); break;
            }
        case 4: GetEmployees(); break;
        case 5:
            {
                Console.WriteLine("Enter Id for which to search record");
                int id = byte.Parse(Console.ReadLine());
                GetEmployeeById(id); break;
            }
        default: Console.WriteLine("Invalid choice"); break;
    }
    Console.WriteLine("Do ypu want to repeat");
    choice = Convert.ToChar(Console.ReadLine());

}

string GetConnectionString()
{
    return @"data source=DESKTOP-OSS9N8R\SQLEXPRESS;initial catalog=EmpDb1;integrated security=true";
}
SqlConnection GetConnection()
{
    return new SqlConnection(GetConnectionString());
}
void GetEmployees()
{
    // Step 2
    try
    {
        connection = GetConnection();
        command = new SqlCommand("Select * from Employee", connection);

        connection.Open();

        // Step 5
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i] + " ");
                }
                Console.WriteLine();
            }
        }
        else
        { Console.WriteLine("There are no records"); }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        connection.Close();
        command.Dispose();
        connection.Dispose();
    }
}

void AddEmployee(int id, string name, string emptype)
{

    try
    {
        connection = GetConnection();
        command = new SqlCommand();
        command.CommandText = "Insert into Employe  (id, name, emptype) values (@id, @name, @emptype)";
        command.Connection = connection;
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@name", name);
        command.Parameters.AddWithValue("@emptype", emptype);






        connection.Open();
        // ExecuteNonQuery() > performs DML insert/ delete / update
        // it returns no. of records affected

        int count = command.ExecuteNonQuery();
        if (count > 0)
        {
            Console.WriteLine("Record has been added");
        }
        else
            Console.WriteLine("Some Error came");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        connection.Close();
        command.Dispose();
        connection.Dispose();
    }
}



void Addpayroll(int joiningDate, int experience, int basicSalary, int DA, int HRA)
{

    try
    {
        connection = GetConnection();
        command = new SqlCommand();
        command.CommandText = "Insert into Employe  (joiningDate, experience, basicSalary,DA,HRA) values (@joiningDate, @experience, @basicSalary,@DA,@HRA)";
        command.Connection = connection;
        command.Parameters.AddWithValue("@JoiningDate", joiningDate);
        command.Parameters.AddWithValue("@experience", experience);
        command.Parameters.AddWithValue("@basicSalary", basicSalary);
        command.Parameters.AddWithValue("@DA", DA);
        command.Parameters.AddWithValue("@HRA", HRA);






        connection.Open();
        // ExecuteNonQuery() > performs DML insert/ delete / update
        // it returns no. of records affected

        int count = command.ExecuteNonQuery();
        if (count > 0)
        {
            Console.WriteLine("Record has been added");
        }
        else
            Console.WriteLine("Some Error came");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        connection.Close();
        command.Dispose();
        connection.Dispose();
    }
}




void Addcontractroll(int contractDate, int duration, int charges)
{

    try
    {
        connection = GetConnection();
        command = new SqlCommand();
        command.CommandText = "Insert into Employe  (contractDate, duration,charges) values (@contractDate, @duration,@charges)";
        command.Connection = connection;
        command.Parameters.AddWithValue("@contractDate", contractDate);
        command.Parameters.AddWithValue("@duration", duration);
        command.Parameters.AddWithValue("@charges", charges);







        connection.Open();
        // ExecuteNonQuery() > performs DML insert/ delete / update
        // it returns no. of records affected

        int count = command.ExecuteNonQuery();
        if (count > 0)
        {
            Console.WriteLine("Record has been added");
        }
        else
            Console.WriteLine("Some Error came");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        connection.Close();
        command.Dispose();
        connection.Dispose();
    }
}

void DeleteEmployee(int id)
{
    try
    {
        using (connection = GetConnection())
        {
            using (command = new SqlCommand("Delete Employee where id=@id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    Console.WriteLine("Record has been deleted");
                }
            }

        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        connection.Close();
    }
}

void CreateDatabase()
{
    try
    {
        using (connection = GetConnection())
        {
            using (command = new SqlCommand("Create Database FirstDb", connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
void EditEmployee(int id, string name, string emptype)



{
    using (connection = GetConnection())
    {
        int count;
        try
        {
            using (command = new SqlCommand("update Employee set address =@address, dept=@dept  where id=1", connection))

                command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@emptype", emptype);
            connection.Open();
            count = command.ExecuteNonQuery();

            if (count > 0)
            {
                Console.WriteLine("Record has been edited");
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }
}

void GetEmployeeById(int id)
{
    try
    {
        using (connection = GetConnection())
        {
            using (command = new SqlCommand("Select * from Employee where id=@id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + " ");
                    }
                }
                else
                { Console.WriteLine("There is no record with this ID"); }
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        connection.Close();
    }

}
