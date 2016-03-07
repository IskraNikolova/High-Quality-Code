namespace ChainOfResponsibility.Model
{
    using System;

    public class TeamLead : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 1000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved request #{purchase.Number}");
            }
            else if(this.Successor != null)
            {
                this.Successor.ProcessRequest(purchase);
            }
        }
    }
}
