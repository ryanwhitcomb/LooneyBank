using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LBModel;
using System.Data.Entity;
using System.Data.Objects;
using System.Data.EntityClient;
using System.Data.EntityModel;
using System.Collections;


namespace LooneyBank.Core 
{
    public class Bank
    {
        public int BankID { get; private set; }
        public string bankName { get; set; }
        public string bankDescription { get; set; }
        public int routingNumber { get; set; }
        public bool isOpen { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime updateDate { get; set; }
        public string updatedBy { get; set; }

        public Bank(int BankID)
        {
            var context = new LBModel.LBEntities();
            var thisBank = context.Banks.Find(BankID);

            this.BankID = thisBank.BankID;
            this.bankName = thisBank.BankName;
            this.bankDescription = thisBank.BankDesc;
            this.routingNumber = thisBank.RoutingNumber;
            this.isOpen = thisBank.IsOpen;
            this.createDate = thisBank.CreateDate;
            this.createdBy = thisBank.CreatedBy;
            this.updateDate = Convert.ToDateTime(thisBank.UpdateDate);
            this.updatedBy = thisBank.UpdatedBy;
        }
        
        public Bank(string name, string bankDesc, int routeNum)
        {
            this.bankName = name;
            this.bankDescription = bankDesc;
            this.routingNumber = routeNum;
            this.isOpen = true;
            this.createDate = DateTime.Now;
            this.createdBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        public static void InsertNewBank(LooneyBank.Core.Bank bank, LBModel.LBEntities currentContext)
        {
            currentContext.spLOONEYBANK_Bank_Insert(bank.bankName, bank.bankDescription, bank.isOpen, bank.routingNumber);
        }

        public static void SaveBank(LooneyBank.Core.Bank bank, LBModel.LBEntities currentContext)
        {
            //add code to update bank object's information in the currentContext.
        }



    }
}
