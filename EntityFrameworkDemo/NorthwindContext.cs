using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDemo
{
    public class NorthwindContext:DbContext
    {
        //virtual -> yazan methodu inherit eden kişi o methodu değiştirebilir
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=master ;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
    }

    //public class A
    //{
    //    public virtual void Do(){ /*..*/}

    //}

    //public class B : A
    //{
    //    public override void Do()
    //    {
    //        base.Do();
    //    }
    //}
}