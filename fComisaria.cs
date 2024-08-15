using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class fComisaria : Form
    {
        Comisaria destacamento;

        public fComisaria()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreacion_Click(object sender, EventArgs e)
        {
            Policia juan = new Policia(234324,"juan",23);
            Policia ana = new Policia(334324, "ana", 23);

            destacamento = new Comisaria();
            destacamento.AsignarPolicia(juan);
            destacamento.AsignarPolicia(ana);
        }
    }
}
