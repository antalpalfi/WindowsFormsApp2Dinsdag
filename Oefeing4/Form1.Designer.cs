namespace Oefeing4
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
            this.listBoxNB = new System.Windows.Forms.ListBox();
            this.btVoeg = new System.Windows.Forms.Button();
            this.btUit = new System.Windows.Forms.Button();
            this.txtBijsc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btLami = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtBnotitie = new System.Windows.Forms.TextBox();
            this.txtNotitename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxNB
            // 
            this.listBoxNB.FormattingEnabled = true;
            this.listBoxNB.Location = new System.Drawing.Point(12, 42);
            this.listBoxNB.Name = "listBoxNB";
            this.listBoxNB.Size = new System.Drawing.Size(120, 277);
            this.listBoxNB.TabIndex = 0;
            // 
            // btVoeg
            // 
            this.btVoeg.Location = new System.Drawing.Point(12, 371);
            this.btVoeg.Name = "btVoeg";
            this.btVoeg.Size = new System.Drawing.Size(120, 23);
            this.btVoeg.TabIndex = 1;
            this.btVoeg.Text = "Voeg notite toe";
            this.btVoeg.UseVisualStyleBackColor = true;
            this.btVoeg.Click += new System.EventHandler(this.btVoeg_Click);
            // 
            // btUit
            // 
            this.btUit.Location = new System.Drawing.Point(12, 400);
            this.btUit.Name = "btUit";
            this.btUit.Size = new System.Drawing.Size(120, 23);
            this.btUit.TabIndex = 2;
            this.btUit.Text = "Scheur notite uit";
            this.btUit.UseVisualStyleBackColor = true;
            this.btUit.Click += new System.EventHandler(this.btUit_Click);
            // 
            // txtBijsc
            // 
            this.txtBijsc.Location = new System.Drawing.Point(138, 345);
            this.txtBijsc.Name = "txtBijsc";
            this.txtBijsc.Size = new System.Drawing.Size(236, 20);
            this.txtBijsc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bijschrijven";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "NotiteBoekje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Notitie";
            // 
            // btLami
            // 
            this.btLami.Location = new System.Drawing.Point(163, 371);
            this.btLami.Name = "btLami";
            this.btLami.Size = new System.Drawing.Size(159, 23);
            this.btLami.TabIndex = 7;
            this.btLami.Text = "Lamineren";
            this.btLami.UseVisualStyleBackColor = true;
            this.btLami.Click += new System.EventHandler(this.btLami_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(380, 345);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "=>";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtBnotitie
            // 
            this.txtBnotitie.Enabled = false;
            this.txtBnotitie.Location = new System.Drawing.Point(163, 39);
            this.txtBnotitie.Multiline = true;
            this.txtBnotitie.Name = "txtBnotitie";
            this.txtBnotitie.ReadOnly = true;
            this.txtBnotitie.Size = new System.Drawing.Size(191, 282);
            this.txtBnotitie.TabIndex = 9;
            // 
            // txtNotitename
            // 
            this.txtNotitename.Location = new System.Drawing.Point(12, 345);
            this.txtNotitename.Name = "txtNotitename";
            this.txtNotitename.Size = new System.Drawing.Size(120, 20);
            this.txtNotitename.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNotitename);
            this.Controls.Add(this.txtBnotitie);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btLami);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBijsc);
            this.Controls.Add(this.btUit);
            this.Controls.Add(this.btVoeg);
            this.Controls.Add(this.listBoxNB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNB;
        private System.Windows.Forms.Button btVoeg;
        private System.Windows.Forms.Button btUit;
        private System.Windows.Forms.TextBox txtBijsc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLami;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtBnotitie;
        private System.Windows.Forms.TextBox txtNotitename;
        private System.Windows.Forms.Label label4;
    }
}

