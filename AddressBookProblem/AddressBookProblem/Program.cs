namespace AddressBookProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
           

            
           AddressBook addressBook = new AddressBook();
            Console.WriteLine("Please Enter the Information");
            bool check = true;
            Console.WriteLine("1.Display \n 2.Edit \n");

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
                    case 0:
                        check = false; break;
                }

            }

        }
    }
}