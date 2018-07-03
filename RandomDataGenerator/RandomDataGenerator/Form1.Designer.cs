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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_RandAll
            // 
            this.btn_RandAll.Location = new System.Drawing.Point(844, 10);
            this.btn_RandAll.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RandAll.Name = "btn_RandAll";
            this.btn_RandAll.Size = new System.Drawing.Size(100, 32);
            this.btn_RandAll.TabIndex = 0;
            this.btn_RandAll.Text = "Random All";
            this.btn_RandAll.UseVisualStyleBackColor = true;
            this.btn_RandAll.Click += new System.EventHandler(this.btn_RandAll_Click);
            // 
            // textB_FirstName
            // 
            this.textB_FirstName.Location = new System.Drawing.Point(70, 16);
            this.textB_FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textB_FirstName.Name = "textB_FirstName";
            this.textB_FirstName.ReadOnly = true;
            this.textB_FirstName.Size = new System.Drawing.Size(210, 20);
            this.textB_FirstName.TabIndex = 1;
            this.textB_FirstName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textB_FirstName_MouseClick);
            this.textB_FirstName.TextChanged += new System.EventHandler(this.textB_FirstName_TextChanged);
            // 
            // textB_LastName
            // 
            this.textB_LastName.Location = new System.Drawing.Point(70, 40);
            this.textB_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.textB_LastName.Name = "textB_LastName";
            this.textB_LastName.ReadOnly = true;
            this.textB_LastName.Size = new System.Drawing.Size(210, 20);
            this.textB_LastName.TabIndex = 2;
            this.textB_LastName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textB_LastName_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwisko";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(844, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Polskie nazwiska";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(529, 89);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 280);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textB_LastName);
            this.Controls.Add(this.textB_FirstName);
            this.Controls.Add(this.btn_RandAll);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

