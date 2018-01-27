using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Ordering.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Created { get; set; }
        public virtual ICollection<Adress> Adressy { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
    public class Adress
    {
        public int  AdressId { get; set; }
        public string Street { get; set; }
        public int City { get; set; }
        public virtual ICollection<Customer> Clients { get; set; }
    }
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public decimal TotaLOrder { get; set; }
        //foreign key
        public   Customer CustomerId { get; set; }
        public Adress AdressID { get; set; }

        public virtual Customer Client {get; set;}
        public virtual Adress ShipToAdress { get; set; }

    }
    public class OrderingContext : DbContext
    {
        public DbSet<Customer> Clients;
        public DbSet<Adress> Adresses;
        public DbSet<Order> Orders;

    }
}
