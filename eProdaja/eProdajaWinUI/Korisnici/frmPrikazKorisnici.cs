using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdajaWinUI.Korisnici
{
    public partial class frmPrikazKorisnici : Form
    {
        APIService _serviceKorisnici = new APIService("Korisnici");
        public frmPrikazKorisnici()
        {
            InitializeComponent();
        }

        private async void btnPrikaz_Click(object sender, EventArgs e)
        {
            KorisniciSearchRequest request = new KorisniciSearchRequest()
            {
                Ime=txtIme.Text
            };
            dgvKorisnici.DataSource =await _serviceKorisnici.Get<List<eProdaja.Model.Korisnici>>(request);
        }

        private async void frmPrikazKorisnici_Load(object sender, EventArgs e)
        {
            dgvKorisnici.DataSource = await _serviceKorisnici.Get<List<eProdaja.Model.Korisnici>>(null);
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
