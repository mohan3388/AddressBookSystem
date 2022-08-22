namespace AddressBookProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
           

            
           AddressBook addressBook = new AddressBook();
            Console.WriteLine("Please Enter the Information");
            bool check = true;
            Console.WriteLine("1.Display\n2.Edit\n3.Delete\n4.Add Multiple person\n");

            while (check)
            {
                Console.WriteLine("Enter The Above option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("To Display ");
                        addressBook.Display();
                        break;
                   

                    case 2:
                        Console.WriteLine("Enter the first name to edit");
                       
                        addressBook.Update();
                        break;
                    case 3:
                        Console.WriteLine("Delete Item");
                        addressBook.Delete();
                        break;
                    case 4:
                        Console.WriteLine("Add multiple contact");
                        addressBook.Delete();
                        break;
                      case 5:
                         Console.WriteLine("Unique name");
                        addressBook.Adduniquecontacts();
                        break;
                       
                    case 6:
                      Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();
                        addressBook.NameExists(name);
                        break;  
                    case 0:
                        check = false; break;
                }

            }

        }
    }
}
