
namespace TelephoneBook_
{
    partial class ChangeAccountRowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.lbMobile = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.lbAdress = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(56, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(269, 23);
            this.tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя:";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(56, 77);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(269, 23);
            this.tbPhone.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Телефон:";
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(56, 121);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(269, 23);
            this.tbMobile.TabIndex = 0;
            // 
            // lbMobile
            // 
            this.lbMobile.AutoSize = true;
            this.lbMobile.Location = new System.Drawing.Point(56, 103);
            this.lbMobile.Name = "lbMobile";
            this.lbMobile.Size = new System.Drawing.Size(128, 15);
            this.lbMobile.TabIndex = 1;
            this.lbMobile.Text = "Мобильный телефон:";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(56, 165);
            this.tbAdress.Multiline = true;
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(269, 50);
            this.tbAdress.TabIndex = 0;
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Location = new System.Drawing.Point(56, 147);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(43, 15);
            this.lbAdress.TabIndex = 1;
            this.lbAdress.Text = "Адрес:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeAccountRowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbAdress);
            this.Controls.Add(this.lbMobile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbName);
            this.Name = "ChangeAccountRowForm";
            this.Text = "ChangeAccountRowForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.Label lbMobile;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Button button1;
    }
}