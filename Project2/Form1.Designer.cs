namespace Project2
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
            lbxStudentList = new System.Windows.Forms.ListBox();
            lblStudentList = new System.Windows.Forms.Label();
            lblStudentName = new System.Windows.Forms.Label();
            tbxStudentName = new System.Windows.Forms.TextBox();
            btnAddStudent = new System.Windows.Forms.Button();
            btnRemoveStudent = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbxStudentList
            // 
            lbxStudentList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbxStudentList.FormattingEnabled = true;
            lbxStudentList.ItemHeight = 28;
            lbxStudentList.Location = new System.Drawing.Point(37, 124);
            lbxStudentList.Name = "lbxStudentList";
            lbxStudentList.Size = new System.Drawing.Size(150, 200);
            lbxStudentList.TabIndex = 0;
            // 
            // lblStudentList
            // 
            lblStudentList.AutoSize = true;
            lblStudentList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblStudentList.Location = new System.Drawing.Point(37, 81);
            lblStudentList.Name = "lblStudentList";
            lblStudentList.Size = new System.Drawing.Size(138, 28);
            lblStudentList.TabIndex = 1;
            lblStudentList.Text = "Öğrenci Listesi";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblStudentName.Location = new System.Drawing.Point(248, 124);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new System.Drawing.Size(116, 28);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "Öğrenci Adı";
            // 
            // tbxStudentName
            // 
            tbxStudentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbxStudentName.Location = new System.Drawing.Point(370, 124);
            tbxStudentName.Name = "tbxStudentName";
            tbxStudentName.Size = new System.Drawing.Size(379, 34);
            tbxStudentName.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAddStudent.Location = new System.Drawing.Point(637, 164);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new System.Drawing.Size(112, 38);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "Ekle";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Location = new System.Drawing.Point(37, 343);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new System.Drawing.Size(150, 29);
            btnRemoveStudent.TabIndex = 5;
            btnRemoveStudent.Text = "Sil";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnRemoveStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(tbxStudentName);
            Controls.Add(lblStudentName);
            Controls.Add(lblStudentList);
            Controls.Add(lbxStudentList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lbxStudentList;
        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox tbxStudentName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
    }
}
