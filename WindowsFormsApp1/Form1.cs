using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework;



namespace WindowsFormsApp1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        UControl_Lots_Management _Lots_Management;
        UControl_Products_Management _Products_Management;
        public Form1()
        {
            _Products_Management = new UControl_Products_Management();
            UControl_Department_Sales _Department_Sales = new UControl_Department_Sales();
            _Lots_Management = new UControl_Lots_Management(this);
            InitializeComponent();
            metroTabPage1.Controls.Clear();
            metroTabPage3.Controls.Clear();
            metroTabPage2.Controls.Clear();
            _Products_Management.Dock = DockStyle.Fill;
            _Lots_Management.Dock = DockStyle.Fill;
            _Department_Sales.Dock = DockStyle.Fill;
            metroTabPage1.Controls.Add(_Products_Management);
            metroTabPage2.Controls.Add(_Lots_Management);
            metroTabPage3.Controls.Add(_Department_Sales);
            PopulateCategoryes();
        }

        private void PopulateCategoryes()
        {
            string[] categoryes = {
                "Todos",
                "Alimentos",
                "Bebidas",
                "Produtos de Limpeza",
                "Higiene Pessoal",
                "Produtos para Casa",
                "Cuidados com Bebês e Crianças",
                "Outro" };
            mComboBox_categoryes.Items.AddRange(categoryes);
            mComboBox_categoryes.SelectedItem = categoryes[0];
        }

        private void mButton_refreshInv_Click(object sender, EventArgs e)
        {
            _Products_Management.RefreshDataSource();
            mButton_refreshInv.Enabled = false;
            mButton_refreshInv.Visible = false;
        }
    }
}
