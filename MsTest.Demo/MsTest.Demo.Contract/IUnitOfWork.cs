﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTest.Demo.Contract
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
