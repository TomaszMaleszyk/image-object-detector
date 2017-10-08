using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozpoznawanieObiektow
{
    public partial class OknoDetekcjiObiektu : Form
    {
        private OknoGlowne oknoGlowne;

        public OknoDetekcjiObiektu(OknoGlowne okno)
        {
            InitializeComponent();

            oknoGlowne = okno;
            pb_wyszukanyObiekt.Image = oknoGlowne.bitmapa;

        }

        private void OknoDetekcjiObiektu_Load(object sender, EventArgs e)
        {

        }
    }
}
