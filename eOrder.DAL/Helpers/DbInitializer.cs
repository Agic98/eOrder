using eOrder.CORE.Constants;
using eOrder.CORE.Models;
using eOrder.DAL.EF;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Linq;

namespace eOrder.DAL.Helpers
{
    public class DbInitializer
    {
        public static void Seed(ServiceProvider serviceProvider)
        {
            var dbContext = serviceProvider.GetRequiredService<EOrderDbContext>();

            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            #region Countries
            dbContext.Countries.Add(new Country { Name = "Bosna i Hercegovina", Code = "BA" });
            dbContext.Countries.Add(new Country { Name = "Germany", Code = "GE" });
            dbContext.Countries.Add(new Country { Name = "United States Of America", Code = "USA" });

            dbContext.SaveChanges();
            #endregion

            #region Cities
            dbContext.Cities.Add(new City { Name = "Mostar", CountryId = 1 });
            dbContext.Cities.Add(new City { Name = "Frankfurt", CountryId = 2 });
            dbContext.Cities.Add(new City { Name = "New York", CountryId = 3 });

            dbContext.SaveChanges();
            #endregion

            var salt = Crypto.GenerateSalt();

            #region User specific o2m

            var superAdmin = new User
            {
                Username = "demo.superadmin",
                PasswordHash = Crypto.GetHashedPassword("demo", salt),
                PasswordSalt = salt
            };
            var admin = new User
            {
                Username = "demo.admin",
                PasswordHash = Crypto.GetHashedPassword("demo", salt),
                PasswordSalt = salt
            };
            var organization = new User
            {
                Username = "demo.organization",
                PasswordHash = Crypto.GetHashedPassword("demo", salt),
                PasswordSalt = salt
            };
            var organizationUser1 = new User
            {
                Username = "demo.organization1",
                PasswordHash = Crypto.GetHashedPassword("demo", salt),
                PasswordSalt = salt
            };
            var organizationUser2 = new User
            {
                Username = "demo.organization2",
                PasswordHash = Crypto.GetHashedPassword("demo", salt),
                PasswordSalt = salt
            };
            var client = new User
            {
                Username = "demo.client",
                PasswordHash = Crypto.GetHashedPassword("demo", salt),
                PasswordSalt = salt
            };
            var deliveryPerson = new User
            {
                Username = "demo.deliveryperson",
                PasswordHash = Crypto.GetHashedPassword("demo", salt),
                PasswordSalt = salt
            };

            dbContext.Users.Add(superAdmin);
            dbContext.Users.Add(admin);
            dbContext.Users.Add(organization);
            dbContext.Users.Add(organizationUser1);
            dbContext.Users.Add(organizationUser2);
            dbContext.Users.Add(client);
            dbContext.Users.Add(deliveryPerson);

            dbContext.SaveChanges();
            #endregion

            #region Roles
            var roleSuperAdmin = new Role { Name = UserType.SuperAdministrator.ToString() };
            var roleAdmin = new Role { Name = UserType.Administrator.ToString() };
            var roleOrganization = new Role { Name = UserType.Organization.ToString() };
            var roleClient = new Role { Name = UserType.Client.ToString() };
            var roleDeliveryPerson = new Role { Name = UserType.DeliveryPerson.ToString() };
            dbContext.Roles.Add(roleSuperAdmin);
            dbContext.Roles.Add(roleAdmin);
            dbContext.Roles.Add(roleOrganization);
            dbContext.Roles.Add(roleClient);
            dbContext.Roles.Add(roleDeliveryPerson);

            dbContext.SaveChanges();
            #endregion

            #region UserRoles
            dbContext.UserRoles.Add(new UserRole { UserId = superAdmin.Id, RoleId = roleSuperAdmin.Id });
            dbContext.UserRoles.Add(new UserRole { UserId = admin.Id, RoleId = roleAdmin.Id });
            dbContext.UserRoles.Add(new UserRole { UserId = organization.Id, RoleId = roleOrganization.Id });
            dbContext.UserRoles.Add(new UserRole { UserId = organizationUser1.Id, RoleId = roleOrganization.Id });
            dbContext.UserRoles.Add(new UserRole { UserId = organizationUser2.Id, RoleId = roleOrganization.Id });
            dbContext.UserRoles.Add(new UserRole { UserId = client.Id, RoleId = roleClient.Id });
            dbContext.UserRoles.Add(new UserRole { UserId = deliveryPerson.Id, RoleId = roleDeliveryPerson.Id });

            dbContext.SaveChanges();
            #endregion

            #region Categories 
            var category1 = new Category { Name = "Soups" };
            var category2 = new Category { Name = "Sea food" };
            var category3 = new Category { Name = "Desserts" };

            dbContext.Categories.Add(category1);
            dbContext.Categories.Add(category2);
            dbContext.Categories.Add(category3);

            dbContext.SaveChanges();
            #endregion

            #region VehicleTypes
            var vehicleType1 = new VehicleType { Name = "Bike" };
            var vehicleType2 = new VehicleType { Name = "Car" };
            var vehicleType3 = new VehicleType { Name = "Scooter" };

            dbContext.VehicleTypes.Add(vehicleType1);
            dbContext.VehicleTypes.Add(vehicleType2);
            dbContext.VehicleTypes.Add(vehicleType3);

            dbContext.SaveChanges();
            #endregion

            #region Persons
            var person1 = new Person
            {
                FirstName = "Salih",
                LastName = "Agić",
                UserId = client.Id,
                BirthDate = DateTime.Now,
                Gender = "M"
            };
            dbContext.Persons.Add(person1);

            var person2 = new Person
            {
                FirstName = "Ajdin",
                LastName = "Ljubunčić",
                UserId = deliveryPerson.Id,
                BirthDate = DateTime.Now,
                Gender = "M"
            };
            dbContext.Persons.Add(person2);

            dbContext.SaveChanges();
            #endregion

            #region Delivery persons
            var deliveryPerson1 = new DeliveryPerson
            {
                PersonId = person1.Id,
                VehicleTypeId = vehicleType1.Id,
                DeliveryRadiusKilometers = 1.3
            };
            dbContext.DeliveryPersons.Add(deliveryPerson1);

            dbContext.SaveChanges();
            #endregion

            #region Organization type
            var organizationType1 = new OrganizationType { Name = "Pizza place" };
            var organizationType2 = new OrganizationType { Name = "Fast food" };
            var organizationType3 = new OrganizationType { Name = "Restaurant" };

            dbContext.OrganizationTypes.Add(organizationType1);
            dbContext.OrganizationTypes.Add(organizationType2);
            dbContext.OrganizationTypes.Add(organizationType3);

            dbContext.SaveChanges();
            #endregion

            #region Currency
            var currency1 = new Currency
            {
                Name = "BAM"
            };
            dbContext.Currencies.Add(currency1);

            dbContext.SaveChanges();
            #endregion

            #region Organizations

            var path = "../eOrder.DAL/StaticResources/Profile/";

            var organization1 = new Organization
            {
                Name = "Blitz d.o.o.",
                ShortName = "Blitz",
                CurrencyId = currency1.Id,
                OrganizationTypeId = organizationType1.Id,
                UserId = organization.Id,
                ProfilePhoto = System.IO.File.ReadAllBytes($"{path}1.jpg")
            };
            dbContext.Organizations.Add(organization1);

            var organization2 = new Organization
            {
                Name = "Casablanca d.o.o.",
                ShortName = "Casablanca",
                CurrencyId = currency1.Id,
                OrganizationTypeId = organizationType1.Id,
                UserId = organizationUser1.Id,
                ProfilePhoto = System.IO.File.ReadAllBytes($"{path}2.jpg")
            };
            dbContext.Organizations.Add(organization2);

            var organization3 = new Organization
            {
                Name = "Urban d.o.o.",
                ShortName = "Urban",
                CurrencyId = currency1.Id,
                OrganizationTypeId = organizationType2.Id,
                UserId = organizationUser2.Id,
                ProfilePhoto = System.IO.File.ReadAllBytes($"{path}3.jpg")
            };
            dbContext.Organizations.Add(organization3);

            dbContext.SaveChanges();
            #endregion

            #region Locations
            var location1 = new Location
            {
                AddressLine = "Marsala Tita",
                FirstName = "Salih",
                LastName = "Agić",
                PersonId = person1.Id,
                PhoneNumber = "061-555-444"
            };
            dbContext.Locations.Add(location1);

            dbContext.SaveChanges();
            #endregion

            #region Orders
            var order1 = new Order
            {
                ClientId = person1.Id,
                OrganizationId = organization1.Id,
                Total = 1,
                TotalWithTax = 1.17,
                DeliveryTimeEstimated = 15,
                LocationId = location1.Id,
                CurrencyId = currency1.Id,
                AdditionalDescription = "Ovo je dodatni opis koji pobliže opisuje cijelokupnu narudžbu. Npr. kada dođete do stana jako pokucajte jer ne radi zvono.",
                OrderStatus = OrderStatus.Pending,
                OrderType = OrderType.Delivery,
                PaymentType = PaymentType.Paypal,
                IsPayed = true,
                DateTimeCreated = DateTime.Now,
                DateTimeCompleted = DateTime.Now.AddHours(0.5)
            };
            dbContext.Orders.Add(order1);

            var order2 = new Order
            {
                ClientId = person1.Id,
                OrganizationId = organization1.Id,
                Total = 1,
                TotalWithTax = 1.17,
                DeliveryTimeEstimated = 15,
                LocationId = location1.Id,
                CurrencyId = currency1.Id,
                OrderStatus = OrderStatus.Completed,
                OrderType = OrderType.Delivery,
                PaymentType = PaymentType.Paypal,
                IsPayed = true,
                DateTimeCreated = DateTime.Now,
                DateTimeCompleted = DateTime.Now.AddHours(0.5)
            };
            dbContext.Orders.Add(order2);

            var order3 = new Order
            {
                ClientId = person1.Id,
                OrganizationId = organization1.Id,
                CurrencyId = currency1.Id,
                Total = 1,
                TotalWithTax = 1.17,
                DeliveryTimeEstimated = 15,
                LocationId = location1.Id,
                OrderStatus = OrderStatus.Processing,
                OrderType = OrderType.Delivery,
                PaymentType = PaymentType.Paypal,
                IsPayed = false,
                DateTimeCreated = DateTime.Now,
                DateTimeCompleted = DateTime.Now.AddHours(0.5)
            };
            dbContext.Orders.Add(order3);

            dbContext.SaveChanges();
            #endregion

            #region Products

            path = "../eOrder.DAL/StaticResources/Food/";

            var product1 = new Product
            {
                Name = "Pizza Margaritta",
                OrganizationId = organization1.Id,
                Price = 5.20,
                CategoryId = category1.Id,
                Photo = System.IO.File.ReadAllBytes($"{path}6.jpg")
            };
            dbContext.Products.Add(product1);

            var product2 = new Product
            {
                Name = "Hamburger",
                OrganizationId = organization1.Id,
                Price = 3.20,
                CategoryId = category2.Id,
                Photo = System.IO.File.ReadAllBytes($"{path}3.jpg")
            };
            dbContext.Products.Add(product2);

            var product3 = new Product
            {
                Name = "Cheeseburger",
                OrganizationId = organization2.Id,
                Price = 5.20,
                CategoryId = category1.Id,
                Photo = System.IO.File.ReadAllBytes($"{path}5.jpg")
            };
            dbContext.Products.Add(product3);

            var product4 = new Product
            {
                Name = "Burek",
                OrganizationId = organization2.Id,
                Price = 3.20,
                CategoryId = category2.Id,
                Photo = System.IO.File.ReadAllBytes($"{path}2.jpg")
            };
            dbContext.Products.Add(product4);

            var product5 = new Product
            {
                Name = "Cevapcici",
                OrganizationId = organization3.Id,
                Price = 5.20,
                CategoryId = category1.Id,
                Photo = System.IO.File.ReadAllBytes($"{path}4.jpg")
            };
            dbContext.Products.Add(product5);

            var product6 = new Product
            {
                Name = "Africka salata",
                OrganizationId = organization3.Id,
                Price = 3.20,
                CategoryId = category2.Id,
                Photo = System.IO.File.ReadAllBytes($"{path}1.jpg")
            };
            dbContext.Products.Add(product6);

            dbContext.SaveChanges();
            #endregion

            #region OrderDetails
            var orderDetails1 = new OrderDetails
            {
                Amount = 13,
                OrderId = order1.Id,
                ProductId = product1.Id,
                ProductPrice = product1.Price,
                AdditionalDescription = "Ovo je dodatni opis koji pobliže opisuje kako će se napraviti odabrani proizvod."
            };
            dbContext.OrderDetails.Add(orderDetails1);

            var orderDetails2 = new OrderDetails
            {
                Amount = 13,
                OrderId = order1.Id,
                ProductId = product2.Id,
                ProductPrice = product2.Price,
                AdditionalDescription = "Ovo je dodatni opis koji pobliže opisuje kako će se napraviti odabrani proizvod."
            };
            dbContext.OrderDetails.Add(orderDetails2);

            dbContext.SaveChanges();
            #endregion

            #region UserRatings

            var userIds = dbContext.Users.Select(x => x.Id).ToList();
            Random random = new Random();

            foreach (var userFromId in userIds)
            {
                foreach (var userToId in userIds)
                {
                    var userRating1 = new UserRating
                    {
                        UserFromId = userFromId,
                        UserToId = userToId,
                        Rating = random.Next(1, 5),
                        Description = $"Super usluga, brza dostava. {userFromId}-{userToId}"
                    };
                    dbContext.UserRatings.Add(userRating1);
                }
            }

            dbContext.SaveChanges();
            #endregion
        }
    }
}
