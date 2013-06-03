using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Data.EntityClient;
using LBModel;
using System.Data.Entity;
using System.Data.EntityModel;




namespace LBConsoleTestApp
{
    class Program
    {
        public static void Main()
        {
            LBTestApp();
        }
        private static void LBTestApp()
        {
            //string bankName = null;
            Console.WriteLine("Press enter to see all banks.");
            Console.ReadLine();
      
            
            //initialize new context
            var context = new LBModel.LBEntities();
            var query = from b in context.Banks  select b;
            foreach (Bank comp in query)
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8}",
                    comp.BankID, comp.BankName, comp.BankDesc, comp.RoutingNumber, comp.IsOpen, comp.CreateDate, comp.CreatedBy, comp.UpdateDate, comp.UpdatedBy);
            Console.WriteLine("");

            
            //lambda for getting creating object where bankid = 1.  Good for short, small queries and updates
            //var bank = context.Banks.Where(b => b.BankID == 1);
            //var bank1 = context.Banks;
            //Console.WriteLine(bank1.OrderBy(b => b.BankID).FirstOrDefault().BankName);

            Console.WriteLine("Please enter the ID of the bank you wish to view.");

            int myBankID;
            
           
            bool i = false;
            while (i == false )
            {


                try
                {

                    myBankID = Convert.ToInt32(Console.ReadLine());
                    var bankIChoose = context.Banks.Find(myBankID);
                    Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8}", bankIChoose.BankID, bankIChoose.BankName, bankIChoose.BankDesc, bankIChoose.RoutingNumber,
                                        bankIChoose.IsOpen, bankIChoose.CreateDate, bankIChoose.CreatedBy, bankIChoose.UpdateDate, bankIChoose.UpdatedBy);
                    i = true;
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine("That bankID does not exist.  Please enter a new bankID.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input.  Please enter a new bankID.");
                }
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Press Enter To Close");
            Console.ReadLine();
            /*
             * this is working...I can use code like this to insert records using an insert method.
             string newBankName = "North Looney Bank";
             string newBankDesc = "blreaf";    
             int newBankRoute = 654321;
             bool newBankOpen = true;
            
           context.spLOONEYBANK_Bank_Insert(newBankName, newBankDesc, newBankOpen, newBankRoute);
            */

            
        }
    }
}
