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
    public partial class ADMINoption : Form
    {
        OracleConnection con;
        public ADMINoption()
        {
            InitializeComponent();
        }

        private void ADMINoption_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=abubakar; PASSWORD=abc";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

      
        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin fa = new FormAdmin();
            fa.ShowDialog();
        }

        private void btnINSERT_Click(object sender, EventArgs e)
        {
            this.Hide();
            INSETstuAdmin ISA = new INSETstuAdmin();
            ISA.ShowDialog();
        }

        // UPDATE INFO
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UPDATEstuAdmin USA = new UPDATEstuAdmin();
            USA.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DELETEstuAdmin DSA = new DELETEstuAdmin();
            DSA.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            REPAIRhosADMIN RPD = new REPAIRhosADMIN();
            RPD.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DailyExpenseAdmin DEA = new DailyExpenseAdmin();
            DEA.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            VISITORadmin VA = new VISITORadmin();
            VA.ShowDialog();
        }
    }
}
