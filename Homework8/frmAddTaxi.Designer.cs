namespace Homework8
{
    partial class frmAddTaxi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPhoneNew = new System.Windows.Forms.TextBox();
            this.txtParkNew = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAdressNew = new System.Windows.Forms.TextBox();
            this.txtMailNew = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.txtPhoneNew);
            this.panel1.Controls.Add(this.txtParkNew);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtAdressNew);
            this.panel1.Controls.Add(this.txtMailNew);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.lblAdress);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 167);
            this.panel1.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(359, 74);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 39);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(359, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 39);
            this.btnOK.TabIndex = 33;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPhoneNew
            // 
            this.txtPhoneNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPhoneNew.Location = new System.Drawing.Point(83, 71);
            this.txtPhoneNew.Name = "txtPhoneNew";
            this.txtPhoneNew.Size = new System.Drawing.Size(252, 22);
            this.txtPhoneNew.TabIndex = 30;
            // 
            // txtParkNew
            // 
            this.txtParkNew.Location = new System.Drawing.Point(84, 12);
            this.txtParkNew.Name = "txtParkNew";
            this.txtParkNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtParkNew.Size = new System.Drawing.Size(252, 22);
            this.txtParkNew.TabIndex = 26;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 17);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Парк";
            // 
            // txtAdressNew
            // 
            this.txtAdressNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtAdressNew.Location = new System.Drawing.Point(83, 42);
            this.txtAdressNew.Name = "txtAdressNew";
            this.txtAdressNew.Size = new System.Drawing.Size(251, 22);
            this.txtAdressNew.TabIndex = 28;
            // 
            // txtMailNew
            // 
            this.txtMailNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMailNew.Location = new System.Drawing.Point(83, 99);
            this.txtMailNew.Name = "txtMailNew";
            this.txtMailNew.Size = new System.Drawing.Size(251, 22);
            this.txtMailNew.TabIndex = 32;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(7, 74);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(68, 17);
            this.lblPhone.TabIndex = 29;
            this.lblPhone.Text = "Телефон";
            // 
            // lblAdress
            // 
            this.lblAdress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(7, 46);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(48, 17);
            this.lblAdress.TabIndex = 27;
            this.lblAdress.Text = "Адрес";
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(7, 102);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(49, 17);
            this.lblMail.TabIndex = 31;
            this.lblMail.Text = "Почта";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 167);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Новый элемент базы даннных";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPhoneNew;
        private System.Windows.Forms.TextBox txtParkNew;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAdressNew;
        private System.Windows.Forms.TextBox txtMailNew;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblMail;
    }
}