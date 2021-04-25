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
        public frmDodajUrediKorisnici()
        {
            InitializeComponent();
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtIme,Properties.Resources.ObavezanUnosPolja);
        }
    }
}
