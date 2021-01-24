using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager personalLoanManager = new PersonalLoanManager();

            ILoanManager vehicleLoanManager = new VehicleLoanManager();

            ILoanManager mortgageManager = new MortgageManager();

            LoanApplicationManager loanApplicationManager = new LoanApplicationManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            loanApplicationManager.Apply(vehicleLoanManager, databaseLoggerService);

            List<ILoanManager> loans = new List<ILoanManager>() {mortgageManager, vehicleLoanManager};
            //loanApplicationManager.LoanPreCalculation(loans);
        }
    }
}
