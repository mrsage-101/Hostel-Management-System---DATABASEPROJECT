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
    public partial class FormAdmin : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        OracleConnection con;
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=abubakar; PASSWORD=abc";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnINSERT_Click(object sender, EventArgs e)
        {
            OracleCommand OC = new OracleCommand();
            if(textUSERNAME.Text == string.Empty || textPASSWORD.Text == string.Empty)
            {
                MessageBox.Show("Please fill in above feilds");
            }
            else
            {
                con.Open();
                OC = new OracleCommand(("SELECT USERNAME,PASSWORD FROM ADMIN_INFO WHERE USERNAME=:usr AND PASSWORD=:pass"), con);
                OC.Parameters.Add(new OracleParameter("usr", textUSERNAME.Text));
                OC.Parameters.Add(new OracleParameter("pass", textPASSWORD.Text));

                // saved these values to use later in other forms
                SetValueForText1 = textUSERNAME.Text;
                SetValueForText2 = textPASSWORD.Text;
                OracleDataReader r = OC.ExecuteReader();
                if(r.Read() && r.GetValue(0).ToString() == textUSERNAME.Text && r.GetValue(1).ToString() == textPASSWORD.Text)
                {
                    this.Hide();
                    ADMINoption AO = new ADMINoption();
                    AO.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please Enter valid Username or Password");
                }
                con.Close();
            }

            
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();                
        }

        private void textUSERNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
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
    }
}
