using System.Collections.Generic;
using System.Linq;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.Helpers;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using eOrder.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class OrderClientController : BaseController<
        Order,
        OrderDTO,
        OrderSearchRequest,
        OrderRequestClient,
        OrderRequestClient
        >
    {
        private ICurrencyService _currencyService;
        private ILocationService _locationService;
        private IOrganizationService _organizationService;
        private IOrderClientService _orderClientService;

        public OrderClientController(
            IOrderClientService OrderService,
            ICurrencyService currencyService,
            ILocationService locationService,
            IOrganizationService organizationService,
            IOrderClientService ordersService
            ) :
            base(OrderService)
        {
            _currencyService = currencyService;
            _locationService = locationService;
            _organizationService = organizationService;
            _orderClientService = ordersService;
        }

        public override IEnumerable<OrderDTO> Get([FromQuery] OrderSearchRequest searchObject = null, [FromQuery] Pagination pagination = null)
        {
            if (searchObject == null)
                searchObject = new OrderSearchRequest();

            searchObject.ClientId = HttpContext.CurrentPerson().Id;

            var data = base.Get(searchObject, pagination);
            return data;
        }

        public override OrderDTO Post([FromBody] OrderRequestClient request)
        {
            request.ClientId = HttpContext.CurrentPerson().Id;

            if (request.LocationId == 0)
            {
                request.LocationId =
                    _locationService.Get(new LocationSearchRequest
                    {
                        PersonId = request.ClientId,
                        IsPrimary = true
                    }).FirstOrDefault()?.Id
                    ??
                    _locationService.Get(new LocationSearchRequest
                    {
                        PersonId = request.ClientId
                    }).FirstOrDefault()?.Id
                    ??
                    throw new UserException("Niste odabrali lokaciju");
            }

            var organizationDTO = _organizationService.GetById(request.OrganizationId);

            request.CurrencyId = organizationDTO.CurrencyId;
            return base.Post(request);
        }

        public override OrderDTO Put(int id, [FromBody] OrderRequestClient request)
        {
            request.ClientId = HttpContext.CurrentPerson().Id;

            if (request.LocationId == 0)
            {
                request.LocationId =
                    _locationService.Get(new LocationSearchRequest
                    {
                        PersonId = request.ClientId,
                        IsPrimary = true
                    }).FirstOrDefault()?.Id
                    ??
                    _locationService.Get(new LocationSearchRequest
                    {
                        PersonId = request.ClientId
                    }).FirstOrDefault()?.Id
                    ??
                    throw new UserException("Niste odabrali lokaciju");
            }

            var organizationDTO = _organizationService.GetById(request.OrganizationId);

            request.CurrencyId = organizationDTO.CurrencyId;
            return base.Put(id, request);
        }
    }
}
