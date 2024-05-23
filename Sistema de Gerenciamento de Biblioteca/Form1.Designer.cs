namespace Sistema_de_Gerenciamento_de_Biblioteca
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add_task = new System.Windows.Forms.Button();
            this.btn_remove_task = new System.Windows.Forms.Button();
            this.btn_save_task = new System.Windows.Forms.Button();
            this.maskedTextBox_date_addition = new System.Windows.Forms.MaskedTextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_deadLine = new System.Windows.Forms.DateTimePicker();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tarefasRealizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefasEsquecidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefasAtrasadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefasPendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasTarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 27);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(463, 411);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // textBox_desc
            // 
            this.textBox_desc.Location = new System.Drawing.Point(492, 43);
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(100, 20);
            this.textBox_desc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data de adição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prazo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status:";
            // 
            // btn_add_task
            // 
            this.btn_add_task.Location = new System.Drawing.Point(492, 414);
            this.btn_add_task.Name = "btn_add_task";
            this.btn_add_task.Size = new System.Drawing.Size(75, 23);
            this.btn_add_task.TabIndex = 9;
            this.btn_add_task.Text = "Adicionar";
            this.btn_add_task.UseVisualStyleBackColor = true;
            this.btn_add_task.Click += new System.EventHandler(this.btn_add_task_CLick);
            // 
            // btn_remove_task
            // 
            this.btn_remove_task.Location = new System.Drawing.Point(713, 414);
            this.btn_remove_task.Name = "btn_remove_task";
            this.btn_remove_task.Size = new System.Drawing.Size(75, 23);
            this.btn_remove_task.TabIndex = 10;
            this.btn_remove_task.Text = "Remover";
            this.btn_remove_task.UseVisualStyleBackColor = true;
            this.btn_remove_task.Click += new System.EventHandler(this.btn_remove_task_Click);
            // 
            // btn_save_task
            // 
            this.btn_save_task.Location = new System.Drawing.Point(573, 415);
            this.btn_save_task.Name = "btn_save_task";
            this.btn_save_task.Size = new System.Drawing.Size(75, 23);
            this.btn_save_task.TabIndex = 11;
            this.btn_save_task.Text = "Salvar";
            this.btn_save_task.UseVisualStyleBackColor = true;
            this.btn_save_task.Click += new System.EventHandler(this.btn_save_task_Click);
            // 
            // maskedTextBox_date_addition
            // 
            this.maskedTextBox_date_addition.Location = new System.Drawing.Point(619, 43);
            this.maskedTextBox_date_addition.Mask = "99/99/9999";
            this.maskedTextBox_date_addition.Name = "maskedTextBox_date_addition";
            this.maskedTextBox_date_addition.ReadOnly = true;
            this.maskedTextBox_date_addition.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_date_addition.TabIndex = 13;
            this.maskedTextBox_date_addition.Text = "00000000";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(492, 186);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Limpar tudo";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Location = new System.Drawing.Point(492, 159);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Status.TabIndex = 15;
            // 
            // dateTimePicker_deadLine
            // 
            this.dateTimePicker_deadLine.Location = new System.Drawing.Point(492, 110);
            this.dateTimePicker_deadLine.Name = "dateTimePicker_deadLine";
            this.dateTimePicker_deadLine.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_deadLine.TabIndex = 16;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(682, 186);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(106, 23);
            this.btn_refresh.TabIndex = 17;
            this.btn_refresh.Text = "Recarregar dados";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todasTarefasToolStripMenuItem,
            this.tarefasPendentesToolStripMenuItem,
            this.tarefasRealizadasToolStripMenuItem,
            this.tarefasEsquecidasToolStripMenuItem,
            this.tarefasAtrasadasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tarefasRealizadasToolStripMenuItem
            // 
            this.tarefasRealizadasToolStripMenuItem.Name = "tarefasRealizadasToolStripMenuItem";
            this.tarefasRealizadasToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.tarefasRealizadasToolStripMenuItem.Text = "Tarefas realizadas";
            this.tarefasRealizadasToolStripMenuItem.Click += new System.EventHandler(this.tarefasRealizadasToolStripMenuItem_Click);
            // 
            // tarefasEsquecidasToolStripMenuItem
            // 
            this.tarefasEsquecidasToolStripMenuItem.Name = "tarefasEsquecidasToolStripMenuItem";
            this.tarefasEsquecidasToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.tarefasEsquecidasToolStripMenuItem.Text = "Tarefas esquecidas";
            this.tarefasEsquecidasToolStripMenuItem.Click += new System.EventHandler(this.tarefasEsquecidasToolStripMenuItem_Click);
            // 
            // tarefasAtrasadasToolStripMenuItem
            // 
            this.tarefasAtrasadasToolStripMenuItem.Name = "tarefasAtrasadasToolStripMenuItem";
            this.tarefasAtrasadasToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.tarefasAtrasadasToolStripMenuItem.Text = "Tarefas atrasadas";
            this.tarefasAtrasadasToolStripMenuItem.Click += new System.EventHandler(this.tarefasAtrasadasToolStripMenuItem_Click);
            // 
            // tarefasPendentesToolStripMenuItem
            // 
            this.tarefasPendentesToolStripMenuItem.Name = "tarefasPendentesToolStripMenuItem";
            this.tarefasPendentesToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.tarefasPendentesToolStripMenuItem.Text = "Tarefas pendentes";
            this.tarefasPendentesToolStripMenuItem.Click += new System.EventHandler(this.tarefasPendentesToolStripMenuItem_Click);
            // 
            // todasTarefasToolStripMenuItem
            // 
            this.todasTarefasToolStripMenuItem.Name = "todasTarefasToolStripMenuItem";
            this.todasTarefasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.todasTarefasToolStripMenuItem.Text = "Todas tarefas";
            this.todasTarefasToolStripMenuItem.Click += new System.EventHandler(this.todasTarefasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dateTimePicker_deadLine);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.maskedTextBox_date_addition);
            this.Controls.Add(this.btn_save_task);
            this.Controls.Add(this.btn_remove_task);
            this.Controls.Add(this.btn_add_task);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_add_task;
        private System.Windows.Forms.Button btn_remove_task;
        private System.Windows.Forms.Button btn_save_task;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_date_addition;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.DateTimePicker dateTimePicker_deadLine;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tarefasRealizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarefasEsquecidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarefasAtrasadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasTarefasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarefasPendentesToolStripMenuItem;
    }
}

