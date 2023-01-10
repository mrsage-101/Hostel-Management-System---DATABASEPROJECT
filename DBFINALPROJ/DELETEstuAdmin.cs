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
    public partial class DELETEstuAdmin : Form
    {
        OracleConnection con;
        public DELETEstuAdmin()
        {
            InitializeComponent();
        }

        private void DELETEstuAdmin_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=abubakar; PASSWORD=abc";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void updateGrid()
        {
            con.Open();

            OracleCommand cmd = new OracleCommand();
            // delete student info
            cmd = new OracleCommand("DELETE FROM SDNT_INFO WHERE BATCH=:bax AND ROLLNO=:rn", con);
            cmd.Parameters.Add(new OracleParameter("bax", comboBATCH.Text));
            cmd.Parameters.Add(new OracleParameter("rn", textROLL.Text));
            cmd.ExecuteNonQuery();

            OracleCommand cmd1 = new OracleCommand();
            cmd1 = new OracleCommand("DELETE FROM HOSTELREG WHERE BATCH=:bax AND ROLLNO=:rn", con);
            cmd1.Parameters.Add(new OracleParameter("bax", comboBATCH.Text));
            cmd1.Parameters.Add(new OracleParameter("rn", textROLL.Text));
            cmd1.ExecuteNonQuery();

            OracleCommand cmd2 = new OracleCommand();
            cmd2 = new OracleCommand("DELETE FROM GYMREG WHERE BATCH=:bax AND ROLLNO=:rn", con);
            cmd2.Parameters.Add(new OracleParameter("bax", comboBATCH.Text));
            cmd2.Parameters.Add(new OracleParameter("rn", textROLL.Text));
            cmd2.ExecuteNonQuery();

            OracleCommand cmd3 = new OracleCommand();
            cmd1 = new OracleCommand("DELETE FROM HOSTEL_ATTENCENCE WHERE BATCH=:bax AND ROLLNO=:rn", con);
            cmd1.Parameters.Add(new OracleParameter("bax", comboBATCH.Text));
            cmd1.Parameters.Add(new OracleParameter("rn", textROLL.Text));
            cmd1.ExecuteNonQuery();

            OracleCommand cmd4 = new OracleCommand();
            cmd4 = new OracleCommand("DELETE FROM MESS_ATTENDENCE WHERE BATCH=:bax AND ROLLNO=:rn", con);
            cmd4.Parameters.Add(new OracleParameter("bax", comboBATCH.Text));
            cmd4.Parameters.Add(new OracleParameter("rn", textROLL.Text));
            cmd4.ExecuteNonQuery();


            MessageBox.Show("Data Deleted Successfully");
            // delete student hostel reg
            con.Close();
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMINoption AO = new ADMINoption();
            AO.ShowDialog();
        }

        // exception handled
        private void textROLL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
