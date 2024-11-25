namespace Classes
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
            lbxStudents = new System.Windows.Forms.ListBox();
            dgrwStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgrwStudents).BeginInit();
            SuspendLayout();
            // 
            // lbxStudents
            // 
            lbxStudents.FormattingEnabled = true;
            lbxStudents.ItemHeight = 20;
            lbxStudents.Location = new System.Drawing.Point(12, 12);
            lbxStudents.Name = "lbxStudents";
            lbxStudents.Size = new System.Drawing.Size(192, 284);
            lbxStudents.TabIndex = 0;
            // 
            // dgrwStudents
            // 
            dgrwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrwStudents.Location = new System.Drawing.Point(249, 12);
            dgrwStudents.Name = "dgrwStudents";
            dgrwStudents.RowHeadersWidth = 51;
            dgrwStudents.RowTemplate.Height = 29;
            dgrwStudents.Size = new System.Drawing.Size(502, 284);
            dgrwStudents.TabIndex = 1;
            dgrwStudents.CellContentClick += dgrwStudents_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgrwStudents);
            Controls.Add(lbxStudents);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgrwStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lbxStudents;
        private System.Windows.Forms.DataGridView dgrwStudents;
    }
}
