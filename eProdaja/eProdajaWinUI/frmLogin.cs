using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja.Model;

namespace eProdajaWinUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _api = new APIService("Korisnici");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            APIService.Username = txtKorIme.Text;
            APIService.Password = txtLozinka.Text;

            try
            {
                var result = await _api.Get<List<eProdaja.Model.Korisnici>>();

                frmPocetna frm = new frmPocetna();
                frm.Show();
            }
            catch
            {

                MessageBox.Show("Pogresan username ili password");
            }
        }
    }
}
