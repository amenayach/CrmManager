using System;
using System.Windows.Forms;

namespace CrmManager.Controls
{
    public partial class CrmConnectionDialog : Form
    {

        public string ConnectionString { get; set; }

        public CrmConnectionDialog()
        {
            InitializeComponent();
            this.Remember(tbUrl);
            this.Remember(tbDomain);
            this.Remember(tbUsername);
            this.Remember(tbPassword);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbUrl.Text.NotEmpty() && tbDomain.Text.NotEmpty() && tbUsername.Text.NotEmpty() && tbPassword.Text.NotEmpty())
            {
                ConnectionString = $@"URL={tbUrl.Text}; Domain=moe; Username={tbUsername.Text.Trim()}; Password={tbPassword.Text.Trim()};";
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        public static string Connect()
        {
            using (var form = new CrmConnectionDialog())
            {
                return form.ShowDialog() == DialogResult.OK ? form.ConnectionString : string.Empty;
            }
        }
    }
}
