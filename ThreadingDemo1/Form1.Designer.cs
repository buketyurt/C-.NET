namespace ThreadingDemo1
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
            btnProcessOne = new System.Windows.Forms.Button();
            btnProcess2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnProcessOne
            // 
            btnProcessOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnProcessOne.Location = new System.Drawing.Point(80, 113);
            btnProcessOne.Name = "btnProcessOne";
            btnProcessOne.Size = new System.Drawing.Size(159, 71);
            btnProcessOne.TabIndex = 0;
            btnProcessOne.Text = "İşlem1";
            btnProcessOne.UseVisualStyleBackColor = true;
            btnProcessOne.Click += btnProcessOne_Click;
            // 
            // btnProcess2
            // 
            btnProcess2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnProcess2.Location = new System.Drawing.Point(464, 113);
            btnProcess2.Name = "btnProcess2";
            btnProcess2.Size = new System.Drawing.Size(159, 71);
            btnProcess2.TabIndex = 1;
            btnProcess2.Text = "İşlem2";
            btnProcess2.UseVisualStyleBackColor = true;
            btnProcess2.Click += btnProcess2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnProcess2);
            Controls.Add(btnProcessOne);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnProcessOne;
        private System.Windows.Forms.Button btnProcess2;
    }
}
