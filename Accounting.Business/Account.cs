using Accounting.DataLayer.Context;
using Accounting.ViewModels.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Business
{
    public class Account
    {
        public static AccountingViewModel ReportForm()
        {
            AccountingViewModel view = new AccountingViewModel();

            DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
            DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 31);

            using (UnitOfWork db = new UnitOfWork())
            {
                var incomes = db.AccountingRepository.Get(a => a.TypeID == 1 && a.DateTime >= startDate && a.DateTime <= endDate).Select(a => a.Amount);
                var expenses= db.AccountingRepository.Get(a => a.TypeID == 2 && a.DateTime >= startDate && a.DateTime <= endDate).Select(a => a.Amount);
                

                view.Incomes = incomes.Sum();
                view.Expenses = expenses.Sum();
                view.Balance = incomes.Sum() - expenses.Sum();


            }
            return view;

        }


    }
}
