using ChainOfResponsibility.Model;

namespace ChainOfResponsibility
{
    public class ChainOfResponsibilityMainTest
    {
        public static void Main()
        {
            Approver teamLead = new TeamLead();
            Approver vicePresident = new VicePresident();
            Approver president = new President();

            teamLead.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);

            Purchase purchase = new Purchase(2019, 90000.00);
            teamLead.ProcessRequest(purchase);
        }
    }
}