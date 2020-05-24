using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp_test_task
{
    public class Investments : IInvestments
    {
        public List<PaymentHistory> GetTheAmountOfInterestFromTheInvestment(DateTime agreementDate,
            double investmentAmount, double interestRate, int investmentDuration)
        {
            // Interest rate per month
            double i = interestRate / 12;
            //Number of months in investment
            int n = investmentDuration * 12;
            // Payment ratio0
            double k = i * (Math.Pow(1 + i, n)) / (Math.Pow(1 + i, n)-1);
            // Monthly payment amount
            double a = k * investmentAmount;
            var paymentHistory = new List<PaymentHistory>();
            var investmentBalance = investmentAmount;
            for (int m = 1; m <= n; m++)
            {
                var precent = investmentBalance * i;
                var payout = a - precent;
                investmentBalance -= payout;
                paymentHistory.Add(new PaymentHistory {
                    Date = agreementDate.AddMonths(m),
                    Payout = payout,
                    Percent = precent
                });
            }
            return paymentHistory;
        }
    }
}
