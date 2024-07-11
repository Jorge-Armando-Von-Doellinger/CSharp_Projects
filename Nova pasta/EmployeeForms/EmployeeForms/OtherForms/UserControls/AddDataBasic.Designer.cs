namespace EmployeeForms.OtherForms.UserControls
{
    partial class AddDataBasic
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textbox_phoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.textbox_cpf = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dateTime_dateBirth = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textbox_email = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textbox_lastname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textbox_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // textbox_phoneNumber
            // 
            this.textbox_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_phoneNumber.Location = new System.Drawing.Point(413, 126);
            this.textbox_phoneNumber.Mask = "(99) 99999-9999";
            this.textbox_phoneNumber.Name = "textbox_phoneNumber";
            this.textbox_phoneNumber.Size = new System.Drawing.Size(200, 21);
            this.textbox_phoneNumber.TabIndex = 19;
            // 
            // textbox_cpf
            // 
            this.textbox_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_cpf.Location = new System.Drawing.Point(413, 57);
            this.textbox_cpf.Mask = "999.999.999-99";
            this.textbox_cpf.Name = "textbox_cpf";
            this.textbox_cpf.Size = new System.Drawing.Size(200, 21);
            this.textbox_cpf.TabIndex = 17;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(413, 176);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(128, 19);
            this.metroLabel6.TabIndex = 23;
            this.metroLabel6.Text = "Data de nascimento:";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTime_dateBirth
            // 
            this.dateTime_dateBirth.Location = new System.Drawing.Point(413, 195);
            this.dateTime_dateBirth.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTime_dateBirth.Name = "dateTime_dateBirth";
            this.dateTime_dateBirth.Size = new System.Drawing.Size(200, 29);
            this.dateTime_dateBirth.TabIndex = 20;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(413, 34);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(30, 19);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Cpf";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(413, 103);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "N° para contato";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textbox_email
            // 
            // 
            // 
            // 
            this.textbox_email.CustomButton.Image = null;
            this.textbox_email.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.textbox_email.CustomButton.Name = "";
            this.textbox_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_email.CustomButton.TabIndex = 1;
            this.textbox_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_email.CustomButton.UseSelectable = true;
            this.textbox_email.CustomButton.Visible = false;
            this.textbox_email.Lines = new string[0];
            this.textbox_email.Location = new System.Drawing.Point(166, 199);
            this.textbox_email.MaxLength = 32767;
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.PasswordChar = '\0';
            this.textbox_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_email.SelectedText = "";
            this.textbox_email.SelectionLength = 0;
            this.textbox_email.SelectionStart = 0;
            this.textbox_email.ShortcutsEnabled = true;
            this.textbox_email.Size = new System.Drawing.Size(200, 23);
            this.textbox_email.TabIndex = 16;
            this.textbox_email.UseSelectable = true;
            this.textbox_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(166, 176);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Email:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textbox_lastname
            // 
            // 
            // 
            // 
            this.textbox_lastname.CustomButton.Image = null;
            this.textbox_lastname.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.textbox_lastname.CustomButton.Name = "";
            this.textbox_lastname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_lastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_lastname.CustomButton.TabIndex = 1;
            this.textbox_lastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_lastname.CustomButton.UseSelectable = true;
            this.textbox_lastname.CustomButton.Visible = false;
            this.textbox_lastname.Lines = new string[0];
            this.textbox_lastname.Location = new System.Drawing.Point(166, 126);
            this.textbox_lastname.MaxLength = 32767;
            this.textbox_lastname.Name = "textbox_lastname";
            this.textbox_lastname.PasswordChar = '\0';
            this.textbox_lastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_lastname.SelectedText = "";
            this.textbox_lastname.SelectionLength = 0;
            this.textbox_lastname.SelectionStart = 0;
            this.textbox_lastname.ShortcutsEnabled = true;
            this.textbox_lastname.Size = new System.Drawing.Size(200, 23);
            this.textbox_lastname.TabIndex = 14;
            this.textbox_lastname.UseSelectable = true;
            this.textbox_lastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_lastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(166, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Sobrenome";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textbox_name
            // 
            // 
            // 
            // 
            this.textbox_name.CustomButton.Image = null;
            this.textbox_name.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.textbox_name.CustomButton.Name = "";
            this.textbox_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_name.CustomButton.TabIndex = 1;
            this.textbox_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_name.CustomButton.UseSelectable = true;
            this.textbox_name.CustomButton.Visible = false;
            this.textbox_name.Lines = new string[0];
            this.textbox_name.Location = new System.Drawing.Point(166, 57);
            this.textbox_name.MaxLength = 32767;
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.PasswordChar = '\0';
            this.textbox_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_name.SelectedText = "";
            this.textbox_name.SelectionLength = 0;
            this.textbox_name.SelectionStart = 0;
            this.textbox_name.ShortcutsEnabled = true;
            this.textbox_name.Size = new System.Drawing.Size(200, 23);
            this.textbox_name.TabIndex = 13;
            this.textbox_name.UseSelectable = true;
            this.textbox_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(166, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Nome:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddDataBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textbox_phoneNumber);
            this.Controls.Add(this.textbox_cpf);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.dateTime_dateBirth);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.textbox_email);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.textbox_lastname);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddDataBasic";
            this.Size = new System.Drawing.Size(845, 475);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textbox_phoneNumber;
        private System.Windows.Forms.MaskedTextBox textbox_cpf;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime dateTime_dateBirth;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textbox_email;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textbox_lastname;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textbox_name;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
