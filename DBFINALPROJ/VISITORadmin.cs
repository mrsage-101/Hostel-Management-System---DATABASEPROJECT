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
    public partial class VISITORadmin : Form
    {
        OracleConnection con;
        public VISITORadmin()
        {
            InitializeComponent();
        }

        private void VISITORadmin_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=abubakar; PASSWORD=abc";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void bttnINSERT_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand OC = new OracleCommand("INSERT INTO VISITOR_REC VALUES(:BATCH, :ROLL, :VNAME, :VPHONE, :DOB)", con);
            OC.Parameters.Add(new OracleParameter("bax", comboBATCH.Text));
            OC.Parameters.Add(new OracleParameter("rol", textROLLNO.Text));
            OC.Parameters.Add(new OracleParameter("vn", textVNAME.Text));
            OC.Parameters.Add(new OracleParameter("vn", textPHONE.Text));
            OC.Parameters.Add(new OracleParameter("dtp", dateTimePicker1.Text));
            OC.ExecuteNonQuery();
            MessageBox.Show("INSERTED SUCCESFULLY");
            con.Close();
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMINoption AO = new ADMINoption();
            AO.ShowDialog();
        }

        private void textROLLNO_TextChanged(object sender, EventArgs e)
        {

        }

        // validations excaption handled
        private void textROLLNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textVNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void textPHONE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
