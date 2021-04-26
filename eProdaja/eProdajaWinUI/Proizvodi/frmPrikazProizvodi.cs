using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdajaWinUI.Proizvodi
{
    public partial class frmPrikazProizvodi : Form
    {
        private readonly APIService _jediniceMjereService = new APIService("JediniceMjere");
        private readonly APIService _VrsteProizvodumService = new APIService("VrsteProizvodum");
        private readonly APIService _ProizvodiService = new APIService("Proizvodi");
        public frmPrikazProizvodi()
        {
            InitializeComponent();
        }

        private async Task LoadData()
        {
            await LoadJedinicaMjere();
            await LoadVrstaProizvoda();
        }
        private async Task LoadProizvodi(int VrstaProizvodaId = 0)
        {
            ProizvodiSearchObject searchObject = new ProizvodiSearchObject();
            searchObject.IncludeListJedinicaMjere = new string[]
            {
                "JedinicaMjere",
                "Vrsta"
            };
            if (VrstaProizvodaId != 0)
            {
                searchObject.VrstaId = VrstaProizvodaId;
            }
            var result = await _ProizvodiService.Get<List<eProdaja.Model.Proizvodi>>(searchObject);
            dgwProizvodi.DataSource = result;
        }

        private async void frmPrikazProizvodi_Load(object sender, EventArgs e)
        {
            await LoadData();
            await LoadProizvodi();
        }

        private async Task LoadVrstaProizvoda()
        {
            var result = await _VrsteProizvodumService.Get<List<VrsteProizvodum>>();
            result.Insert(0, new VrsteProizvodum());

            cbVrstaProizvoda.DataSource = result;
            cbVrstaProizvoda.DisplayMember = "Naziv";
            cbVrstaProizvoda.ValueMember = "VrstaId";
        }
        private async Task LoadJedinicaMjere()
        {
            var result = await _jediniceMjereService.Get<List<JediniceMjere>>();
            result.Insert(0, new JediniceMjere());

            cbJedMjere.DataSource = result;
            cbJedMjere.DisplayMember = "Naziv";
            cbJedMjere.ValueMember = "JedinicaMjereId";
        }
        

        private async void cbVrstaProizvoda_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            var idObj = cbVrstaProizvoda.SelectedValue;

            if(int.TryParse(idObj.ToString(),out int id))
            {
                await LoadProizvodi(id);
            }
        }


        private void btnSlikaSnimi_Click(object sender, EventArgs e)
        {
            var result = ofdSlika.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = ofdSlika.FileName;
                var file = File.ReadAllBytes(fileName);

                txtSlikaPutanja.Text = fileName;
                picProizvod.Image = Image.FromFile(fileName);

            }
        }
    }
}
