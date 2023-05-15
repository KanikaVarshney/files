using EFassignment.models;

namespace EFassignment

{
    internal class Program
    {
        static void Main(string[] args)
        {
            InvDbContext db = new InvDbContext();

            int n;

            do
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Insert item");
                Console.WriteLine("2. Delete items");
                Console.WriteLine("3. Edit item");
                Console.WriteLine("4. Display item");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter Your Choise");
                int ch = Convert.ToInt32(Console.ReadLine());


                switch (ch)
                {

                    // insert record


                    case 1:

                        Console.WriteLine("enter 1 for supplier 2 for inventory");
                        int op = Convert.ToInt32(Console.ReadLine());

                        if (op == 1)
                        {
                            Console.WriteLine("Enter supplier name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter supplier address");
                            string details = Console.ReadLine();
                            Console.WriteLine("Enter supplier contact name");
                            string contname = Console.ReadLine();
                            Console.WriteLine("Enter supplier email");
                            string mail = Console.ReadLine();
                            Console.WriteLine("Enter city operated in");
                            string city = Console.ReadLine();


                            Supplier ss = new Supplier()
                            {       
                                SupplierName = name,
                                Address = details,
                                ContactNo = contname,
                                Email = mail,
                                CityOperatesIn = city

                            };
                            db.Sups.Add(ss);
                            db.SaveChanges();
                        }


                        else if (op == 2)
                        {
                            Console.WriteLine("Enter name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter details");
                            string details = Console.ReadLine();
                            Console.WriteLine("Enter Quantity");
                            int qtyInStock = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter last updated");
                            DateTime lastupdated = Convert.ToDateTime(Console.ReadLine());


                            Inventory batch = new Inventory()
                            {
                                Name = name,
                                Details = details,
                                QtyInStock = qtyInStock,
                                LastUpdated = lastupdated

                            };
                            db.Inventories.Add(batch);
                            db.SaveChanges();
                        }
                        break;



                    // Delete Record

                    case 2:

                        Console.WriteLine("enter 1 to delete Inventories and  2 to delete suppliers");
                        int op1 = Convert.ToInt32(Console.ReadLine());

                        if (op1 == 1)
                        {
                            Console.WriteLine("Enter the inventory name you want to delete");
                            Inventory p = db.Inventories.Where(x => x.Name == Console.ReadLine()).FirstOrDefault();
                            db.Inventories.Remove(p);
                            db.SaveChanges();
                        }
                        else if (op1 == 2)
                        {
                            Console.WriteLine("Enter the supplier name you want to delete");
                            Supplier p = db.Sups.Where(x => x.SupplierName == Console.ReadLine()).FirstOrDefault();
                            db.Sups.Remove(p);
                            db.SaveChanges();
                        }
                        break;



                    //edit
                    case 3:
                        Inventory bobj = db.Inventories.Where(x => x.Id == 2).FirstOrDefault();

                        if (bobj != null)
                        {
                            foreach (Inventory temp in db.Inventories)
                            {
                                if (temp.Id == bobj.Id)
                                {
                                    // temp.StartDate = Convert.ToDateTime(DateTime.Now);
                                    temp.Details = "its a new batch";
                                }


                            }
                            db.SaveChanges();
                        }
                        break;

                    










                    case 4:

                        List<Inventory> list = new List<Inventory>();
                        list = db.Inventories.ToList();
                        foreach (Inventory temp in list)
                        {
                            Console.WriteLine($"{temp.Id}  {temp.Name}  {temp.Details} {temp.QtyInStock} {temp.LastUpdated} ");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option selected.");
                        break;



                }
                Console.WriteLine("press 1 to continue");
                n = Convert.ToInt32(Console.ReadLine());

            }
            while (n == 1);
        }
    }
}