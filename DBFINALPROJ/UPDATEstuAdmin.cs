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
    public partial class UPDATEstuAdmin : Form
    {
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        OracleConnection con;
        public UPDATEstuAdmin()
        {
            InitializeComponent();
        }

        private void UPDATEstuAdmin_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=abubakar; PASSWORD=abc";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            SetValueForText3 = FormSTUDENT.SetValueForText1;
            SetValueForText4 = FormSTUDENT.SetValueForText2;
            SetValueForText5 = FormSTUDENT.SetValueForText3;
            updateGrid();
        }


        private void updateGrid()
        {
            con.Open();
            // Here i am first identifying the user the user who logged in only his info will 
            // visible to him 
            OracleCommand cmd = new OracleCommand();
            cmd = new OracleCommand("SELECT BATCH,ROLLNO FROM SDNT_INFO WHERE BATCH=:bax AND ROLLNO=:rn", con);
            cmd.Parameters.Add(new OracleParameter("bax", comboBATCH.Text));
            cmd.Parameters.Add(new OracleParameter("rn", textROLL.Text));

            OracleDataReader r = cmd.ExecuteReader();
            string[] feilds = new string[3];

            if (r.Read() && r.GetValue(0).ToString() == comboBATCH.Text && r.GetValue(1).ToString() == textROLL.Text)
            {
                cmd = new OracleCommand("SELECT * FROM SDNT_INFO WHERE BATCH=:bax AND ROLLNO=:rn", con);
                cmd.Parameters.Add(new OracleParameter("bax", comboBATCH.Text));
                cmd.Parameters.Add(new OracleParameter("rn", textROLL.Text));

                OracleDataReader empDr1 = cmd.ExecuteReader();

                if (empDr1.Read())
                {
                    textNAME.Text = empDr1[0].ToString();
                    textBATCH.Text = empDr1[1].ToString();
                    textROLLNO.Text = empDr1[2].ToString();
                    textGENDER.Text = empDr1[3].ToString();
                    textCONTACT.Text = empDr1[4].ToString();
                    textUSERNAME.Text = empDr1[5].ToString();
                    textADDRESS.Text = empDr1[7].ToString();
                    textGAURDIAN.Text = empDr1[8].ToString();
                }
            }

            con.Close();
        }
        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            con.Open();

            OracleCommand updateEmp = con.CreateCommand();
            updateEmp.CommandText = "UPDATE SDNT_INFO SET NAME=\'" + textNAME.Text.ToString() + "\',BATCH=\'"
            + textBATCH.Text.ToString() + "\',ROLLNO=" + textROLLNO.Text.ToString() + ",GENDER=\'" + textGENDER.Text.ToString() + "\',CONTACT_NO=\'" + textCONTACT.Text.ToString() +
            "\',USERNAME=\'" + textUSERNAME.Text.ToString() + "\',ADDRESS=\'" + textADDRESS.Text.ToString() + "\',GUARDIAN=\'" + textGAURDIAN.Text.ToString()
            + "\'WHERE ROLLNO=" + textROLL.Text;

            updateEmp.CommandType = CommandType.Text;
            int rows = updateEmp.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Data UPDATE Sucessfully!");
            }
            con.Close();
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMINoption AO = new ADMINoption();
            AO.ShowDialog();
        }

      

        private void btnHostelUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            UPDATEhosAdmin UHA = new UPDATEhosAdmin();
            UHA.ShowDialog();
        }

        private void textROLL_TextChanged(object sender, EventArgs e)
        {

        }

        private void textROLL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            updateGrid();
        }
    }
}
