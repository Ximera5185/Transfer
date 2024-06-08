using System;

namespace Transfer
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Database database = new Database();

            database.ShowAllFighters();
            

            database.TransferFighters();


            database.ShowAllFighters();
           

            Console.ReadKey();
        }
    }
}