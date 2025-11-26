using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;

namespace IFSPStore.App.Cadastros
{
    public partial class ProductForm : BaseForm
    {
        private readonly IBaseService<Product> _productService;
        private readonly IBaseService<Category> _categoryService;

        private List<ProductModel>? products;
        public ProductForm(IBaseService<Product> productService, IBaseService<Category> categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
            InitializeComponent();
        }
        
    }
}
