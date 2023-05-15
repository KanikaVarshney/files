using System.Data.SqlClient;

namespace AdoDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "data source=DESKTOP-OSS9N8R\\SQLEXPRESS;initial catalog=EmpDb;integrated security=true";

            //SqlCommand command = new SqlCommand();
            //command.CommandText = "Select * from Employee";
            //command.Connection= connection;

         

            SqlCommand command = new SqlCommand("Select * from Employee", connection);

           
            connection.Open();

           
            SqlDataReader reader = command.ExecuteReader();

            //if(reader.HasRows)
            //{
            //    while(reader.Read())
            //    {
            //        Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2]);
            //    }
            //}
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

            connection.Close();
            AddEmployee();

        }
        static void AddEmployee()
        {
            SqlConnection connection = new SqlConnection("data source = ANAMIKA\\SQLSERVER; initial catalog = EmpDb; integrated security = true");

            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert into Employee values('Deepak','Delhi',38,'Accts')";
            command.Connection = connection;

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
            connection.Close();

        }

    }
}
