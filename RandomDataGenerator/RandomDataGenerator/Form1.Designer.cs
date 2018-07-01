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
            this.textB_LastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_RandAll
            // 
            this.btn_RandAll.Location = new System.Drawing.Point(844, 10);
            this.btn_RandAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_RandAll.Name = "btn_RandAll";
            this.btn_RandAll.Size = new System.Drawing.Size(100, 32);
            this.btn_RandAll.TabIndex = 0;
            this.btn_RandAll.Text = "Random All";
            this.btn_RandAll.UseVisualStyleBackColor = true;
            this.btn_RandAll.Click += new System.EventHandler(this.btn_RandAll_Click);
            // 
            // textB_FirstName
            // 
            this.textB_FirstName.Location = new System.Drawing.Point(19, 16);
            this.textB_FirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textB_FirstName.Name = "textB_FirstName";
            this.textB_FirstName.ReadOnly = true;
            this.textB_FirstName.Size = new System.Drawing.Size(210, 20);
            this.textB_FirstName.TabIndex = 1;
            this.textB_FirstName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textB_FirstName_MouseClick);
            this.textB_FirstName.TextChanged += new System.EventHandler(this.textB_FirstName_TextChanged);
            // 
            // textB_LastName
            // 
            this.textB_LastName.Location = new System.Drawing.Point(19, 40);
            this.textB_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.textB_LastName.Name = "textB_LastName";
            this.textB_LastName.ReadOnly = true;
            this.textB_LastName.Size = new System.Drawing.Size(210, 20);
            this.textB_LastName.TabIndex = 2;
            this.textB_LastName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textB_LastName_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 280);
            this.Controls.Add(this.textB_LastName);
            this.Controls.Add(this.textB_FirstName);
            this.Controls.Add(this.btn_RandAll);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RandAll;
        private System.Windows.Forms.TextBox textB_FirstName;
        private System.Windows.Forms.TextBox textB_LastName;
    }
}

