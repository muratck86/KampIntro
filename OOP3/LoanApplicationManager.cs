using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class LoanApplicationManager
    {
        public void Apply(ILoanManager loanManager, ILoggerService loggerService)
        {
            //Some Code...
            loanManager.Calculate();
            loggerService.Log();

        }

        public void LoanPreCalculation(List<ILoanManager> loanManagers)
        {
            foreach(ILoanManager loan in loanManagers)
            {
                loan.Calculate();
            }
        }
    }
}
