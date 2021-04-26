using eProdaja.Model;
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
    public partial class frmDodajUrediKorisnici : Form
    {
        APIService _serviceKorisnici = new APIService("Korisnici");
        APIService _serviceUloge = new APIService("Uloge");
        private eProdaja.Model.Korisnici _korisnik;

        public frmDodajUrediKorisnici(eProdaja.Model.Korisnici korisnik =null)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtIme,Properties.Resources.ObavezanUnosPolja);
        }

        private async void frmDodajUrediKorisnici_LoadAsync(object sender, EventArgs e)
        {
            await LoadUlogeAsync();
            if(_korisnik!=null)
            {
                txtIme.Text = _korisnik.Ime;
                txtPrezime.Text = _korisnik.Prezime;
                txtEmail.Text = _korisnik.Email;
                txtKorIme.Text = _korisnik.KorisnickoIme;
                cbStatus.Checked = _korisnik.Status.GetValueOrDefault();
            }
        }
        private async Task LoadUlogeAsync()
        {
            var uloge = await _serviceUloge.Get<List<Uloge>>(null);
            clbUloge.DataSource = uloge;
            clbUloge.DisplayMember = "Naziv";
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_korisnik == null)
            {
                var ulogeList = clbUloge.CheckedItems.Cast<Uloge>();
                var ulogeIdList = ulogeList.Select(x => x.UlogaId).ToList();
                //insert
                KorisniciInsertRequest request = new KorisniciInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    KorisnickoIme = txtKorIme.Text,
                    Lozinka = txtLozinka.Text,
                    LozinkaPotvrda = txtLozinkaPotvrda.Text,
                    Status = cbStatus.Checked,
                    Uloge = ulogeIdList
                };

                var korisnik = await _serviceKorisnici.Insert<eProdaja.Model.Korisnici>(request);
            }
            else
            {
                //update
                KorisniciUpdateRequest request = new KorisniciUpdateRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Status = cbStatus.Checked
                };

                var korisnik = await _serviceKorisnici.Update<eProdaja.Model.Korisnici>(_korisnik.KorisnikId, request);
            }
        }
    }
}
