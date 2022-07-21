
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        #region События
        private void Form1_Load(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (conn)
            {
                MySqlDataAdapter SDA = new MySqlDataAdapter($"INSERT INTO `accounts`(`Name`, `Phone`) VALUES ('{tbName.Text}','{tbNumber.Text}')", conn);
                DataTable dataTable = new DataTable();
                SDA.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            SelectAll();
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
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


    }


}
