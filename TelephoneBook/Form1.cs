
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

        SqlConnection mmSqlConnection = new SqlConnection(@"Data Source=(local);Initial Catalog=Telephonebook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");

        #region События
        /// <summary>
        /// При загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            SelectAllMm();
        }

        /// <summary>
        /// Кнопка добавления аккаунта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            InsertMm();
            SelectAllMm();
        }

        /// <summary>
        /// При изменении текстового поля "Поиск"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            FindMm();
        }

        /// <summary>
        /// При нажатии кнопки удаления выбранного контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelete_Click(object sender, EventArgs e)
        {
            DeleteAccountMmSql();
            SelectAllMm();
        }

        /// <summary>
        /// При нажатии кнопки "изменить выбранный контакт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUpdateRow_Click(object sender, EventArgs e)
        {
            ShowChangeRowForm();
        }
        #endregion

        #region Вспомогательные методы
        /// <summary>
        /// Обращение к БД select * from. отображение в DGV
        /// </summary>
        private void SelectAllMm()
        {
            mmSqlConnection.Open();
            SqlCommand cmd = new SqlCommand("select * from [dbo].[accountsbook]", mmSqlConnection);

            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());

            dataGridView1.DataSource = dataTable;

            mmSqlConnection.Close();
        }
        
        /// <summary>
        /// Insert в бд
        /// </summary>
        private void InsertMm()
        {
            mmSqlConnection.Open();

            SqlCommand cmd = new SqlCommand($"insert into [dbo].[accountsbook] (AllName, PhoneNumber, PhoneMobile, Adress) values('{tbAllName.Text}', '{tbPhoneNumber.Text}', '{tbPhoneMobile.Text}', '{tbAdress.Text}')", mmSqlConnection);

            cmd.ExecuteNonQuery();

            mmSqlConnection.Close();
        }
        
        /// <summary>
        /// Удаление выбранного контакта в БД
        /// </summary>
        private void DeleteAccountMmSql()
        {
            int indexRow = dataGridView1.CurrentCell.RowIndex;

            string id = dataGridView1.Rows[indexRow].Cells["id"].Value.ToString();
            string name = dataGridView1.Rows[indexRow].Cells["AllName"].Value.ToString();

            DialogResult dialog = MessageBox.Show($"Удалить контакт: {id}. {name}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                mmSqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"delete from  [dbo].[accountsbook] where id = '{id}'", mmSqlConnection);

                cmd.ExecuteNonQuery();

                mmSqlConnection.Close();
                MessageBox.Show("Контакт удален!");
            }
        }

        /// <summary>
        /// Поиск контакта в БД
        /// </summary>
        private void FindMm()
        {
            mmSqlConnection.Open();
            SqlCommand cmd = new SqlCommand($"select * from [dbo].[accountsbook] where AllName like '%{tbFind.Text}%' or PhoneNumber like '%{tbFind.Text}%' or PhoneMobile like '%{tbFind.Text}%' or Adress like '%{tbFind.Text}%'", mmSqlConnection);

            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());

            dataGridView1.DataSource = dataTable;

            mmSqlConnection.Close();
        }
        
        /// <summary>
        /// Вызов формы для изменения контакта в бд. Update.
        /// </summary>
        private void ShowChangeRowForm()
        {
            int indexRow = dataGridView1.CurrentCell.RowIndex;

            string id = dataGridView1.Rows[indexRow].Cells["id"].Value.ToString();
            string name = dataGridView1.Rows[indexRow].Cells["AllName"].Value.ToString();
            string phone = dataGridView1.Rows[indexRow].Cells["PhoneNumber"].Value.ToString();
            string mobile = dataGridView1.Rows[indexRow].Cells["PhoneMobile"].Value.ToString();
            string adress = dataGridView1.Rows[indexRow].Cells["Adress"].Value.ToString();

            ChangeAccountRowForm change = new ChangeAccountRowForm(id, name, phone, mobile, adress, this);
            change.Show();
        }
        #endregion

        #region Публичные методы
        /// <summary>
        /// Обновление формы
        /// </summary>
        public void Refresh()
        {
            SelectAllMm();
        }
        #endregion





    }
}
