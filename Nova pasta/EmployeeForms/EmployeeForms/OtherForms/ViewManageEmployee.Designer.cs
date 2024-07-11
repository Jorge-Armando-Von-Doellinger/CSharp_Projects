namespace EmployeeForms.OtherForms
{
    partial class ViewManageEmployee
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
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.numUpDown_PIS = new System.Windows.Forms.NumericUpDown();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.textbox_positionWork = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.textbox_lunchTime = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.textbox_endWork = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.textbox_startWork = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.textbox_department = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_PIS)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_phoneNumber
            // 
            this.textbox_phoneNumber.Enabled = false;
            this.textbox_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_phoneNumber.Location = new System.Drawing.Point(50, 279);
            this.textbox_phoneNumber.Mask = "(99) 99999-9999";
            this.textbox_phoneNumber.Name = "textbox_phoneNumber";
            this.textbox_phoneNumber.Size = new System.Drawing.Size(200, 21);
            this.textbox_phoneNumber.TabIndex = 31;
            // 
            // textbox_cpf
            // 
            this.textbox_cpf.Enabled = false;
            this.textbox_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_cpf.Location = new System.Drawing.Point(310, 96);
            this.textbox_cpf.Mask = "999.999.999-99";
            this.textbox_cpf.Name = "textbox_cpf";
            this.textbox_cpf.Size = new System.Drawing.Size(200, 21);
            this.textbox_cpf.TabIndex = 29;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(302, 129);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(128, 19);
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "Data de nascimento:";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTime_dateBirth
            // 
            this.dateTime_dateBirth.Enabled = false;
            this.dateTime_dateBirth.Location = new System.Drawing.Point(310, 151);
            this.dateTime_dateBirth.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTime_dateBirth.Name = "dateTime_dateBirth";
            this.dateTime_dateBirth.Size = new System.Drawing.Size(200, 29);
            this.dateTime_dateBirth.TabIndex = 32;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(309, 74);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(30, 19);
            this.metroLabel5.TabIndex = 34;
            this.metroLabel5.Text = "Cpf";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(50, 255);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 33;
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
            this.textbox_email.Enabled = false;
            this.textbox_email.Lines = new string[0];
            this.textbox_email.Location = new System.Drawing.Point(50, 218);
            this.textbox_email.MaxLength = 32767;
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.PasswordChar = '\0';
            this.textbox_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_email.SelectedText = "";
            this.textbox_email.SelectionLength = 0;
            this.textbox_email.SelectionStart = 0;
            this.textbox_email.ShortcutsEnabled = true;
            this.textbox_email.Size = new System.Drawing.Size(200, 23);
            this.textbox_email.TabIndex = 28;
            this.textbox_email.UseSelectable = true;
            this.textbox_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(50, 196);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 30;
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
            this.textbox_lastname.Enabled = false;
            this.textbox_lastname.Lines = new string[0];
            this.textbox_lastname.Location = new System.Drawing.Point(50, 151);
            this.textbox_lastname.MaxLength = 32767;
            this.textbox_lastname.Name = "textbox_lastname";
            this.textbox_lastname.PasswordChar = '\0';
            this.textbox_lastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_lastname.SelectedText = "";
            this.textbox_lastname.SelectionLength = 0;
            this.textbox_lastname.SelectionStart = 0;
            this.textbox_lastname.ShortcutsEnabled = true;
            this.textbox_lastname.Size = new System.Drawing.Size(200, 23);
            this.textbox_lastname.TabIndex = 26;
            this.textbox_lastname.UseSelectable = true;
            this.textbox_lastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_lastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(50, 129);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 27;
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
            this.textbox_name.Enabled = false;
            this.textbox_name.Lines = new string[0];
            this.textbox_name.Location = new System.Drawing.Point(50, 96);
            this.textbox_name.MaxLength = 32767;
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.PasswordChar = '\0';
            this.textbox_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_name.SelectedText = "";
            this.textbox_name.SelectionLength = 0;
            this.textbox_name.SelectionStart = 0;
            this.textbox_name.ShortcutsEnabled = true;
            this.textbox_name.Size = new System.Drawing.Size(200, 23);
            this.textbox_name.TabIndex = 25;
            this.textbox_name.UseSelectable = true;
            this.textbox_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(50, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Nome:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(564, 196);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(30, 19);
            this.metroLabel7.TabIndex = 47;
            this.metroLabel7.Text = "PIS:";
            // 
            // numUpDown_PIS
            // 
            this.numUpDown_PIS.Enabled = false;
            this.numUpDown_PIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_PIS.Location = new System.Drawing.Point(564, 220);
            this.numUpDown_PIS.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numUpDown_PIS.Name = "numUpDown_PIS";
            this.numUpDown_PIS.Size = new System.Drawing.Size(179, 21);
            this.numUpDown_PIS.TabIndex = 43;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(564, 129);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(49, 19);
            this.metroLabel8.TabIndex = 46;
            this.metroLabel8.Text = "Cargo:";
            // 
            // textbox_positionWork
            // 
            // 
            // 
            // 
            this.textbox_positionWork.CustomButton.Image = null;
            this.textbox_positionWork.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.textbox_positionWork.CustomButton.Name = "";
            this.textbox_positionWork.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_positionWork.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_positionWork.CustomButton.TabIndex = 1;
            this.textbox_positionWork.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_positionWork.CustomButton.UseSelectable = true;
            this.textbox_positionWork.CustomButton.Visible = false;
            this.textbox_positionWork.Enabled = false;
            this.textbox_positionWork.Lines = new string[0];
            this.textbox_positionWork.Location = new System.Drawing.Point(564, 151);
            this.textbox_positionWork.MaxLength = 32767;
            this.textbox_positionWork.Name = "textbox_positionWork";
            this.textbox_positionWork.PasswordChar = '\0';
            this.textbox_positionWork.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_positionWork.SelectedText = "";
            this.textbox_positionWork.SelectionLength = 0;
            this.textbox_positionWork.SelectionStart = 0;
            this.textbox_positionWork.ShortcutsEnabled = true;
            this.textbox_positionWork.Size = new System.Drawing.Size(179, 23);
            this.textbox_positionWork.TabIndex = 42;
            this.textbox_positionWork.UseSelectable = true;
            this.textbox_positionWork.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_positionWork.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(309, 255);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(121, 19);
            this.metroLabel9.TabIndex = 45;
            this.metroLabel9.Text = "Horario de almoço";
            // 
            // textbox_lunchTime
            // 
            this.textbox_lunchTime.Enabled = false;
            this.textbox_lunchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_lunchTime.Location = new System.Drawing.Point(309, 279);
            this.textbox_lunchTime.Mask = "99:99";
            this.textbox_lunchTime.Name = "textbox_lunchTime";
            this.textbox_lunchTime.Size = new System.Drawing.Size(201, 21);
            this.textbox_lunchTime.TabIndex = 39;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(309, 318);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(121, 19);
            this.metroLabel10.TabIndex = 44;
            this.metroLabel10.Text = "Fim de expediente:";
            // 
            // textbox_endWork
            // 
            this.textbox_endWork.Enabled = false;
            this.textbox_endWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_endWork.Location = new System.Drawing.Point(310, 340);
            this.textbox_endWork.Mask = "99:99";
            this.textbox_endWork.Name = "textbox_endWork";
            this.textbox_endWork.Size = new System.Drawing.Size(200, 21);
            this.textbox_endWork.TabIndex = 40;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(309, 196);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(129, 19);
            this.metroLabel11.TabIndex = 41;
            this.metroLabel11.Text = "Inicio de expediente:";
            // 
            // textbox_startWork
            // 
            this.textbox_startWork.Enabled = false;
            this.textbox_startWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_startWork.Location = new System.Drawing.Point(309, 220);
            this.textbox_startWork.Mask = "99:99";
            this.textbox_startWork.Name = "textbox_startWork";
            this.textbox_startWork.Size = new System.Drawing.Size(201, 21);
            this.textbox_startWork.TabIndex = 37;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(564, 74);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(98, 19);
            this.metroLabel12.TabIndex = 38;
            this.metroLabel12.Text = "Departamento:";
            // 
            // textbox_department
            // 
            // 
            // 
            // 
            this.textbox_department.CustomButton.Image = null;
            this.textbox_department.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.textbox_department.CustomButton.Name = "";
            this.textbox_department.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_department.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_department.CustomButton.TabIndex = 1;
            this.textbox_department.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_department.CustomButton.UseSelectable = true;
            this.textbox_department.CustomButton.Visible = false;
            this.textbox_department.Enabled = false;
            this.textbox_department.Lines = new string[0];
            this.textbox_department.Location = new System.Drawing.Point(564, 94);
            this.textbox_department.MaxLength = 32767;
            this.textbox_department.Name = "textbox_department";
            this.textbox_department.PasswordChar = '\0';
            this.textbox_department.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_department.SelectedText = "";
            this.textbox_department.SelectionLength = 0;
            this.textbox_department.SelectionStart = 0;
            this.textbox_department.ShortcutsEnabled = true;
            this.textbox_department.Size = new System.Drawing.Size(179, 23);
            this.textbox_department.TabIndex = 36;
            this.textbox_department.UseSelectable = true;
            this.textbox_department.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_department.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(41, 404);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(142, 23);
            this.metroButton1.TabIndex = 48;
            this.metroButton1.Text = "Atualizar dados";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(601, 404);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(142, 23);
            this.metroButton2.TabIndex = 49;
            this.metroButton2.Text = "Fechar";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(206, 404);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(142, 23);
            this.metroButton4.TabIndex = 51;
            this.metroButton4.Text = "Deletar empregado";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // ViewManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.numUpDown_PIS);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.textbox_positionWork);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.textbox_lunchTime);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.textbox_endWork);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.textbox_startWork);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.textbox_department);
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
            this.DisplayHeader = false;
            this.Name = "ViewManageEmployee";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "ViewManageEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_PIS)).EndInit();
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
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.NumericUpDown numUpDown_PIS;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox textbox_positionWork;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.MaskedTextBox textbox_lunchTime;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.MaskedTextBox textbox_endWork;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.MaskedTextBox textbox_startWork;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox textbox_department;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton4;
    }
}