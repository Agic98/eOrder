using AutoMapper;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.CORE.Helpers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryRequest, Category>();
            CreateMap<CategoryRequest, CategoryDTO>();

            CreateMap<City, CityDTO>();
            CreateMap<CityRequest, City>();
            CreateMap<CityRequest, CityDTO>();

            CreateMap<Country, CountryDTO>();
            CreateMap<CountryRequest, Country>();
            CreateMap<CountryRequest, CountryDTO>();

            CreateMap<Currency, CurrencyDTO>();
            CreateMap<CurrencyRequest, Currency>();
            CreateMap<CurrencyRequest, CurrencyDTO>();

            CreateMap<DeliveryPerson, DeliveryPersonDTO>();
            CreateMap<DeliveryPersonRequest, DeliveryPerson>();
            CreateMap<DeliveryPersonRequest, DeliveryPersonDTO>();

            CreateMap<DeliveryPersonOrder, DeliveryPersonOrderDTO>();
            CreateMap<DeliveryPersonOrderRequest, DeliveryPersonOrder>();
            CreateMap<DeliveryPersonOrderRequest, DeliveryPersonOrderDTO>();

            CreateMap<Discount, DiscountDTO>();
            CreateMap<DiscountRequest, Discount>();
            CreateMap<DiscountRequest, DiscountDTO>();

            CreateMap<Location, LocationDTO>();
            CreateMap<LocationRequest, Location>();
            CreateMap<LocationRequest, LocationDTO>();

            CreateMap<Order, OrderDTO>();
            CreateMap<OrderRequestClient, Order>();
            CreateMap<OrderRequestOrganization, Order>();
            CreateMap<OrderRequestClient, OrderDTO>();
            CreateMap<OrderRequestOrganization, OrderDTO>();

            CreateMap<OrderDetails, OrderDetailsDTO>();
            CreateMap<OrderDetailsRequest, OrderDetails>();
            CreateMap<OrderDetailsRequest, OrderDetailsDTO>();

            CreateMap<Organization, OrganizationDTO>();
            CreateMap<OrganizationRequest, Organization>();
            CreateMap<OrganizationRequest, OrganizationDTO>();

            CreateMap<OrganizationImage, OrganizationImageDTO>();
            CreateMap<OrganizationImageRequest, OrganizationImage>();
            CreateMap<OrganizationImageRequest, OrganizationImageDTO>();

            CreateMap<OrganizationType, OrganizationTypeDTO>();
            CreateMap<OrganizationTypeRequest, OrganizationType>();
            CreateMap<OrganizationTypeRequest, OrganizationTypeDTO>();

            CreateMap<Person, PersonDTO>();
            CreateMap<PersonRequest, Person>();
            CreateMap<Person, PersonDTO>();

            CreateMap<Product, ProductDTO>();
            CreateMap<ProductRequest, Product>();
            CreateMap<ProductRequest, ProductDTO>();

            CreateMap<ProductRating, ProductRatingDTO>();
            CreateMap<ProductRatingRequest, ProductRating>();
            CreateMap<ProductRatingRequest, ProductRatingDTO>();

            CreateMap<ProductTag, ProductTagDTO>();
            CreateMap<ProductTagRequest, ProductTag>();
            CreateMap<ProductTagRequest, ProductTagDTO>();

            CreateMap<Role, RoleDTO>();
            CreateMap<RoleRequest, Role>();
            CreateMap<RoleRequest, RoleDTO>();

            CreateMap<Tag, TagDTO>();
            CreateMap<TagRequest, Tag>();
            CreateMap<TagRequest, TagDTO>();

            CreateMap<User, UserDTO>();
            CreateMap<User, UserAuthDTO>();
            CreateMap<UserAuthDTO, UserDTO>();
            CreateMap<UserRequest, User>();
            CreateMap<UserRequest, UserDTO>();

            CreateMap<UserPaymentType, UserPaymentTypeDTO>();
            CreateMap<UserPaymentTypeRequest, UserPaymentType>();
            CreateMap<UserPaymentTypeRequest, UserPaymentTypeDTO>();

            CreateMap<UserRating, UserRatingDTO>();
            CreateMap<UserRatingRequest, UserRating>();
            CreateMap<UserRatingRequest, UserRatingDTO>();

            CreateMap<UserRole, UserRoleDTO>();
            CreateMap<UserRoleRequest, UserRole>();
            CreateMap<UserRoleRequest, UserRoleDTO>();

            CreateMap<VehicleType, VehicleTypeDTO>();
            CreateMap<VehicleTypeRequest, VehicleType>();
            CreateMap<VehicleTypeRequest, VehicleTypeDTO>();

            CreateMap<WorkingHour, WorkingHourDTO>();
            CreateMap<WorkingHourRequest, WorkingHour>();
            CreateMap<WorkingHourRequest, WorkingHourDTO>();
        }
    }
}
