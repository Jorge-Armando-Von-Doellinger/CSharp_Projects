namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.mComboBox_categoryes = new MetroFramework.Controls.MetroComboBox();
            this.mButton_refreshInv = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.HotTrack = true;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(1000, 30);
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(826, 441);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.metroTabPage1.Size = new System.Drawing.Size(818, 403);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Gerenciar produtos";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(818, 403);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Gerenciar lotes";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 4);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(818, 403);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Area de vendas";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // mComboBox_categoryes
            // 
            this.mComboBox_categoryes.FormattingEnabled = true;
            this.mComboBox_categoryes.ItemHeight = 23;
            this.mComboBox_categoryes.Location = new System.Drawing.Point(24, 29);
            this.mComboBox_categoryes.Name = "mComboBox_categoryes";
            this.mComboBox_categoryes.Size = new System.Drawing.Size(121, 29);
            this.mComboBox_categoryes.TabIndex = 1;
            this.mComboBox_categoryes.UseSelectable = true;
            // 
            // mButton_refreshInv
            // 
            this.mButton_refreshInv.AutoSize = true;
            this.mButton_refreshInv.BackColor = System.Drawing.Color.Snow;
            this.mButton_refreshInv.Enabled = false;
            this.mButton_refreshInv.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mButton_refreshInv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mButton_refreshInv.Location = new System.Drawing.Point(525, 27);
            this.mButton_refreshInv.Name = "mButton_refreshInv";
            this.mButton_refreshInv.Size = new System.Drawing.Size(147, 29);
            this.mButton_refreshInv.TabIndex = 2;
            this.mButton_refreshInv.Text = "Atualizar inventario";
            this.mButton_refreshInv.UseCustomBackColor = true;
            this.mButton_refreshInv.UseCustomForeColor = true;
            this.mButton_refreshInv.UseSelectable = true;
            this.mButton_refreshInv.Visible = false;
            this.mButton_refreshInv.Click += new System.EventHandler(this.mButton_refreshInv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(866, 521);
            this.Controls.Add(this.mButton_refreshInv);
            this.Controls.Add(this.mComboBox_categoryes);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Controle de loja";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroComboBox mComboBox_categoryes;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        public MetroFramework.Controls.MetroButton mButton_refreshInv;
    }
}

