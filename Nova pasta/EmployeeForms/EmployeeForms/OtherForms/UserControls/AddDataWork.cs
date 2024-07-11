using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeForms.OtherForms.UserControls
{
    public partial class AddDataWork : UserControl
    {
        public AddDataWork()
        {
            InitializeComponent();
            
        }
        public string Department { get => textbox_department.Text; 
            set => Department = value; }
        public string PositionWork { get => textbox_positionWork.Text;
            set => PositionWork = value; }
        public Int64 SocialIntegrationProgramNumber { get => numUpDown_PIS.Value == (Int64)numUpDown_PIS.Value ? 
                (Int64)numUpDown_PIS.Value : 0;
            set =>  SocialIntegrationProgramNumber = value; }
        public DateTime StartWork { get => DateTime.Parse($"{DateTime.Now.ToShortDateString()} {textbox_startWork.Text}");
            set => StartWork = value;
        }
        public DateTime LunchTime
        {
            get => DateTime.Parse($"{DateTime.Now.ToShortDateString()} {textbox_lunchTime.Text}");
            set => LunchTime = value;
        }
        public DateTime EndWork
        {
            get => DateTime.Parse($"{DateTime.Now.ToShortDateString()} {textbox_endWork.Text}");
            set => EndWork = value;
        }
    }
}
