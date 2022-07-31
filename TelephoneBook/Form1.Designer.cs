
namespace TelephoneBook_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbAllName = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.l = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.tbPhoneMobile = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btUpdateRow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 106);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(595, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbAllName
            // 
            this.tbAllName.Location = new System.Drawing.Point(3, 21);
            this.tbAllName.Name = "tbAllName";
            this.tbAllName.Size = new System.Drawing.Size(231, 23);
            this.tbAllName.TabIndex = 2;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(3, 65);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(231, 23);
            this.tbPhoneNumber.TabIndex = 3;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(3, 95);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(117, 15);
            this.l.TabIndex = 4;
            this.l.Text = "Номер мобильного";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(236, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(43, 47);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(595, 23);
            this.tbFind.TabIndex = 7;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поиск:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Все контакты:";
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btDelete.Location = new System.Drawing.Point(489, 374);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(149, 50);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Удалить выбранный контакт";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // tbPhoneMobile
            // 
            this.tbPhoneMobile.Location = new System.Drawing.Point(3, 113);
            this.tbPhoneMobile.Name = "tbPhoneMobile";
            this.tbPhoneMobile.Size = new System.Drawing.Size(231, 23);
            this.tbPhoneMobile.TabIndex = 10;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(3, 153);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(231, 23);
            this.tbAdress.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Номер телефона";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Адрес";
            // 
            // btUpdateRow
            // 
            this.btUpdateRow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btUpdateRow.Location = new System.Drawing.Point(489, 318);
            this.btUpdateRow.Name = "btUpdateRow";
            this.btUpdateRow.Size = new System.Drawing.Size(149, 50);
            this.btUpdateRow.TabIndex = 14;
            this.btUpdateRow.Text = "Изменить выбранный контакт";
            this.btUpdateRow.UseVisualStyleBackColor = true;
            this.btUpdateRow.Click += new System.EventHandler(this.btUpdateRow_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbAdress);
            this.panel1.Controls.Add(this.tbAllName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbPhoneNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.l);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbPhoneMobile);
            this.panel1.Location = new System.Drawing.Point(43, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 179);
            this.panel1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(670, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btUpdateRow);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Телефонный справочник";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAllName;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox tbPhoneMobile;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btUpdateRow;
        private System.Windows.Forms.Panel panel1;
    }
}

