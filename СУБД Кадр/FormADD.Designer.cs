﻿namespace СУБД_Кадр
{
    partial class FormADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormADD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbDolj = new System.Windows.Forms.ComboBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.tbPol = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lDolj = new System.Windows.Forms.Label();
            this.lPol = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lEmaii = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 170);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 140);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отдел кадров Наториат\"Империя\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1085, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbDolj
            // 
            this.cbDolj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbDolj.FormattingEnabled = true;
            this.cbDolj.Location = new System.Drawing.Point(478, 349);
            this.cbDolj.Name = "cbDolj";
            this.cbDolj.Size = new System.Drawing.Size(331, 24);
            this.cbDolj.TabIndex = 73;
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bCancel.Location = new System.Drawing.Point(531, 421);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(126, 35);
            this.bCancel.TabIndex = 72;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOk
            // 
            this.bOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bOk.Location = new System.Drawing.Point(109, 421);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(204, 35);
            this.bOk.TabIndex = 71;
            this.bOk.Text = "Зарегистрировать";
            this.bOk.UseVisualStyleBackColor = false;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // tbFam
            // 
            this.tbFam.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbFam.Location = new System.Drawing.Point(109, 250);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(226, 22);
            this.tbFam.TabIndex = 70;
            // 
            // tbOtch
            // 
            this.tbOtch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbOtch.Location = new System.Drawing.Point(109, 309);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.Size = new System.Drawing.Size(226, 22);
            this.tbOtch.TabIndex = 69;
            // 
            // tbPol
            // 
            this.tbPol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPol.Location = new System.Drawing.Point(109, 357);
            this.tbPol.Name = "tbPol";
            this.tbPol.Size = new System.Drawing.Size(226, 22);
            this.tbPol.TabIndex = 68;
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPhone.Location = new System.Drawing.Point(478, 207);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(331, 22);
            this.tbPhone.TabIndex = 67;
            this.tbPhone.TextChanged += new System.EventHandler(this.tbPhone_TextChanged);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbName.Location = new System.Drawing.Point(109, 204);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(226, 22);
            this.tbName.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Имя";
            // 
            // lDolj
            // 
            this.lDolj.AutoSize = true;
            this.lDolj.Location = new System.Drawing.Point(360, 357);
            this.lDolj.Name = "lDolj";
            this.lDolj.Size = new System.Drawing.Size(78, 16);
            this.lDolj.TabIndex = 62;
            this.lDolj.Text = "Должность";
            // 
            // lPol
            // 
            this.lPol.AutoSize = true;
            this.lPol.Location = new System.Drawing.Point(27, 357);
            this.lPol.Name = "lPol";
            this.lPol.Size = new System.Drawing.Size(33, 16);
            this.lPol.TabIndex = 60;
            this.lPol.Text = "Пол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Фамилия";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbEmail.Location = new System.Drawing.Point(478, 279);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(331, 22);
            this.tbEmail.TabIndex = 75;
            // 
            // lEmaii
            // 
            this.lEmaii.AutoSize = true;
            this.lEmaii.Location = new System.Drawing.Point(379, 279);
            this.lEmaii.Name = "lEmaii";
            this.lEmaii.Size = new System.Drawing.Size(48, 16);
            this.lEmaii.TabIndex = 74;
            this.lEmaii.Text = "Почта";
            // 
            // pbImage
            // 
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbImage.Location = new System.Drawing.Point(869, 178);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(170, 166);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 76;
            this.pbImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(839, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 77;
            this.button1.Text = "Загрузить фото";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(1056, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 23);
            this.button2.TabIndex = 78;
            this.button2.Text = "Выставить заглушку";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1240, 522);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lEmaii);
            this.Controls.Add(this.cbDolj);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.tbFam);
            this.Controls.Add(this.tbOtch);
            this.Controls.Add(this.tbPol);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lDolj);
            this.Controls.Add(this.lPol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormADD";
            this.Text = "Наториат\"Империя\"";
            this.Load += new System.EventHandler(this.FormADD_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbDolj;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.TextBox tbOtch;
        private System.Windows.Forms.TextBox tbPol;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lDolj;
        private System.Windows.Forms.Label lPol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lEmaii;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}