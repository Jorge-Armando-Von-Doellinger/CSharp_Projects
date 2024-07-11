namespace EmployeeForms.OtherForms.UserControls
{
    partial class AddDataWork
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
            this.textbox_department = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textbox_startWork = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textbox_endWork = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textbox_lunchTime = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textbox_positionWork = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.numUpDown_PIS = new System.Windows.Forms.NumericUpDown();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_PIS)).BeginInit();
            this.SuspendLayout();
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
            this.textbox_department.Lines = new string[0];
            this.textbox_department.Location = new System.Drawing.Point(175, 158);
            this.textbox_department.MaxLength = 32767;
            this.textbox_department.Name = "textbox_department";
            this.textbox_department.PasswordChar = '\0';
            this.textbox_department.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_department.SelectedText = "";
            this.textbox_department.SelectionLength = 0;
            this.textbox_department.SelectionStart = 0;
            this.textbox_department.ShortcutsEnabled = true;
            this.textbox_department.Size = new System.Drawing.Size(179, 23);
            this.textbox_department.TabIndex = 13;
            this.textbox_department.UseSelectable = true;
            this.textbox_department.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_department.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(175, 133);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Departamento:";
            // 
            // textbox_startWork
            // 
            this.textbox_startWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_startWork.Location = new System.Drawing.Point(398, 155);
            this.textbox_startWork.Mask = "99:99";
            this.textbox_startWork.Name = "textbox_startWork";
            this.textbox_startWork.Size = new System.Drawing.Size(179, 21);
            this.textbox_startWork.TabIndex = 14;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(398, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(129, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Inicio de expediente:";
            // 
            // textbox_endWork
            // 
            this.textbox_endWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_endWork.Location = new System.Drawing.Point(398, 283);
            this.textbox_endWork.Mask = "99:99";
            this.textbox_endWork.Name = "textbox_endWork";
            this.textbox_endWork.Size = new System.Drawing.Size(179, 21);
            this.textbox_endWork.TabIndex = 17;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(398, 261);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(121, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Fim de expediente:";
            // 
            // textbox_lunchTime
            // 
            this.textbox_lunchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_lunchTime.Location = new System.Drawing.Point(398, 222);
            this.textbox_lunchTime.Mask = "99:99";
            this.textbox_lunchTime.Name = "textbox_lunchTime";
            this.textbox_lunchTime.Size = new System.Drawing.Size(179, 21);
            this.textbox_lunchTime.TabIndex = 16;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(398, 200);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(121, 19);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Horario de almoço";
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
            this.textbox_positionWork.Lines = new string[0];
            this.textbox_positionWork.Location = new System.Drawing.Point(175, 220);
            this.textbox_positionWork.MaxLength = 32767;
            this.textbox_positionWork.Name = "textbox_positionWork";
            this.textbox_positionWork.PasswordChar = '\0';
            this.textbox_positionWork.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_positionWork.SelectedText = "";
            this.textbox_positionWork.SelectionLength = 0;
            this.textbox_positionWork.SelectionStart = 0;
            this.textbox_positionWork.ShortcutsEnabled = true;
            this.textbox_positionWork.Size = new System.Drawing.Size(179, 23);
            this.textbox_positionWork.TabIndex = 19;
            this.textbox_positionWork.UseSelectable = true;
            this.textbox_positionWork.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_positionWork.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(175, 200);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 19);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Cargo:";
            // 
            // numUpDown_PIS
            // 
            this.numUpDown_PIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_PIS.Location = new System.Drawing.Point(175, 283);
            this.numUpDown_PIS.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numUpDown_PIS.Name = "numUpDown_PIS";
            this.numUpDown_PIS.Size = new System.Drawing.Size(179, 21);
            this.numUpDown_PIS.TabIndex = 20;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(175, 261);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(30, 19);
            this.metroLabel6.TabIndex = 24;
            this.metroLabel6.Text = "PIS:";
            // 
            // AddDataWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.numUpDown_PIS);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.textbox_positionWork);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.textbox_lunchTime);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.textbox_endWork);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.textbox_startWork);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textbox_department);
            this.Name = "AddDataWork";
            this.Size = new System.Drawing.Size(812, 458);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_PIS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textbox_department;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.MaskedTextBox textbox_startWork;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.MaskedTextBox textbox_endWork;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.MaskedTextBox textbox_lunchTime;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textbox_positionWork;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.NumericUpDown numUpDown_PIS;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}
