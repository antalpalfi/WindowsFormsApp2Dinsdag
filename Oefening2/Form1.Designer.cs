namespace Oefening2
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
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdVrouw = new System.Windows.Forms.RadioButton();
            this.send = new System.Windows.Forms.Button();
            this.rdWestVlanderen = new System.Windows.Forms.RadioButton();
            this.rdOostvlanderen = new System.Windows.Forms.RadioButton();
            this.grbProvincie = new System.Windows.Forms.GroupBox();
            this.grpGeslacht = new System.Windows.Forms.GroupBox();
            this.lbNaam = new System.Windows.Forms.Label();
            this.lbAdres = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.rdBrussel = new System.Windows.Forms.RadioButton();
            this.rdBrabant = new System.Windows.Forms.RadioButton();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.btnDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.grbProvincie.SuspendLayout();
            this.grpGeslacht.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(13, 13);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNaam.TabIndex = 0;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(13, 40);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(301, 20);
            this.txtAdres.TabIndex = 1;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(13, 67);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(100, 20);
            this.numAge.TabIndex = 2;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(103, 19);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(48, 17);
            this.rdMale.TabIndex = 3;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdVrouw
            // 
            this.rdVrouw.AutoSize = true;
            this.rdVrouw.Location = new System.Drawing.Point(6, 20);
            this.rdVrouw.Name = "rdVrouw";
            this.rdVrouw.Size = new System.Drawing.Size(55, 17);
            this.rdVrouw.TabIndex = 4;
            this.rdVrouw.TabStop = true;
            this.rdVrouw.Text = "Vrouw";
            this.rdVrouw.UseVisualStyleBackColor = true;
            this.rdVrouw.CheckedChanged += new System.EventHandler(this.rdVrouw_CheckedChanged);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(18, 359);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 5;
            this.send.Text = "Indienen";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // rdWestVlanderen
            // 
            this.rdWestVlanderen.AutoSize = true;
            this.rdWestVlanderen.Location = new System.Drawing.Point(6, 26);
            this.rdWestVlanderen.Name = "rdWestVlanderen";
            this.rdWestVlanderen.Size = new System.Drawing.Size(98, 17);
            this.rdWestVlanderen.TabIndex = 6;
            this.rdWestVlanderen.TabStop = true;
            this.rdWestVlanderen.Text = "WestVlanderen";
            this.rdWestVlanderen.UseVisualStyleBackColor = true;
            // 
            // rdOostvlanderen
            // 
            this.rdOostvlanderen.AutoSize = true;
            this.rdOostvlanderen.Location = new System.Drawing.Point(1, 62);
            this.rdOostvlanderen.Name = "rdOostvlanderen";
            this.rdOostvlanderen.Size = new System.Drawing.Size(95, 17);
            this.rdOostvlanderen.TabIndex = 7;
            this.rdOostvlanderen.TabStop = true;
            this.rdOostvlanderen.Text = "OostVlanderen";
            this.rdOostvlanderen.UseVisualStyleBackColor = true;
            // 
            // grbProvincie
            // 
            this.grbProvincie.Controls.Add(this.rdBrabant);
            this.grbProvincie.Controls.Add(this.rdBrussel);
            this.grbProvincie.Controls.Add(this.rdOostvlanderen);
            this.grbProvincie.Controls.Add(this.rdWestVlanderen);
            this.grbProvincie.Location = new System.Drawing.Point(12, 160);
            this.grbProvincie.Name = "grbProvincie";
            this.grbProvincie.Size = new System.Drawing.Size(200, 161);
            this.grbProvincie.TabIndex = 8;
            this.grbProvincie.TabStop = false;
            this.grbProvincie.Text = "Provincie ";
            // 
            // grpGeslacht
            // 
            this.grpGeslacht.Controls.Add(this.rdVrouw);
            this.grpGeslacht.Controls.Add(this.rdMale);
            this.grpGeslacht.Location = new System.Drawing.Point(12, 111);
            this.grpGeslacht.Name = "grpGeslacht";
            this.grpGeslacht.Size = new System.Drawing.Size(200, 43);
            this.grpGeslacht.TabIndex = 9;
            this.grpGeslacht.TabStop = false;
            this.grpGeslacht.Text = "Geslacht ";
            // 
            // lbNaam
            // 
            this.lbNaam.AutoSize = true;
            this.lbNaam.Location = new System.Drawing.Point(119, 16);
            this.lbNaam.Name = "lbNaam";
            this.lbNaam.Size = new System.Drawing.Size(35, 13);
            this.lbNaam.TabIndex = 10;
            this.lbNaam.Text = "Naam";
            // 
            // lbAdres
            // 
            this.lbAdres.AutoSize = true;
            this.lbAdres.Location = new System.Drawing.Point(341, 46);
            this.lbAdres.Name = "lbAdres";
            this.lbAdres.Size = new System.Drawing.Size(34, 13);
            this.lbAdres.TabIndex = 11;
            this.lbAdres.Text = "Adres";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(119, 74);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(26, 13);
            this.lbAge.TabIndex = 12;
            this.lbAge.Text = "Age";
            // 
            // rdBrussel
            // 
            this.rdBrussel.AutoSize = true;
            this.rdBrussel.Location = new System.Drawing.Point(1, 96);
            this.rdBrussel.Name = "rdBrussel";
            this.rdBrussel.Size = new System.Drawing.Size(59, 17);
            this.rdBrussel.TabIndex = 8;
            this.rdBrussel.TabStop = true;
            this.rdBrussel.Text = "Brussel";
            this.rdBrussel.UseVisualStyleBackColor = true;
            // 
            // rdBrabant
            // 
            this.rdBrabant.AutoSize = true;
            this.rdBrabant.Location = new System.Drawing.Point(1, 131);
            this.rdBrabant.Name = "rdBrabant";
            this.rdBrabant.Size = new System.Drawing.Size(62, 17);
            this.rdBrabant.TabIndex = 9;
            this.rdBrabant.TabStop = true;
            this.rdBrabant.Text = "Brabant";
            this.rdBrabant.UseVisualStyleBackColor = true;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(508, 39);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 13;
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(563, 74);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 14;
            this.btnDate.Text = "Knop";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbAdres);
            this.Controls.Add(this.lbNaam);
            this.Controls.Add(this.grpGeslacht);
            this.Controls.Add(this.grbProvincie);
            this.Controls.Add(this.send);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtNaam);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.grbProvincie.ResumeLayout(false);
            this.grbProvincie.PerformLayout();
            this.grpGeslacht.ResumeLayout(false);
            this.grpGeslacht.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdVrouw;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.RadioButton rdWestVlanderen;
        private System.Windows.Forms.RadioButton rdOostvlanderen;
        private System.Windows.Forms.GroupBox grbProvincie;
        private System.Windows.Forms.GroupBox grpGeslacht;
        private System.Windows.Forms.Label lbNaam;
        private System.Windows.Forms.Label lbAdres;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.RadioButton rdBrabant;
        private System.Windows.Forms.RadioButton rdBrussel;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button btnDate;
    }
}

