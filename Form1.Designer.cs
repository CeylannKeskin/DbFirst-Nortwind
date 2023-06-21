namespace DbFirst_Nortwind
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
            label1 = new Label();
            txtCustomerId = new TextBox();
            txtSirketAdi = new TextBox();
            label2 = new Label();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvCustomerList = new DataGridView();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 81);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(151, 73);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(177, 23);
            txtCustomerId.TabIndex = 1;
            // 
            // txtSirketAdi
            // 
            txtSirketAdi.Location = new Point(151, 126);
            txtSirketAdi.Name = "txtSirketAdi";
            txtSirketAdi.Size = new Size(177, 23);
            txtSirketAdi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 134);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Şirket Adı:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(387, 72);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 4;
            btnEkle.Tag = "1";
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(495, 72);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Tag = "2";
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(615, 72);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 6;
            btnSil.Tag = "3";
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerList.Location = new Point(12, 167);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.RowTemplate.Height = 25;
            dgvCustomerList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomerList.Size = new Size(776, 271);
            dgvCustomerList.TabIndex = 7;
            dgvCustomerList.CellMouseClick += dgvCustomerList_CellMouseClick;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(387, 130);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(94, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Seçimi Kaldır";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(dgvCustomerList);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtSirketAdi);
            Controls.Add(label2);
            Controls.Add(txtCustomerId);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerId;
        private TextBox txtSirketAdi;
        private Label label2;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvCustomerList;
        private CheckBox checkBox1;
    }
}