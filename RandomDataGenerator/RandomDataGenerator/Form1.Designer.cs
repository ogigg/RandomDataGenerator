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
            this.checkB_PolNames = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textB_Street = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textB_Number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textB_State = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textB_Zip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textB_City = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_RandAll
            // 
            this.btn_RandAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RandAll.Location = new System.Drawing.Point(11, 180);
            this.btn_RandAll.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RandAll.Name = "btn_RandAll";
            this.btn_RandAll.Size = new System.Drawing.Size(203, 32);
            this.btn_RandAll.TabIndex = 0;
            this.btn_RandAll.Text = "Random All";
            this.btn_RandAll.UseVisualStyleBackColor = true;
            this.btn_RandAll.Click += new System.EventHandler(this.btn_RandAll_Click);
            // 
            // textB_FirstName
            // 
            this.textB_FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textB_FirstName.Location = new System.Drawing.Point(85, 11);
            this.textB_FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textB_FirstName.Name = "textB_FirstName";
            this.textB_FirstName.ReadOnly = true;
            this.textB_FirstName.Size = new System.Drawing.Size(133, 20);
            this.textB_FirstName.TabIndex = 1;
            this.textB_FirstName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textB_FirstName_MouseClick);
            this.textB_FirstName.TextChanged += new System.EventHandler(this.textB_FirstName_TextChanged);
            // 
            // textB_LastName
            // 
            this.textB_LastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textB_LastName.Location = new System.Drawing.Point(85, 35);
            this.textB_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.textB_LastName.Name = "textB_LastName";
            this.textB_LastName.ReadOnly = true;
            this.textB_LastName.Size = new System.Drawing.Size(133, 20);
            this.textB_LastName.TabIndex = 2;
            this.textB_LastName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textB_LastName_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwisko";
            // 
            // checkB_PolNames
            // 
            this.checkB_PolNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkB_PolNames.AutoSize = true;
            this.checkB_PolNames.Location = new System.Drawing.Point(11, 217);
            this.checkB_PolNames.Name = "checkB_PolNames";
            this.checkB_PolNames.Size = new System.Drawing.Size(107, 17);
            this.checkB_PolNames.TabIndex = 5;
            this.checkB_PolNames.Text = "Polskie nazwiska";
            this.checkB_PolNames.UseVisualStyleBackColor = true;
            this.checkB_PolNames.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ulica";
            // 
            // textB_Street
            // 
            this.textB_Street.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textB_Street.Location = new System.Drawing.Point(85, 59);
            this.textB_Street.Margin = new System.Windows.Forms.Padding(2);
            this.textB_Street.Name = "textB_Street";
            this.textB_Street.ReadOnly = true;
            this.textB_Street.Size = new System.Drawing.Size(133, 20);
            this.textB_Street.TabIndex = 7;
            this.textB_Street.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textB_Street_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numer";
            // 
            // textB_Number
            // 
            this.textB_Number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textB_Number.Location = new System.Drawing.Point(85, 84);
            this.textB_Number.Margin = new System.Windows.Forms.Padding(2);
            this.textB_Number.Name = "textB_Number";
            this.textB_Number.ReadOnly = true;
            this.textB_Number.Size = new System.Drawing.Size(133, 20);
            this.textB_Number.TabIndex = 9;
            this.textB_Number.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textB_Number_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Wojewodztwo";
            // 
            // textB_State
            // 
            this.textB_State.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textB_State.Location = new System.Drawing.Point(85, 132);
            this.textB_State.Margin = new System.Windows.Forms.Padding(2);
            this.textB_State.Name = "textB_State";
            this.textB_State.ReadOnly = true;
            this.textB_State.Size = new System.Drawing.Size(133, 20);
            this.textB_State.TabIndex = 11;
            this.textB_State.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textB_State_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kod pocztowy";
            // 
            // textB_Zip
            // 
            this.textB_Zip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textB_Zip.Location = new System.Drawing.Point(85, 156);
            this.textB_Zip.Margin = new System.Windows.Forms.Padding(2);
            this.textB_Zip.Name = "textB_Zip";
            this.textB_Zip.ReadOnly = true;
            this.textB_Zip.Size = new System.Drawing.Size(133, 20);
            this.textB_Zip.TabIndex = 13;
            this.textB_Zip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textB_Zip_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Miasto";
            // 
            // textB_City
            // 
            this.textB_City.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textB_City.Location = new System.Drawing.Point(85, 108);
            this.textB_City.Margin = new System.Windows.Forms.Padding(2);
            this.textB_City.Name = "textB_City";
            this.textB_City.ReadOnly = true;
            this.textB_City.Size = new System.Drawing.Size(133, 20);
            this.textB_City.TabIndex = 15;
            this.textB_City.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textB_City_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 236);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textB_City);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textB_Zip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textB_State);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textB_Number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textB_Street);
            this.Controls.Add(this.checkB_PolNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textB_LastName);
            this.Controls.Add(this.textB_FirstName);
            this.Controls.Add(this.btn_RandAll);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(0, 275);
            this.Name = "Form1";
            this.Text = "Generator Danych Losowych by Oskar v1.0";
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
        private System.Windows.Forms.CheckBox checkB_PolNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textB_Street;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textB_Number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textB_State;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textB_Zip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textB_City;
    }
}

