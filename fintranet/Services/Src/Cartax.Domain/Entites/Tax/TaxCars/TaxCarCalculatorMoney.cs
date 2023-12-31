﻿using Cartax.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Entites.Tax.TaxCars
{
    public class TaxCarCalculatorMoney : ValueObject
    {

        public TaxCarToday TaxCarToday { get; private set; }
        public decimal? LimaitTaxToday { get; private set; }
        public decimal? TaxNow { get; private set; }


        public TaxCarCalculatorMoney(TaxCarToday taxCarToday, decimal limaitTaxToday, decimal? taxNow)
        {
            TaxCarToday = taxCarToday;
            LimaitTaxToday = limaitTaxToday;
            TaxNow = taxNow;
        }

        public static TaxCarCalculatorMoney Create(TaxCarToday taxCarToday, decimal limaitTaxToday, decimal? taxNow)
        {
            return new TaxCarCalculatorMoney(taxCarToday, limaitTaxToday, taxNow);
        }


        public decimal? CalculatorMoney()
        {

            decimal? SumTax = 0;

            if (LimaitTaxToday == 0)
                return TaxNow;

            if(TaxCarToday.GetAll() is not null)
                SumTax = SumTaxTody();

            return Calculator(SumTax);

        }

        private decimal? Calculator(decimal? SumTax)
        {
            if ((SumTax + TaxNow) <= LimaitTaxToday)
                return ( TaxNow);


            decimal? overMoney = (SumTax + TaxNow) - LimaitTaxToday;

            return (TaxNow- overMoney); 
        }

        private bool OverFlowTax(decimal? SumTax)
        {
            decimal OverFlow = (decimal)(LimaitTaxToday - SumTax);

            return OverFlow >= 0;
        }

        private decimal? SumTaxTody()
        {

            decimal? sumtax = 0;

            foreach (var item in TaxCarToday.GetAll())
            {
                sumtax += item.Tax;
            }


            return sumtax;

        }

        public override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }


    }
}