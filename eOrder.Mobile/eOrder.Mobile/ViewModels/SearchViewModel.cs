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
        private readonly APIService _categoryService = new APIService("Category");
        public ObservableCollection<ProductModel> Products { get; set; } = new ObservableCollection<ProductModel>();
        public ObservableCollection<CategoryDTO> Categories { get; set; } = new ObservableCollection<CategoryDTO>();

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

        int _categoryId;
        public int CategoryId
        {
            get { return _categoryId; }
            set { SetProperty(ref _categoryId, value); }
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
            var data = await _productService.Get<IEnumerable<ProductDTO>>(new ProductSearchRequest { Name = ProductName, PriceFrom = PriceFrom, PriceTo = PriceTo, CategoryId = CategoryId });

            Products.Clear();
            foreach (var item in data)
            {
                Products.Add(new ProductModel
                {
                    Product = item,
                    PhotoUrl = $"{APIService._apiUrl}/Product/Photo/{item.Id}"
                });
            }

            var categories = await _categoryService.Get<IEnumerable<CategoryDTO>>(null);
            Categories.Clear();
            foreach (var item in categories)
            {
                Categories.Add(item);
            }
        }
    }
}
