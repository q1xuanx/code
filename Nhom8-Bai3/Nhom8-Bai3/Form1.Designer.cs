namespace Nhom8_Bai3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_notsave = new System.Windows.Forms.Button();
            this.btn_out = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(124, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin chi tiết";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 206);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1030, 261);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã SV";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên SV";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Sinh ";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lớp học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Họ Tên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 26);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(624, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(299, 26);
            this.textBox2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(273, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 26);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(296, 155);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 31);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(528, 155);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(82, 31);
            this.btn_del.TabIndex = 12;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(413, 155);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(82, 31);
            this.btn_mod.TabIndex = 13;
            this.btn_mod.Text = "Sửa";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(635, 155);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(82, 31);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseCompatibleTextRendering = true;
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_notsave
            // 
            this.btn_notsave.Location = new System.Drawing.Point(745, 155);
            this.btn_notsave.Name = "btn_notsave";
            this.btn_notsave.Size = new System.Drawing.Size(130, 31);
            this.btn_notsave.TabIndex = 15;
            this.btn_notsave.Text = "Không Lưu";
            this.btn_notsave.UseVisualStyleBackColor = true;
            // 
            // btn_out
            // 
            this.btn_out.Location = new System.Drawing.Point(902, 155);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(82, 31);
            this.btn_out.TabIndex = 16;
            this.btn_out.Text = "Thoát";
            this.btn_out.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(624, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 28);
            this.comboBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 479);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_notsave);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_notsave;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

