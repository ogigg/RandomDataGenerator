namespace RandomDataGenerator
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
            this.btn_RandAll = new System.Windows.Forms.Button();
            this.textB_FirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_RandAll
            // 
            this.btn_RandAll.Location = new System.Drawing.Point(1126, 12);
            this.btn_RandAll.Name = "btn_RandAll";
            this.btn_RandAll.Size = new System.Drawing.Size(134, 39);
            this.btn_RandAll.TabIndex = 0;
            this.btn_RandAll.Text = "Random All";
            this.btn_RandAll.UseVisualStyleBackColor = true;
            // 
            // textB_FirstName
            // 
            this.textB_FirstName.Location = new System.Drawing.Point(25, 20);
            this.textB_FirstName.Name = "textB_FirstName";
            this.textB_FirstName.Size = new System.Drawing.Size(278, 22);
            this.textB_FirstName.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 511);
            this.Controls.Add(this.textB_FirstName);
            this.Controls.Add(this.btn_RandAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RandAll;
        private System.Windows.Forms.TextBox textB_FirstName;
    }
}

