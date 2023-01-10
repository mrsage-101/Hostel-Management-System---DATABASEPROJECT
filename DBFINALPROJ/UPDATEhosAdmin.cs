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
    public partial class UPDATEhosAdmin : Form
    {
        OracleConnection con;
        public UPDATEhosAdmin()
        {
            InitializeComponent();
        }

        private void UPDATEhosAdmin_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=abubakar; PASSWORD=abc";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            updateGrid();
        }

        private void updateGrid()
        {
            con.Open();
            // Here i am first identifying the user the user who logged in only his info will 
            // visible to him 
            OracleCommand cmd = new OracleCommand();
            cmd = new OracleCommand("SELECT BATCH,ROLLNO FROM HOSTELREG WHERE BATCH=:bax AND ROLLNO=:rn", con);
            cmd.Parameters.Add(new OracleParameter("bax", comboBATCH.Text));
            cmd.Parameters.Add(new OracleParameter("rn", textROLL.Text));

            OracleDataReader r = cmd.ExecuteReader();
            string[] feilds = new string[3];

            if (r.Read() && r.GetValue(0).ToString() == comboBATCH.Text && r.GetValue(1).ToString() == textROLL.Text)
            {
                cmd = new OracleCommand("SELECT * FROM HOSTELREG WHERE BATCH=:bax AND ROLLNO=:rn", con);
                cmd.Parameters.Add(new OracleParameter("bax", comboBATCH.Text));
                cmd.Parameters.Add(new OracleParameter("rn", textROLL.Text));

                OracleDataReader empDr1 = cmd.ExecuteReader();

                if (empDr1.Read())
                {
                    comboHOSTYPE.Text = empDr1[2].ToString();
                    comboHosNAME.Text = empDr1[3].ToString();
                    comboLOC.Text = empDr1[4].ToString();
                    comboFLOOR.Text = empDr1[5].ToString();
                    comboROOM.Text = empDr1[6].ToString();
                }
            }

            con.Close();
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            con.Open();

            OracleCommand updateEmp = con.CreateCommand();
            updateEmp.CommandText = "UPDATE HOSTELREG SET HOSTELTYPE=\'" + comboHOSTYPE.Text.ToString() + "\',HOSTELNAME=\'"
            + comboHosNAME.Text.ToString() + "\',LOCATION=\'" + comboLOC.Text.ToString() + "\',FLOOR=\'" + comboFLOOR.Text.ToString() +  
            "\',ROOM=" + comboROOM.Text.ToString() + "WHERE ROLLNO = " + textROLL.Text.ToString();

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

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            updateGrid();
        }

        // exception handling
        private void textROLL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
