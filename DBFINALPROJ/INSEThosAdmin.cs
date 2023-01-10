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
    public partial class INSEThosAdmin : Form
    {
        OracleConnection con;
        public INSEThosAdmin()
        {
            InitializeComponent();
        }

     
        private void INSEThosAdmin_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=abubakar; PASSWORD=abc";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnINSERT_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand OC = new OracleCommand("INSERT INTO HOSTELREG VALUES(:BATCH, :ROLLNO, :HOSTELTYPE, :HOSTELNAME, :LOCATION, :FLOOR, :ROOM, :HOSTELFEE, :MESSFEE)", con);
            OC.Parameters.Add(new OracleParameter("BC", comboBATCH.Text));
            OC.Parameters.Add(new OracleParameter("RN", textROLL.Text));
            OC.Parameters.Add(new OracleParameter("HT", comboHOSTYPE.Text));
            OC.Parameters.Add(new OracleParameter("HN", comboHosNAME.Text));
            OC.Parameters.Add(new OracleParameter("LOC", comboLOC.Text));
            OC.Parameters.Add(new OracleParameter("FLOOR", comboFLOOR.Text));
            OC.Parameters.Add(new OracleParameter("ROM", comboROOM.Text));
            OC.Parameters.Add(new OracleParameter("HF", comboHOSTELFEE.Text));
            OC.Parameters.Add(new OracleParameter("MF", comboMESSFEE.Text));
            OC.ExecuteNonQuery();
            MessageBox.Show("INSERTED SUCCESFULLY");
            con.Close();
        }



        private void button1_Click(object sender, EventArgs e)
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
