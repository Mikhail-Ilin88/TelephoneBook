using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneBook_
{
    public partial class ChangeAccountRowForm : Form
    {
        SqlConnection mmSqlConnection = new SqlConnection(@"Data Source=(local);Initial Catalog=Telephonebook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");

        public ChangeAccountRowForm(string id, string name, string phone, string mobile, string adres, object sender = null)
        {
            InitializeComponent();
            Id = id;
            tbName.Text = name;
            tbPhone.Text = phone;
            tbMobile.Text = mobile;
            tbAdress.Text = adres;
            Sender = sender;
        }

        public string Id { get; set; }
        public object Sender { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateRowMmSql();
            var x = (Form1)Sender;
            x.Refresh();
            Close();
        }

        private void UpdateRowMmSql()
        {
            mmSqlConnection.Open();

            SqlCommand cmd = new SqlCommand($"UPDATE [accountsbook] SET AllName = '{tbName.Text}', PhoneNumber = '{tbPhone.Text}', PhoneMobile = '{tbMobile.Text}', Adress = '{tbAdress.Text}' WHERE id = '{Id}'", mmSqlConnection);

            cmd.ExecuteNonQuery();

            mmSqlConnection.Close();
        }
    }
}
