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
    public partial class FormMESSATTENDENCEstu : Form
    {
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";

        OracleConnection con;
        public FormMESSATTENDENCEstu()
        {
            InitializeComponent();
        }

        private void FormMESSATTENDENCEstu_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=abubakar; PASSWORD=abc";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            SetValueForText3 = FormSTUDENT.SetValueForText1;
            SetValueForText4 = FormSTUDENT.SetValueForText2;
            SetValueForText5 = FormSTUDENT.SetValueForText3;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnINSERT_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand();
            OracleCommand ins = con.CreateCommand();
            cmd = new OracleCommand("SELECT BATCH,ROLLNO FROM SDNT_INFO WHERE BATCH=:bax AND ROLLNO=:rn", con);
            cmd.Parameters.Add(new OracleParameter("bax", comboBATCH.Text));
            cmd.Parameters.Add(new OracleParameter("rn", textROLLNO.Text));
            OracleDataReader r = cmd.ExecuteReader();
            string[] feilds1 = new string[3];
            if (r.Read() && r.GetValue(0).ToString() == SetValueForText3 && r.GetValue(1).ToString() == SetValueForText4)
            {
                ins.CommandText = "INSERT INTO MESS_ATTENDENCE VALUES(\'" + dateTimePicker1.Text.ToString() +
                  "\',\'" + comboBATCH.Text.ToString() + "\',\'" + textROLLNO.Text.ToString() + "\',\'" + comboATT.Text + "\')";
                ins.CommandType = CommandType.Text;
                int rows = ins.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Please! Enter your Batch and Roll no");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            STUCHOOSE stc = new STUCHOOSE();
            stc.ShowDialog();
        }

        private void textROLLNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
