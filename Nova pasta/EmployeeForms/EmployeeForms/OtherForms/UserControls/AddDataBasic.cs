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

namespace EmployeeForms.OtherForms.UserControls
{
    public partial class AddDataBasic : UserControl
    {
        public AddDataBasic()
        {
            InitializeComponent();
        }

        public string FirstName
        {
            get => textbox_name.Text;
            set => textbox_name.Text = value;
        }

        public string LastName
        {
            get => textbox_lastname.Text;
            set => textbox_lastname.Text = value;
        }

        public string Email
        {
            get => textbox_email.Text;
            set => textbox_email.Text = value;
        }

        public Int64 CPF
        {
            get => Int64.TryParse(Regex.Replace(textbox_cpf.Text, "[^0-9]", ""), out Int64 result) ? result : 0;
            set => textbox_cpf.Text = value.ToString();
        }

        public string PhoneNumber
        {
            get => textbox_phoneNumber.Text;
            set => textbox_phoneNumber.Text = value;
        }

        public DateTime DateBirth
        {
            get => dateTime_dateBirth.Value;
            set => dateTime_dateBirth.Value = value;
        }

    }
}
