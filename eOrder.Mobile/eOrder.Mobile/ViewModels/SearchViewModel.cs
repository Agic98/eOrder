using eOrder.CORE.Requests;
using eOrder.Mobile.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eOrder.Mobile.ViewModels
{
    public class SearchViewModel : BaseViewModel
    {
        private readonly APIService _productService = new APIService("Product");
        public ObservableCollection<ProductModel> Products { get; set; } = new ObservableCollection<ProductModel>();

        public ICommand InitCommand { get; set; }


        public SearchViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        string _productName = string.Empty;
        public string ProductName
        {
            get { return _productName; }
            set { SetProperty(ref _productName, value); }
        }

        double _priceFrom;
        public double PriceFrom
        {
            get { return _priceFrom; }
            set { SetProperty(ref _priceFrom, value); }
        }

        double _priceTo;
        public double PriceTo
        {
            get { return _priceTo; }
            set { SetProperty(ref _priceTo, value); }
        }

        public async Task Init()
        {
            var data = await _productService.Get<IEnumerable<ProductDTO>>(new ProductSearchRequest { Name = ProductName, PriceFrom = PriceFrom, PriceTo = PriceTo });

            Products.Clear();
            foreach (var item in data)
            {
                Products.Add(new ProductModel
                {
                    Product = item,
                    PhotoUrl = $"{APIService._apiUrl}/Product/Photo/{item.Id}"
                });
            }
        }
    }
}
