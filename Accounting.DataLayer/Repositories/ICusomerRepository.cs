﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Accounting.ViewModels.Customers;


namespace Accounting.DataLayer.Repositories
{
    public interface ICusomerRepository
    {
        List<Customers> GetAllRows();
        IEnumerable<Customers> GetCustomersByFilter(string parameter);
        List<ListCustomerViewModel> GetCustomersByName(string filter = "");
        Customers GetCustomerById(int customerId);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCusomer(Customers customer);
        void DeleteCusomer(int customerId);
        int GetCustomerIdByName(string name);
        string GetCustomerNameById(int customerId);
        
    }
}
