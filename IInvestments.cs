using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp_test_task
{
     public interface IInvestments
    {
        List<PaymentHistory> GetTheAmountOfInterestFromTheInvestment(DateTime agreementDate, 
            double investmentAmount, double interestRate,int investmentDuration);
    }
}
