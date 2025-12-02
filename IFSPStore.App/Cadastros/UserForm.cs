using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;

namespace IFSPStore.App.Cadastros
{
    public partial class UserForm : BaseForm
    {
        private readonly IBaseService<User> _userService;
        private List<UserModel>? users;
        public UserForm(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }
        private void PreencheObjeto(User user)
        {
            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Login = txtLogin.Text;
            user.Password = txtPassword.Text;
            user.IsActive = chkActive.Checked;
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var user = _userService.GetById<User>(id);
                        PreencheObjeto(user);
                        user = _userService.Update<User, User, UserValidator>(user);
                    }
                }
                else
                {
                    var user = new User();
                    PreencheObjeto(user);
                    _userService.Add<User, User, UserValidator>(user);

                }

                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _userService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            users = _userService.Get<UserModel>().ToList();
            dataGridViewList.DataSource = users;
            dataGridViewList.Columns["Password"]!.Visible = false;
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void loadList(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtName.Text = linha?.Cells["Name"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtLogin.Text = linha?.Cells["Login"].Value.ToString();
            txtPassword.Text = linha?.Cells["Password"].Value.ToString();
            chkActive.Checked = (bool)(linha?.Cells["IsActive"].Value ?? false);

            txtRegistrationDate.Text = DateTime.TryParse(linha?.Cells["DataCadastro"].Value.ToString(), out var dataC)
                ? dataC.ToString("g")
                : "";

            txtLastLogin.Text = DateTime.TryParse(linha?.Cells["DataLogin"].Value.ToString(), out var dataL)
                ? dataL.ToString("g")
                : "";
        }
    }
}
