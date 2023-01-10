using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DBFINALPROJ
{
    public partial class STUCHOOSE : Form
    {

        public STUCHOOSE()
        {
            InitializeComponent();
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPersonalSTU FPS = new FormPersonalSTU();
            FPS.ShowDialog();
        }

        private void btnHostelAtt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHostelAttSTU FHS = new FormHostelAttSTU();
            FHS.ShowDialog();
        }

        private void btnMESS_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMESSATTENDENCEstu FMS = new FormMESSATTENDENCEstu();
            FMS.ShowDialog();
        }

        // GYM REGISTRATION
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGYMREG FGR = new FormGYMREG();
            FGR.ShowDialog();
        }

        private void btbBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
