﻿
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Library_Domain.Model;

namespace Cartax.Presentation.Base
{
    public class BaseDataConfiguertions<T> : IEntityTypeConfiguration<T> where T : class
    {

        protected  IEnumerable<T> Data;

        public void Configure(EntityTypeBuilder<T> builder)
        {

            SeedData(builder);
        }

        private void SeedData(EntityTypeBuilder<T> builder)
        {


            IEnumerable<T> values = DataDefultConfig<T>();

            if (DataExists(builder)==false)
            {

                builder.HasData(values);

            }
        }
        
        private  IEnumerable<T> DataDefultConfig<T>()
        {
            return (IEnumerable<T>)Data;
        }

        private bool DataExists(EntityTypeBuilder<T> builder)
        {
            // بررسی وجود داده در جدول
            return builder.Metadata.GetSeedData().Any();
        }

       

    }
}
