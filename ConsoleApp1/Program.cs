﻿using Accounting.DataLayer.Services;
using Accounting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            UnitOfWork db = new UnitOfWork();

            var list = db.CustomerRepository.GetAllRows();

            db.Dispose();

        }
    }
}
