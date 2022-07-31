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
        // Коннект
        SqlConnection mmSqlConnection = new SqlConnection(@"Data Source=(local);Initial Catalog=Telephonebook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");

        // Конструктор
        public ChangeAccountRowForm(string id, string name, string phone, string mobile, string adres, object sender)
        {
            InitializeComponent();
            Id = id;
            tbName.Text = name;
            tbPhone.Text = phone;
            tbMobile.Text = mobile;
            tbAdress.Text = adres;
            Sender = sender;
        }

        #region Свойства
        public string Id { get; set; }
        public object Sender { get; set; } 
        #endregion

        #region События
        private void button1_Click(object sender, EventArgs e)
        {
            // делаем апдейт
            UpdateRowMmSql();

            // Обновляем главную форму
            Form1 form = (Form1)Sender;
            form.Refresh();

            // Закрываем форму
            Close();
        }
        #endregion

        #region Методы
        /// <summary>
        /// Update в БД
        /// </summary>
        private void UpdateRowMmSql()
        {
            mmSqlConnection.Open();

            SqlCommand cmd = new SqlCommand($"UPDATE [accountsbook] SET AllName = '{tbName.Text}', PhoneNumber = '{tbPhone.Text}', PhoneMobile = '{tbMobile.Text}', Adress = '{tbAdress.Text}' WHERE id = '{Id}'", mmSqlConnection);

            cmd.ExecuteNonQuery();

            mmSqlConnection.Close();
        } 
        #endregion
    }
}
