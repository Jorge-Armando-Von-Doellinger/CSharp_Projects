namespace WindowsFormsApp1
{
    partial class F_InsertLot
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
            this.mButton_add_lot = new MetroFramework.Controls.MetroButton();
            this.mButton_clear = new MetroFramework.Controls.MetroButton();
            this.mButton_delete_last = new MetroFramework.Controls.MetroButton();
            this.mComboBox_Category = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mTextBox_name_lot = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.nUpDown_Price_Lot = new System.Windows.Forms.NumericUpDown();
            this.nUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.nUpDown_profit_percentage = new System.Windows.Forms.NumericUpDown();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mTextBox_CodLot = new MetroFramework.Controls.MetroTextBox();
            this.maskedTextBox_expiration_date = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.mButton_scann_codBar = new MetroFramework.Controls.MetroButton();
            this.mButton_close = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBox_request = new System.Windows.Forms.CheckBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.mTextBox_brand = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.mTextBox_CodBar = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_Price_Lot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_profit_percentage)).BeginInit();
            this.SuspendLayout();
            // 
            // mButton_add_lot
            // 
            this.mButton_add_lot.Location = new System.Drawing.Point(24, 421);
            this.mButton_add_lot.Name = "mButton_add_lot";
            this.mButton_add_lot.Size = new System.Drawing.Size(107, 23);
            this.mButton_add_lot.TabIndex = 11;
            this.mButton_add_lot.Text = "Adicionar lote";
            this.mButton_add_lot.UseSelectable = true;
            this.mButton_add_lot.Click += new System.EventHandler(this.mButton_add_lot_Click);
            // 
            // mButton_clear
            // 
            this.mButton_clear.Location = new System.Drawing.Point(137, 421);
            this.mButton_clear.Name = "mButton_clear";
            this.mButton_clear.Size = new System.Drawing.Size(95, 23);
            this.mButton_clear.TabIndex = 12;
            this.mButton_clear.Text = "Limpar";
            this.mButton_clear.UseSelectable = true;
            this.mButton_clear.Click += new System.EventHandler(this.mButton_clear_Click);
            // 
            // mButton_delete_last
            // 
            this.mButton_delete_last.Location = new System.Drawing.Point(238, 421);
            this.mButton_delete_last.Name = "mButton_delete_last";
            this.mButton_delete_last.Size = new System.Drawing.Size(161, 23);
            this.mButton_delete_last.TabIndex = 13;
            this.mButton_delete_last.Text = "Deletar ultimo adicionado";
            this.mButton_delete_last.UseSelectable = true;
            this.mButton_delete_last.Click += new System.EventHandler(this.mButton_delete_last_Click);
            // 
            // mComboBox_Category
            // 
            this.mComboBox_Category.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.mComboBox_Category.FormattingEnabled = true;
            this.mComboBox_Category.ItemHeight = 19;
            this.mComboBox_Category.Location = new System.Drawing.Point(276, 100);
            this.mComboBox_Category.Name = "mComboBox_Category";
            this.mComboBox_Category.Size = new System.Drawing.Size(192, 25);
            this.mComboBox_Category.TabIndex = 6;
            this.mComboBox_Category.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(276, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Categoria:";
            // 
            // mTextBox_name_lot
            // 
            // 
            // 
            // 
            this.mTextBox_name_lot.CustomButton.Image = null;
            this.mTextBox_name_lot.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.mTextBox_name_lot.CustomButton.Name = "";
            this.mTextBox_name_lot.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextBox_name_lot.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextBox_name_lot.CustomButton.TabIndex = 1;
            this.mTextBox_name_lot.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextBox_name_lot.CustomButton.UseSelectable = true;
            this.mTextBox_name_lot.CustomButton.Visible = false;
            this.mTextBox_name_lot.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTextBox_name_lot.Lines = new string[0];
            this.mTextBox_name_lot.Location = new System.Drawing.Point(50, 100);
            this.mTextBox_name_lot.MaxLength = 32767;
            this.mTextBox_name_lot.Name = "mTextBox_name_lot";
            this.mTextBox_name_lot.PasswordChar = '\0';
            this.mTextBox_name_lot.PromptText = "Ex: Biscoito, Macarrão, etc";
            this.mTextBox_name_lot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextBox_name_lot.SelectedText = "";
            this.mTextBox_name_lot.SelectionLength = 0;
            this.mTextBox_name_lot.SelectionStart = 0;
            this.mTextBox_name_lot.ShortcutsEnabled = false;
            this.mTextBox_name_lot.Size = new System.Drawing.Size(174, 23);
            this.mTextBox_name_lot.TabIndex = 2;
            this.mTextBox_name_lot.UseSelectable = true;
            this.mTextBox_name_lot.WaterMark = "Ex: Biscoito, Macarrão, etc";
            this.mTextBox_name_lot.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextBox_name_lot.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(51, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Produtos do lote:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(51, 137);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Preço do lote:";
            // 
            // nUpDown_Price_Lot
            // 
            this.nUpDown_Price_Lot.DecimalPlaces = 2;
            this.nUpDown_Price_Lot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDown_Price_Lot.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUpDown_Price_Lot.Location = new System.Drawing.Point(52, 160);
            this.nUpDown_Price_Lot.Margin = new System.Windows.Forms.Padding(4);
            this.nUpDown_Price_Lot.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nUpDown_Price_Lot.Name = "nUpDown_Price_Lot";
            this.nUpDown_Price_Lot.Size = new System.Drawing.Size(173, 26);
            this.nUpDown_Price_Lot.TabIndex = 3;
            // 
            // nUpDown_quantity
            // 
            this.nUpDown_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDown_quantity.Location = new System.Drawing.Point(49, 295);
            this.nUpDown_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.nUpDown_quantity.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nUpDown_quantity.Name = "nUpDown_quantity";
            this.nUpDown_quantity.Size = new System.Drawing.Size(172, 26);
            this.nUpDown_quantity.TabIndex = 5;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(49, 272);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(157, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Quantidade de produtos:";
            // 
            // nUpDown_profit_percentage
            // 
            this.nUpDown_profit_percentage.DecimalPlaces = 2;
            this.nUpDown_profit_percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDown_profit_percentage.Location = new System.Drawing.Point(49, 231);
            this.nUpDown_profit_percentage.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUpDown_profit_percentage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDown_profit_percentage.Name = "nUpDown_profit_percentage";
            this.nUpDown_profit_percentage.Size = new System.Drawing.Size(172, 26);
            this.nUpDown_profit_percentage.TabIndex = 4;
            this.nUpDown_profit_percentage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(50, 208);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(142, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Porcentagem de lucro:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(540, 78);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(102, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Código do lote:";
            // 
            // mTextBox_CodLot
            // 
            // 
            // 
            // 
            this.mTextBox_CodLot.CustomButton.Image = null;
            this.mTextBox_CodLot.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.mTextBox_CodLot.CustomButton.Name = "";
            this.mTextBox_CodLot.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextBox_CodLot.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextBox_CodLot.CustomButton.TabIndex = 1;
            this.mTextBox_CodLot.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextBox_CodLot.CustomButton.UseSelectable = true;
            this.mTextBox_CodLot.CustomButton.Visible = false;
            this.mTextBox_CodLot.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTextBox_CodLot.Lines = new string[0];
            this.mTextBox_CodLot.Location = new System.Drawing.Point(539, 100);
            this.mTextBox_CodLot.MaxLength = 32767;
            this.mTextBox_CodLot.Name = "mTextBox_CodLot";
            this.mTextBox_CodLot.PasswordChar = '\0';
            this.mTextBox_CodLot.PromptText = "Ex: :2405";
            this.mTextBox_CodLot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextBox_CodLot.SelectedText = "";
            this.mTextBox_CodLot.SelectionLength = 0;
            this.mTextBox_CodLot.SelectionStart = 0;
            this.mTextBox_CodLot.ShortcutsEnabled = true;
            this.mTextBox_CodLot.Size = new System.Drawing.Size(190, 23);
            this.mTextBox_CodLot.TabIndex = 1;
            this.mTextBox_CodLot.UseSelectable = true;
            this.mTextBox_CodLot.WaterMark = "Ex: :2405";
            this.mTextBox_CodLot.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextBox_CodLot.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // maskedTextBox_expiration_date
            // 
            this.maskedTextBox_expiration_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_expiration_date.Location = new System.Drawing.Point(279, 224);
            this.maskedTextBox_expiration_date.Mask = "99/99/9999";
            this.maskedTextBox_expiration_date.Name = "maskedTextBox_expiration_date";
            this.maskedTextBox_expiration_date.Size = new System.Drawing.Size(189, 24);
            this.maskedTextBox_expiration_date.TabIndex = 8;
            this.maskedTextBox_expiration_date.Text = "00000000";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(279, 202);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(111, 19);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "Data de validade:";
            // 
            // mButton_scann_codBar
            // 
            this.mButton_scann_codBar.Location = new System.Drawing.Point(540, 251);
            this.mButton_scann_codBar.Name = "mButton_scann_codBar";
            this.mButton_scann_codBar.Size = new System.Drawing.Size(188, 29);
            this.mButton_scann_codBar.TabIndex = 9;
            this.mButton_scann_codBar.Text = "Escanear código de barras";
            this.mButton_scann_codBar.UseSelectable = true;
            this.mButton_scann_codBar.Click += new System.EventHandler(this.mButton_scann_codBar_Click);
            // 
            // mButton_close
            // 
            this.mButton_close.Location = new System.Drawing.Point(616, 421);
            this.mButton_close.Name = "mButton_close";
            this.mButton_close.Size = new System.Drawing.Size(161, 23);
            this.mButton_close.TabIndex = 14;
            this.mButton_close.Text = "Fechar";
            this.mButton_close.UseSelectable = true;
            this.mButton_close.Click += new System.EventHandler(this.mButton_close_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox_request
            // 
            this.checkBox_request.AutoSize = true;
            this.checkBox_request.Location = new System.Drawing.Point(539, 286);
            this.checkBox_request.Name = "checkBox_request";
            this.checkBox_request.Size = new System.Drawing.Size(187, 17);
            this.checkBox_request.TabIndex = 10;
            this.checkBox_request.Text = "Procurar informações pela internet";
            this.checkBox_request.UseVisualStyleBackColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(276, 142);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(131, 19);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "Marca dos produtos:";
            // 
            // mTextBox_brand
            // 
            // 
            // 
            // 
            this.mTextBox_brand.CustomButton.Image = null;
            this.mTextBox_brand.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.mTextBox_brand.CustomButton.Name = "";
            this.mTextBox_brand.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextBox_brand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextBox_brand.CustomButton.TabIndex = 1;
            this.mTextBox_brand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextBox_brand.CustomButton.UseSelectable = true;
            this.mTextBox_brand.CustomButton.Visible = false;
            this.mTextBox_brand.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTextBox_brand.Lines = new string[0];
            this.mTextBox_brand.Location = new System.Drawing.Point(276, 164);
            this.mTextBox_brand.MaxLength = 32767;
            this.mTextBox_brand.Name = "mTextBox_brand";
            this.mTextBox_brand.PasswordChar = '\0';
            this.mTextBox_brand.PromptText = "Ex: Camil, Garoto, etc";
            this.mTextBox_brand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextBox_brand.SelectedText = "";
            this.mTextBox_brand.SelectionLength = 0;
            this.mTextBox_brand.SelectionStart = 0;
            this.mTextBox_brand.ShortcutsEnabled = false;
            this.mTextBox_brand.Size = new System.Drawing.Size(192, 23);
            this.mTextBox_brand.TabIndex = 7;
            this.mTextBox_brand.UseSelectable = true;
            this.mTextBox_brand.WaterMark = "Ex: Camil, Garoto, etc";
            this.mTextBox_brand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextBox_brand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.Location = new System.Drawing.Point(539, 321);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(192, 60);
            this.metroLabel9.TabIndex = 23;
            this.metroLabel9.Text = "Obs: Para que todas funcionalidades \r\nsejam aproveitadas, escaneie \r\no codigo de " +
    "barras \r\ndo lote (GS1-128)";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(540, 202);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(167, 19);
            this.metroLabel10.TabIndex = 25;
            this.metroLabel10.Text = "Código do produto (UPN):";
            // 
            // mTextBox_CodBar
            // 
            // 
            // 
            // 
            this.mTextBox_CodBar.CustomButton.Image = null;
            this.mTextBox_CodBar.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.mTextBox_CodBar.CustomButton.Name = "";
            this.mTextBox_CodBar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextBox_CodBar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextBox_CodBar.CustomButton.TabIndex = 1;
            this.mTextBox_CodBar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextBox_CodBar.CustomButton.UseSelectable = true;
            this.mTextBox_CodBar.CustomButton.Visible = false;
            this.mTextBox_CodBar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTextBox_CodBar.Lines = new string[0];
            this.mTextBox_CodBar.Location = new System.Drawing.Point(539, 224);
            this.mTextBox_CodBar.MaxLength = 32767;
            this.mTextBox_CodBar.Name = "mTextBox_CodBar";
            this.mTextBox_CodBar.PasswordChar = '\0';
            this.mTextBox_CodBar.PromptText = "Ex: 1234567891011";
            this.mTextBox_CodBar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextBox_CodBar.SelectedText = "";
            this.mTextBox_CodBar.SelectionLength = 0;
            this.mTextBox_CodBar.SelectionStart = 0;
            this.mTextBox_CodBar.ShortcutsEnabled = true;
            this.mTextBox_CodBar.Size = new System.Drawing.Size(188, 23);
            this.mTextBox_CodBar.TabIndex = 24;
            this.mTextBox_CodBar.UseSelectable = true;
            this.mTextBox_CodBar.WaterMark = "Ex: 1234567891011";
            this.mTextBox_CodBar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextBox_CodBar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(539, 129);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(190, 27);
            this.metroButton1.TabIndex = 26;
            this.metroButton1.Text = "Escanear código de barras do lote";
            this.metroButton1.UseSelectable = true;
            // 
            // F_InsertLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.mTextBox_CodBar);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.mTextBox_brand);
            this.Controls.Add(this.checkBox_request);
            this.Controls.Add(this.mButton_close);
            this.Controls.Add(this.mButton_scann_codBar);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.maskedTextBox_expiration_date);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.mTextBox_CodLot);
            this.Controls.Add(this.nUpDown_profit_percentage);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.nUpDown_quantity);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.nUpDown_Price_Lot);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mTextBox_name_lot);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mComboBox_Category);
            this.Controls.Add(this.mButton_delete_last);
            this.Controls.Add(this.mButton_clear);
            this.Controls.Add(this.mButton_add_lot);
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "F_InsertLot";
            this.Text = "Adicionar novo lote";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_Price_Lot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_profit_percentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mButton_add_lot;
        private MetroFramework.Controls.MetroButton mButton_clear;
        private MetroFramework.Controls.MetroButton mButton_delete_last;
        private MetroFramework.Controls.MetroComboBox mComboBox_Category;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mTextBox_name_lot;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown nUpDown_Price_Lot;
        private System.Windows.Forms.NumericUpDown nUpDown_quantity;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.NumericUpDown nUpDown_profit_percentage;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox mTextBox_CodLot;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_expiration_date;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton mButton_scann_codBar;
        private MetroFramework.Controls.MetroButton mButton_close;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        internal System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBox_request;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox mTextBox_brand;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox mTextBox_CodBar;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}