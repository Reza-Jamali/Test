﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF
{
    public interface IUnitOfWork
    {
        public Task<int> Commit();
    }
}
