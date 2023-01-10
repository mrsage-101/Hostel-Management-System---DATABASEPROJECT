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
    public partial class REPAIRhosADMIN : Form
    {
        OracleConnection con;
        public REPAIRhosADMIN()
        {
            InitializeComponent();
        }

        private void REPAIRhosADMIN_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=abubakar; PASSWORD=abc";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void bttnINSERT_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("INSERT INTO MAINTENANCE VALUES(:BATCH, :ROLLNO, :ROOM, :ITEM, :HOSTELTYPE, :HOATELNAME)", con);
            cmd.Parameters.Add(new OracleParameter("Bac", comboBATCH.Text));
            cmd.Parameters.Add(new OracleParameter("Rn", textROLL.Text));
            cmd.Parameters.Add(new OracleParameter("Rom", comboROOM.Text));
            cmd.Parameters.Add(new OracleParameter("itm", comboItem.Text));
            cmd.Parameters.Add(new OracleParameter("typ", comboHOSTYPE.Text));
            cmd.Parameters.Add(new OracleParameter("nom", comboHosNAME.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Inserted Successfully!");
        }

        // exception handling



        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMINoption AO = new ADMINoption();
            AO.ShowDialog();
        }

        private void textROLL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
