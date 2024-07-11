namespace Gestão_Estoque
{
    partial class Form_AddLote
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
            this.metroButton_lot_add_ = new MetroFramework.Controls.MetroButton();
            this.metroCheckBox_insert_by_checkbox = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBox_lote_name = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_lote_quantity = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_lote_price = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox_lot_category = new MetroFramework.Controls.MetroComboBox();
            this.metroDateTime_lot_date_expiration = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_lot_profit_percentage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_lote_date_expiration = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroButton_clear = new MetroFramework.Controls.MetroButton();
            this.metroButton_close = new MetroFramework.Controls.MetroButton();
            this.metroCheckBox_save_configs = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton_lot_add_
            // 
            this.metroButton_lot_add_.Location = new System.Drawing.Point(59, 417);
            this.metroButton_lot_add_.Name = "metroButton_lot_add_";
            this.metroButton_lot_add_.Size = new System.Drawing.Size(108, 23);
            this.metroButton_lot_add_.TabIndex = 0;
            this.metroButton_lot_add_.Text = "Adicionar lote";
            this.metroButton_lot_add_.UseSelectable = true;
            this.metroButton_lot_add_.Click += new System.EventHandler(this.metroButton_lot_add__Click);
            // 
            // metroCheckBox_insert_by_checkbox
            // 
            this.metroCheckBox_insert_by_checkbox.AutoSize = true;
            this.metroCheckBox_insert_by_checkbox.Location = new System.Drawing.Point(315, 254);
            this.metroCheckBox_insert_by_checkbox.Name = "metroCheckBox_insert_by_checkbox";
            this.metroCheckBox_insert_by_checkbox.Size = new System.Drawing.Size(153, 15);
            this.metroCheckBox_insert_by_checkbox.TabIndex = 1;
            this.metroCheckBox_insert_by_checkbox.Text = "Inserir data pela caixinha";
            this.metroCheckBox_insert_by_checkbox.UseSelectable = true;
            this.metroCheckBox_insert_by_checkbox.CheckedChanged += new System.EventHandler(this.metroCheckBox_insert_by_checkbox_CheckedChanged);
            // 
            // metroTextBox_lote_name
            // 
            // 
            // 
            // 
            this.metroTextBox_lote_name.CustomButton.Image = null;
            this.metroTextBox_lote_name.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.metroTextBox_lote_name.CustomButton.Name = "";
            this.metroTextBox_lote_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_lote_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_lote_name.CustomButton.TabIndex = 1;
            this.metroTextBox_lote_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_lote_name.CustomButton.UseSelectable = true;
            this.metroTextBox_lote_name.CustomButton.Visible = false;
            this.metroTextBox_lote_name.Lines = new string[0];
            this.metroTextBox_lote_name.Location = new System.Drawing.Point(59, 101);
            this.metroTextBox_lote_name.MaxLength = 32767;
            this.metroTextBox_lote_name.Name = "metroTextBox_lote_name";
            this.metroTextBox_lote_name.PasswordChar = '\0';
            this.metroTextBox_lote_name.PromptText = "Ex: Biscoito, Batata, etc...";
            this.metroTextBox_lote_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_lote_name.SelectedText = "";
            this.metroTextBox_lote_name.SelectionLength = 0;
            this.metroTextBox_lote_name.SelectionStart = 0;
            this.metroTextBox_lote_name.ShortcutsEnabled = true;
            this.metroTextBox_lote_name.ShowClearButton = true;
            this.metroTextBox_lote_name.Size = new System.Drawing.Size(158, 23);
            this.metroTextBox_lote_name.TabIndex = 2;
            this.metroTextBox_lote_name.UseSelectable = true;
            this.metroTextBox_lote_name.WaterMark = "Ex: Biscoito, Batata, etc...";
            this.metroTextBox_lote_name.WaterMarkColor = System.Drawing.Color.Silver;
            this.metroTextBox_lote_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox_lote_quantity
            // 
            // 
            // 
            // 
            this.metroTextBox_lote_quantity.CustomButton.Image = null;
            this.metroTextBox_lote_quantity.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.metroTextBox_lote_quantity.CustomButton.Name = "";
            this.metroTextBox_lote_quantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_lote_quantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_lote_quantity.CustomButton.TabIndex = 1;
            this.metroTextBox_lote_quantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_lote_quantity.CustomButton.UseSelectable = true;
            this.metroTextBox_lote_quantity.CustomButton.Visible = false;
            this.metroTextBox_lote_quantity.Lines = new string[0];
            this.metroTextBox_lote_quantity.Location = new System.Drawing.Point(57, 240);
            this.metroTextBox_lote_quantity.MaxLength = 32767;
            this.metroTextBox_lote_quantity.Name = "metroTextBox_lote_quantity";
            this.metroTextBox_lote_quantity.PasswordChar = '\0';
            this.metroTextBox_lote_quantity.PromptText = "Ex: 100";
            this.metroTextBox_lote_quantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_lote_quantity.SelectedText = "";
            this.metroTextBox_lote_quantity.SelectionLength = 0;
            this.metroTextBox_lote_quantity.SelectionStart = 0;
            this.metroTextBox_lote_quantity.ShortcutsEnabled = true;
            this.metroTextBox_lote_quantity.ShowClearButton = true;
            this.metroTextBox_lote_quantity.Size = new System.Drawing.Size(160, 23);
            this.metroTextBox_lote_quantity.TabIndex = 3;
            this.metroTextBox_lote_quantity.UseSelectable = true;
            this.metroTextBox_lote_quantity.WaterMark = "Ex: 100";
            this.metroTextBox_lote_quantity.WaterMarkColor = System.Drawing.Color.Silver;
            this.metroTextBox_lote_quantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox_lote_price
            // 
            // 
            // 
            // 
            this.metroTextBox_lote_price.CustomButton.Image = null;
            this.metroTextBox_lote_price.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.metroTextBox_lote_price.CustomButton.Name = "";
            this.metroTextBox_lote_price.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_lote_price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_lote_price.CustomButton.TabIndex = 1;
            this.metroTextBox_lote_price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_lote_price.CustomButton.UseSelectable = true;
            this.metroTextBox_lote_price.CustomButton.Visible = false;
            this.metroTextBox_lote_price.Lines = new string[0];
            this.metroTextBox_lote_price.Location = new System.Drawing.Point(58, 173);
            this.metroTextBox_lote_price.MaxLength = 32767;
            this.metroTextBox_lote_price.Name = "metroTextBox_lote_price";
            this.metroTextBox_lote_price.PasswordChar = '\0';
            this.metroTextBox_lote_price.PromptText = "Ex: 99,99";
            this.metroTextBox_lote_price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_lote_price.SelectedText = "";
            this.metroTextBox_lote_price.SelectionLength = 0;
            this.metroTextBox_lote_price.SelectionStart = 0;
            this.metroTextBox_lote_price.ShortcutsEnabled = true;
            this.metroTextBox_lote_price.ShowClearButton = true;
            this.metroTextBox_lote_price.Size = new System.Drawing.Size(158, 23);
            this.metroTextBox_lote_price.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTextBox_lote_price.TabIndex = 5;
            this.metroTextBox_lote_price.UseSelectable = true;
            this.metroTextBox_lote_price.WaterMark = "Ex: 99,99";
            this.metroTextBox_lote_price.WaterMarkColor = System.Drawing.Color.Silver;
            this.metroTextBox_lote_price.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroComboBox_lot_category
            // 
            this.metroComboBox_lot_category.FormattingEnabled = true;
            this.metroComboBox_lot_category.ItemHeight = 23;
            this.metroComboBox_lot_category.Location = new System.Drawing.Point(315, 101);
            this.metroComboBox_lot_category.Name = "metroComboBox_lot_category";
            this.metroComboBox_lot_category.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox_lot_category.TabIndex = 6;
            this.metroComboBox_lot_category.UseSelectable = true;
            this.metroComboBox_lot_category.SelectedIndexChanged += new System.EventHandler(this.metroComboBox_lot_category_SelectedIndexChanged);
            // 
            // metroDateTime_lot_date_expiration
            // 
            this.metroDateTime_lot_date_expiration.Location = new System.Drawing.Point(315, 193);
            this.metroDateTime_lot_date_expiration.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime_lot_date_expiration.Name = "metroDateTime_lot_date_expiration";
            this.metroDateTime_lot_date_expiration.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime_lot_date_expiration.TabIndex = 8;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(59, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Nome do lote:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(57, 289);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(142, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Porcentagem de lucro:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(46, 220);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(157, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Quantidade de produtos:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(58, 151);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Valor do lote:";
            // 
            // metroTextBox_lot_profit_percentage
            // 
            // 
            // 
            // 
            this.metroTextBox_lot_profit_percentage.CustomButton.Image = null;
            this.metroTextBox_lot_profit_percentage.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.metroTextBox_lot_profit_percentage.CustomButton.Name = "";
            this.metroTextBox_lot_profit_percentage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_lot_profit_percentage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_lot_profit_percentage.CustomButton.TabIndex = 1;
            this.metroTextBox_lot_profit_percentage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_lot_profit_percentage.CustomButton.UseSelectable = true;
            this.metroTextBox_lot_profit_percentage.CustomButton.Visible = false;
            this.metroTextBox_lot_profit_percentage.Lines = new string[0];
            this.metroTextBox_lot_profit_percentage.Location = new System.Drawing.Point(59, 308);
            this.metroTextBox_lot_profit_percentage.MaxLength = 32767;
            this.metroTextBox_lot_profit_percentage.Name = "metroTextBox_lot_profit_percentage";
            this.metroTextBox_lot_profit_percentage.PasswordChar = '\0';
            this.metroTextBox_lot_profit_percentage.PromptText = "Ex: 20%";
            this.metroTextBox_lot_profit_percentage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_lot_profit_percentage.SelectedText = "";
            this.metroTextBox_lot_profit_percentage.SelectionLength = 0;
            this.metroTextBox_lot_profit_percentage.SelectionStart = 0;
            this.metroTextBox_lot_profit_percentage.ShortcutsEnabled = true;
            this.metroTextBox_lot_profit_percentage.ShowClearButton = true;
            this.metroTextBox_lot_profit_percentage.Size = new System.Drawing.Size(158, 23);
            this.metroTextBox_lot_profit_percentage.TabIndex = 13;
            this.metroTextBox_lot_profit_percentage.UseSelectable = true;
            this.metroTextBox_lot_profit_percentage.WaterMark = "Ex: 20%";
            this.metroTextBox_lot_profit_percentage.WaterMarkColor = System.Drawing.Color.Silver;
            this.metroTextBox_lot_profit_percentage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(315, 79);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(70, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Categoria:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(292, 51);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(0, 0);
            this.metroLabel6.TabIndex = 15;
            // 
            // metroTextBox_lote_date_expiration
            // 
            // 
            // 
            // 
            this.metroTextBox_lote_date_expiration.CustomButton.Image = null;
            this.metroTextBox_lote_date_expiration.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBox_lote_date_expiration.CustomButton.Name = "";
            this.metroTextBox_lote_date_expiration.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_lote_date_expiration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_lote_date_expiration.CustomButton.TabIndex = 1;
            this.metroTextBox_lote_date_expiration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_lote_date_expiration.CustomButton.UseSelectable = true;
            this.metroTextBox_lote_date_expiration.CustomButton.Visible = false;
            this.metroTextBox_lote_date_expiration.Lines = new string[0];
            this.metroTextBox_lote_date_expiration.Location = new System.Drawing.Point(315, 275);
            this.metroTextBox_lote_date_expiration.MaxLength = 32767;
            this.metroTextBox_lote_date_expiration.Name = "metroTextBox_lote_date_expiration";
            this.metroTextBox_lote_date_expiration.PasswordChar = '\0';
            this.metroTextBox_lote_date_expiration.PromptText = "Ex: Dia/Mês/Ano";
            this.metroTextBox_lote_date_expiration.ReadOnly = true;
            this.metroTextBox_lote_date_expiration.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_lote_date_expiration.SelectedText = "";
            this.metroTextBox_lote_date_expiration.SelectionLength = 0;
            this.metroTextBox_lote_date_expiration.SelectionStart = 0;
            this.metroTextBox_lote_date_expiration.ShortcutsEnabled = true;
            this.metroTextBox_lote_date_expiration.ShowClearButton = true;
            this.metroTextBox_lote_date_expiration.Size = new System.Drawing.Size(200, 23);
            this.metroTextBox_lote_date_expiration.TabIndex = 16;
            this.metroTextBox_lote_date_expiration.UseSelectable = true;
            this.metroTextBox_lote_date_expiration.WaterMark = "Ex: Dia/Mês/Ano";
            this.metroTextBox_lote_date_expiration.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_lote_date_expiration.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(315, 229);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(264, 19);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "Deseja inserir a data pela caixinha de texto?";
            this.metroLabel7.WrapToLine = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(315, 171);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(175, 19);
            this.metroLabel8.TabIndex = 18;
            this.metroLabel8.Text = "Data de vencimento do lote:";
            // 
            // metroButton_clear
            // 
            this.metroButton_clear.Location = new System.Drawing.Point(184, 417);
            this.metroButton_clear.Name = "metroButton_clear";
            this.metroButton_clear.Size = new System.Drawing.Size(108, 23);
            this.metroButton_clear.TabIndex = 19;
            this.metroButton_clear.Text = "Limpar tudo";
            this.metroButton_clear.UseSelectable = true;
            // 
            // metroButton_close
            // 
            this.metroButton_close.Location = new System.Drawing.Point(407, 417);
            this.metroButton_close.Name = "metroButton_close";
            this.metroButton_close.Size = new System.Drawing.Size(108, 23);
            this.metroButton_close.TabIndex = 20;
            this.metroButton_close.Text = "Fechar";
            this.metroButton_close.UseSelectable = true;
            // 
            // metroCheckBox_save_configs
            // 
            this.metroCheckBox_save_configs.AutoSize = true;
            this.metroCheckBox_save_configs.Location = new System.Drawing.Point(315, 316);
            this.metroCheckBox_save_configs.Name = "metroCheckBox_save_configs";
            this.metroCheckBox_save_configs.Size = new System.Drawing.Size(169, 15);
            this.metroCheckBox_save_configs.TabIndex = 21;
            this.metroCheckBox_save_configs.Text = "Salvar configuração de data";
            this.metroCheckBox_save_configs.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton1.BackgroundImage = global::Gestão_Estoque.Properties.Resources.icon_list3;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Location = new System.Drawing.Point(223, 101);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(25, 23);
            this.metroButton1.TabIndex = 22;
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton2.BackgroundImage = global::Gestão_Estoque.Properties.Resources.icon_list3;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton2.Location = new System.Drawing.Point(222, 173);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(25, 23);
            this.metroButton2.TabIndex = 23;
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton3.BackgroundImage = global::Gestão_Estoque.Properties.Resources.icon_list3;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton3.Location = new System.Drawing.Point(222, 240);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(25, 23);
            this.metroButton3.TabIndex = 24;
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton4.BackgroundImage = global::Gestão_Estoque.Properties.Resources.icon_list3;
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton4.Location = new System.Drawing.Point(222, 308);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(25, 23);
            this.metroButton4.TabIndex = 25;
            this.metroButton4.UseSelectable = true;
            // 
            // metroButton5
            // 
            this.metroButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton5.BackgroundImage = global::Gestão_Estoque.Properties.Resources.icon_list3;
            this.metroButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton5.Location = new System.Drawing.Point(521, 275);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(25, 23);
            this.metroButton5.TabIndex = 26;
            this.metroButton5.UseSelectable = true;
            // 
            // Form_AddLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroCheckBox_save_configs);
            this.Controls.Add(this.metroButton_close);
            this.Controls.Add(this.metroButton_clear);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroTextBox_lote_date_expiration);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTextBox_lot_profit_percentage);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroDateTime_lot_date_expiration);
            this.Controls.Add(this.metroComboBox_lot_category);
            this.Controls.Add(this.metroTextBox_lote_price);
            this.Controls.Add(this.metroTextBox_lote_quantity);
            this.Controls.Add(this.metroTextBox_lote_name);
            this.Controls.Add(this.metroCheckBox_insert_by_checkbox);
            this.Controls.Add(this.metroButton_lot_add_);
            this.Name = "Form_AddLote";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton_lot_add_;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox_insert_by_checkbox;
        private MetroFramework.Controls.MetroTextBox metroTextBox_lote_name;
        private MetroFramework.Controls.MetroTextBox metroTextBox_lote_quantity;
        private MetroFramework.Controls.MetroTextBox metroTextBox_lote_price;
        private MetroFramework.Controls.MetroComboBox metroComboBox_lot_category;
        private MetroFramework.Controls.MetroDateTime metroDateTime_lot_date_expiration;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox_lot_profit_percentage;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBox_lote_date_expiration;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton metroButton_clear;
        private MetroFramework.Controls.MetroButton metroButton_close;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox_save_configs;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
    }
}