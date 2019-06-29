using eOrder.CORE.Models;
using Microsoft.EntityFrameworkCore;

namespace eOrder.DAL.EF
{
    public class EOrderDbContext : DbContext
    {
        public EOrderDbContext(DbContextOptions options) :
            base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<DeliveryPerson> DeliveryPersons { get; set; }
        public DbSet<DeliveryPersonOrder> DeliveryPersonOrders { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationImage> OrganizationImages { get; set; }
        public DbSet<OrganizationType> OrganizationTypes { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductRating> ProductRatings { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPaymentType> UserPaymentTypes { get; set; }
        public DbSet<UserRating> UserRatings { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<WorkingHour> WorkingHours { get; set; }
    }
}
