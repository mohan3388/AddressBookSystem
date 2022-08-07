namespace AddressBookProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Details");
            AddressBook addressBook = new AddressBook();
            addressBook.Address();
            addressBook.Display();



        }
    }
}