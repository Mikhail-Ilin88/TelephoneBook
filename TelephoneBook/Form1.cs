
using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database=telephonebook;Uid=root;Pwd=root;");
        SqlConnection mmSqlConnection = new SqlConnection(@"Data Source=(local);Initial Catalog=Telephonebook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");

        #region События
        private void Form1_Load(object sender, EventArgs e)
        {
            //SelectAll();
            SelectAllMm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //OldInsert();
            InsertMm();
            SelectAllMm();


        }

        private void OldInsert()
        {
            using (conn)
            {
                MySqlDataAdapter SDA = new MySqlDataAdapter($"INSERT INTO `accounts`(`Name`, `Phone`) VALUES ('{tbPhoneNumber.Text}','{tbAllName.Text}')", conn);
                DataTable dataTable = new DataTable();
                SDA.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            SelectAll();
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            //OldFind();
            FindMm();
            SelectAllMm();
        }

        private void OldFind()
        {
            using (conn)
            {
                MySqlDataAdapter SDA = new MySqlDataAdapter($"select * from accounts where name like '%{tbFind.Text}%' or phone like '%{tbFind.Text}%'", conn);
                DataTable dataTable = new DataTable();
                SDA.Fill(dataTable);
                dgvFind.DataSource = dataTable;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int indexRow = dgvFind.CurrentCell.RowIndex;
            //string text = indexRow.ToString();

            string id = dgvFind.Rows[indexRow].Cells["id"].Value.ToString();
            //MessageBox.Show(text);
            //MessageBox.Show(id);
            using (conn)
            {
                MySqlDataAdapter SDA = new MySqlDataAdapter($"DELETE FROM `accounts` WHERE id = {id}", conn);
                DataTable dataTable = new DataTable();
                SDA.Fill(dataTable);
            }
            MessageBox.Show($"Контакт под номером: {id} удален", "Удаление");

            // Обновление таблиц
            tbFind_TextChanged(sender, e);
            SelectAll();
        }
        #endregion

        #region Вспомогательные методы
        /// <summary>
        /// Показать все данные с таблицы БД accounts
        /// </summary>
        private void SelectAll()
        {
            using (conn)
            {
                MySqlDataAdapter SDA = new MySqlDataAdapter($"select * from accounts", conn);
                DataTable dataTable = new DataTable();
                SDA.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }


        #endregion

       

        private void SelectAllMm()
        {
            mmSqlConnection.Open();
            SqlCommand cmd = new SqlCommand("select * from [dbo].[accountsbook]", mmSqlConnection);

            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());

            dataGridView1.DataSource = dataTable;

            mmSqlConnection.Close();
        }
        private void InsertMm()
        {
            mmSqlConnection.Open();

            SqlCommand cmd = new SqlCommand($"insert into [dbo].[accountsbook] (AllName, PhoneNumber, PhoneMobile, Adress) values('{tbAllName.Text}', '{tbPhoneNumber.Text}', '{tbPhoneMobile.Text}', '{tbAdress.Text}')", mmSqlConnection);

            //await cmd.ExecuteNonQueryAsync();
            cmd.ExecuteNonQuery();

            mmSqlConnection.Close();

        }
        private void FindMm()
        {
            mmSqlConnection.Open();
            SqlCommand cmd = new SqlCommand($"select * from [dbo].[accountsbook] where (AllName, PhoneNumber, PhoneMobile, Adress) like '{tbFind.Text}' or  like '{tbFind.Text}'  or  like '{tbFind.Text}'  or  like '{tbFind.Text}')", mmSqlConnection);

            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());

            dataGridView1.DataSource = dataTable;

            mmSqlConnection.Close();
        }

       
    }
}
