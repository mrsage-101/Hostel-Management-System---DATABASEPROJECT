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
    public partial class 
    INSETstuAdmin : Form
    {
        OracleConnection con;
        public INSETstuAdmin()
        {
            InitializeComponent();
        }

        private void INSETstuAdmin_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=abubakar; PASSWORD=abc";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnINSERT_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand OC = new OracleCommand("INSERT INTO SDNT_INFO VALUES(:NAME, :BATCH, :ROLLNO, :GENDER, :CONTACT_NO, :USERNAME, :PASSWORD, :ADDRESS, :GUARDIAN)", con);
            OC.Parameters.Add(new OracleParameter("NM", textNAME.Text));
            OC.Parameters.Add(new OracleParameter("BC", comboBATCH.Text));
            OC.Parameters.Add(new OracleParameter("RN", textROLL.Text));
            OC.Parameters.Add(new OracleParameter("GN", comboGENDER.Text));
            OC.Parameters.Add(new OracleParameter("CN", textCONTACT.Text));
            OC.Parameters.Add(new OracleParameter("USR", textUSERNAME.Text));
            OC.Parameters.Add(new OracleParameter("PASS", textPASSWORD.Text));
            OC.Parameters.Add(new OracleParameter("AD", textADDRESS.Text));
            OC.Parameters.Add(new OracleParameter("GU", textGUARDIAN.Text));
            OC.ExecuteNonQuery();

            this.Hide();
            INSEThosAdmin IHA = new INSEThosAdmin();
            IHA.ShowDialog();
            con.Close();
        }

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

        private void textUSERNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textCONTACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textPASSWORD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textADDRESS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void textGUARDIAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void textNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }
    }
}
