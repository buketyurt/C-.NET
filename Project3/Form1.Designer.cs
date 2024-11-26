namespace Project3
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
            dgrwCustomers = new System.Windows.Forms.DataGridView();
            tbxId = new System.Windows.Forms.TextBox();
            tbxEmail = new System.Windows.Forms.TextBox();
            tbxLastName = new System.Windows.Forms.TextBox();
            tbxFirstName = new System.Windows.Forms.TextBox();
            tbxCity = new System.Windows.Forms.TextBox();
            lblId = new System.Windows.Forms.Label();
            lblFirstName = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblCity = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            gbxAdd = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgrwCustomers).BeginInit();
            SuspendLayout();
            // 
            // dgrwCustomers
            // 
            dgrwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrwCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            dgrwCustomers.Location = new System.Drawing.Point(0, 0);
            dgrwCustomers.Name = "dgrwCustomers";
            dgrwCustomers.RowHeadersWidth = 51;
            dgrwCustomers.RowTemplate.Height = 29;
            dgrwCustomers.Size = new System.Drawing.Size(800, 188);
            dgrwCustomers.TabIndex = 0;
            // 
            // tbxId
            // 
            tbxId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbxId.Location = new System.Drawing.Point(92, 223);
            tbxId.Name = "tbxId";
            tbxId.Size = new System.Drawing.Size(188, 34);
            tbxId.TabIndex = 1;
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbxEmail.Location = new System.Drawing.Point(92, 322);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new System.Drawing.Size(188, 34);
            tbxEmail.TabIndex = 2;
            // 
            // tbxLastName
            // 
            tbxLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbxLastName.Location = new System.Drawing.Point(92, 289);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new System.Drawing.Size(188, 34);
            tbxLastName.TabIndex = 3;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbxFirstName.Location = new System.Drawing.Point(92, 256);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new System.Drawing.Size(188, 34);
            tbxFirstName.TabIndex = 4;
            // 
            // tbxCity
            // 
            tbxCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbxCity.Location = new System.Drawing.Point(92, 355);
            tbxCity.Name = "tbxCity";
            tbxCity.Size = new System.Drawing.Size(188, 34);
            tbxCity.TabIndex = 5;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(36, 229);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(22, 20);
            lblId.TabIndex = 6;
            lblId.Text = "Id";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(36, 266);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(28, 20);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "Ad";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new System.Drawing.Point(36, 299);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(50, 20);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "Soyad";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(36, 332);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(38, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Mail";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new System.Drawing.Point(36, 369);
            lblCity.Name = "lblCity";
            lblCity.Size = new System.Drawing.Size(42, 20);
            lblCity.TabIndex = 10;
            lblCity.Text = "Şehir";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(92, 405);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(188, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbxAdd
            // 
            gbxAdd.Location = new System.Drawing.Point(12, 194);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new System.Drawing.Size(346, 246);
            gbxAdd.TabIndex = 12;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "ekle";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(lblCity);
            Controls.Add(lblEmail);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblId);
            Controls.Add(tbxCity);
            Controls.Add(tbxFirstName);
            Controls.Add(tbxLastName);
            Controls.Add(tbxEmail);
            Controls.Add(tbxId);
            Controls.Add(dgrwCustomers);
            Controls.Add(gbxAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgrwCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgrwCustomers;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxAdd;
    }
}
