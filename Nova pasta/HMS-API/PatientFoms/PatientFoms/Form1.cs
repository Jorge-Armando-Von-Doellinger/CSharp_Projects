using PatientFoms.Data.Entities;
using PatientFoms.OtherForms;
using PatientFoms.Services;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PatientFoms
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        List<PatientResponse> data;

        public Form1()
        {
            InitializeComponent();
            PopulateGrid();
        }

        private List<PatientResponse> Combine(List<PatientResponse> patientResponses)
        {
            foreach (var patient in patientResponses)
            {
                if (!string.IsNullOrEmpty(patient.FirstName) && !string.IsNullOrEmpty(patient.LastName))
                {
                    patient.NameCompleted = $"{patient.FirstName} {patient.LastName}";
                }
            }

            return patientResponses;
        }

        internal async void PopulateGrid()
        {
            try
            {
                data = await new PatientService().GetPatients() ?? throw new Exception("List null");
                metroGrid1.DataSource = Combine(data);
                metroGrid1.Columns["ID"].Visible = false;
                metroGrid1.Columns["FirstName"].Visible = false;
                metroGrid1.Columns["LastName"].Visible = false;
                metroGrid1.Columns["Email"].Visible = false;
                metroGrid1.Columns["CPF"].Visible = true;
                metroGrid1.Columns["CPF"].DefaultCellStyle.Format = "000\\.000\\.000\\-00";
            }
            catch
            {
                MessageBox.Show("Houve um erro ao se conectar com o servidor!");
                metroButton2.Visible = true;
                //throw;
            }
            //metroGrid1.Columns["LastName"].Visible = false;
            //metroGrid1.Columns[7].DefaultCellStyle.Format = "000\\.000\\.000-\\00";
        }
        private void PopulateGridByName()
        {
            try
            {
                metroGrid1.DataSource = Combine(data);
                metroGrid1.Columns["ID"].Visible = false;
                metroGrid1.Columns["FirstName"].Visible = false;
                metroGrid1.Columns["LastName"].Visible = false;
                metroGrid1.Columns["Email"].Visible = false;
                metroGrid1.Columns["CPF"].Visible = true;
                metroGrid1.Columns["CPF"].DefaultCellStyle.Format = "000\\.000\\.000\\-00";
            }
            catch
            {
                MessageBox.Show("Houve um erro ao se conectar com o servidor!");
                metroButton2.Visible = true;
                //throw;
            }
        }
        private void DoubleClickRow(object sender, EventArgs e)
        {
            DataGridView senderConvert = (DataGridView)sender;
            Int64 ID = Convert.ToInt64(senderConvert.SelectedRows[0].Cells[0].Value);
            new PatientSelectedManageView(data.Find(a => a.ID == ID), this).ShowDialog();
        }

        private void ButtonInsertPatient(object sender, EventArgs e)
        {
            new F_InsertPatient(this).ShowDialog();
        }

        private void RefreshGrid(object sender, EventArgs e)
        {
            metroButton2.Visible = false;
            PopulateGrid();
        }

        private async void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (metroTextBox1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Caixa de pesquisa vazia");
                    return;
                }
                if (e.KeyChar != (char)Keys.Enter)
                    return;
                string text = metroTextBox1.Text;
                string textReaplaced = text;
                Regex.Replace(textReaplaced, "[^0-9]", "");
                bool isNumber = Int64.TryParse(textReaplaced, out Int64 cpf);
                if (!isNumber)
                {
                    int index = text.IndexOf(" ");
                    if (index >= 0)
                    {
                        string name = text.Substring(0, index);

                        //name = name.Remove(index, 1);
                        name = text.Substring(0, index);
                        string lastname = text.Substring(index + 1);
                        MessageBox.Show(name);
                        MessageBox.Show(lastname);

                        data = await new PatientService().GetPatientsByNameOrLastName(name, lastname);
                        MessageBox.Show($"{data.Count} >= 0");
                        PopulateGridByName();
                    }
                    else
                    {
                        string name = metroTextBox1.Text;
                        data = await new PatientService().GetPatientsByNameOrLastName(name, "") ??
                        await new PatientService().GetPatientsByNameOrLastName("", name);

                        MessageBox.Show($"{data.Count}");
                        PopulateGridByName();

                        //data = await new PatientService().GetPatientsByNameOrLastName(name, "");
                    }
                }
                else
                {
                 //   MessageBox.Show($"a");
                    MessageBox.Show("cpf");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}

