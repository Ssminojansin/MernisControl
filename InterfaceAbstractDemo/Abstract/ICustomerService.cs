﻿using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    //Interface 
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
