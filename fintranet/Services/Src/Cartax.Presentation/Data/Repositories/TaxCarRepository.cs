﻿using Cartax.Applications.Base;
using Cartax.Applications.Interfaces;
using Cartax.Domain.Entites.Areas;
using Cartax.Domain.Entites.Tax.TaxCars;
using Cartax.Presentation;
using Cartax.Presentation.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Persistence.Repositories
{
    public class TaxCarRepository : RepositoryBase<TaxCar>, ITaxCarRepository
    {
        private readonly CarTaxContext _dbContext;
        public TaxCarRepository(CarTaxContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TaxCar> GetTaxCarEndToday(int? idCar, int? idArea)
        {
            return await _dbContext.TaxCar.Where(a => a.Idcar == idCar && a.Idarea == idArea && a.CreateDate.Value.Date == DateTime.Today)
                 .OrderByDescending(a => a.CreateDate)
                .LastOrDefaultAsync();
        }
    }
}
