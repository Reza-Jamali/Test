﻿using Cartax.Applications.Persistence.Repositories;
using Cartax.Domain.Entites.Tax.TaxLongTerms;
using Cartax.Domain.Entites.Tax.TaxPublicholidays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Interfaces
{
    public interface ITaxPublicholidayRepository : IAsyncRepository<TaxPublicholiday>
    {

    }
}
