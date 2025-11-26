using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;

namespace IFSPStore.App.Cadastros
{
    public partial class CategoryForm : BaseForm
    {
        private IBaseService<Category> _categoryService;
        private List<Category> categories;
        public CategoryForm(IBaseService<Category> categoryService)
        {
            _categoryService = categoryService;
            InitializeComponent();
        }
        private void FormToObject(Category category)
        {
            category.Name = txtName.Text;
        }
        protected override void Save()
        {
            try {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var category = _categoryService.GetById<Category>(id);
                    FormToObject(category);
                    category = _categoryService.Update<Category, Category,
                        CategoryValidator>(category);
                } else
                {

                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _categoryService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            categories = _categoryService.Get<Category>().ToList();
            dataGridViewList.DataSource = categories;
            dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtName.Text = record?.Cells["Name"].Value.ToString();
        }
    }
}
