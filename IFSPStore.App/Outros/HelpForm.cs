using ReaLTaiizor.Forms;
using System.Diagnostics;

namespace IFSPStore.App.Outros
{
    public partial class HelpForm : MaterialForm
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void btnContactWhatsApp_Click(object sender, EventArgs e)
        {
            string num = "5518981002171";
            string msg = "Olá, preciso de ajuda com o IFSP Store.";

            //Monta a URL do WhatsApp
            string url = $"https://wa.me/{num}?text={Uri.EscapeDataString(msg)}";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true 
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível abrir o WhatsApp: {ex.Message}");
            }
        }
    }
}
