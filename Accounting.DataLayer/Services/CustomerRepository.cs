﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using System.Data.Entity;
using System.Net.Mime;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using Accounting.DataLayer;
using Accounting.ViewModels.Customers;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICusomerRepository
    {
        private Accounting_DBEntities db;
        public CustomerRepository(Accounting_DBEntities context)
        {
            db = context;
        }
        public bool DeleteCusomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void DeleteCusomer(int customerId)
        {
            DeleteCusomer(db.Customers.Find(customerId));
        }

        public List<Customers> GetAllRows()
        {
            return db.Customers.ToList();

        }

        public Customers GetCustomerById(int customerId)
        {
            return db.Customers.Find(customerId);
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustomer(Customers customer)
        {
            //try
            //{
            var local = db.Set<Customers>()
                     .Local
                     .FirstOrDefault(f => f.CustomerID == customer.CustomerID);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(customer).State = EntityState.Modified;
            return true;
            //}
            //catch
            //{
            //    return false;
            //}
        }


        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
            return db.Customers.Where(c => c.FullName.Contains(parameter) || c.Mobile.Contains(parameter)
                                                                          || c.Email.Contains(parameter)).ToList();
        }

        public List<ListCustomerViewModel> GetCustomersByName(string filter)
        {
            if (filter == "")
            {
                //var res= db.Customers.Select(c => c.FullName).ToList(); ;
                return db.Customers.Select(c => new ListCustomerViewModel()
                {
                    CustomerID = c.CustomerID,
                    FullName = c.FullName
                }).ToList();
            }

            return db.Customers.Where(c => c.FullName.ToLower().Contains(filter)).
                Select(c => new ListCustomerViewModel()
                {
                    CustomerID = c.CustomerID,
                    FullName = c.FullName
                }).ToList();
        }

        public int GetCustomerIdByName(string name)
        {
            return db.Customers.First(c => c.FullName == name).CustomerID;
        }

        public string GetCustomerNameById(int customerId)
        {
            return db.Customers.Find(customerId).FullName.ToString();
        }
    }
}
