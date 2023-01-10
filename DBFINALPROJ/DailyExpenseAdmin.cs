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
    public partial class DailyExpenseAdmin : Form
    {
        OracleConnection con;
        public DailyExpenseAdmin()
        {
            InitializeComponent();
        }

        private void DailyExpenseAdmin_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=abubakar; PASSWORD=abc";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void bttnINSERT_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand OC = new OracleCommand("INSERT INTO EXPENSE VALUES(:DOB, :AMT)", con);
            OC.Parameters.Add(new OracleParameter("dob", dateTimePicker1.Text));
            OC.Parameters.Add(new OracleParameter("amount", textAMT.Text));
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

        // exception handling
        private void textAMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
