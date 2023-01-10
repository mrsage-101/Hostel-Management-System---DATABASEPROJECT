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
    public partial class FormSTUDENT : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        OracleConnection con;
        public FormSTUDENT()
        {
            InitializeComponent();
        }

        private void FormSTUDENT_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=abubakar; PASSWORD=abc";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void comboBATCH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBATCH_Click(object sender, EventArgs e)
        {

        }

        private void textID_Click(object sender, EventArgs e)
        {

        }

        private void textPASSWORD_Click(object sender, EventArgs e)
        {

        }

        // functionality is performed here
        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();

            if (comboBATCH.Text == string.Empty || textID.Text == string.Empty || textPASSWORD.Text == string.Empty)
            {
                MessageBox.Show("Please! Fill in Boxes");
            }
            else
            {
                con.Open();
                cmd = new OracleCommand("SELECT BATCH,ROLLNO,PASSWORD FROM SDNT_INFO WHERE BATCH=:bax AND ROLLNO=:rn AND PASSWORD=:pass", con);
                cmd.Parameters.Add(new OracleParameter("bax", comboBATCH.Text));
                cmd.Parameters.Add(new OracleParameter("rn", textID.Text));
                cmd.Parameters.Add(new OracleParameter("pass", textPASSWORD.Text));

                // here am storing the value so can access it in STUROOMREG form
                SetValueForText1 = comboBATCH.Text;
                SetValueForText2 = textID.Text;
                SetValueForText3 = textPASSWORD.Text;

                OracleDataReader r = cmd.ExecuteReader();
                string[] feilds = new string[3];

                if (r.Read() && r.GetValue(0).ToString() == comboBATCH.Text && r.GetValue(1).ToString() == textID.Text && r.GetValue(2).ToString() == textPASSWORD.Text)
                {
                    this.Hide();
                    STUCHOOSE SC = new STUCHOOSE();
                    SC.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Enter valid batch,roll or password. Register if not");
                }
                con.Close();
            }
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void textID_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
