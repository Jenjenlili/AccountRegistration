using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelContactNum, DelStudNo;
        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText (StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelContactNum = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            ProgramLabel.Text = DelProgram(StudentInfoClass.Program);
            LastNameLabel.Text = DelLastName(StudentInfoClass.LastName);
            FirstNameLabel.Text = DelFirstName(StudentInfoClass.FirstName);
            MiddleNameLabel.Text = DelMiddleName(StudentInfoClass.MiddleName);
            AddressLabel.Text = DelMiddleName(StudentInfoClass.Address);
            AgeLabel.Text = DelNumAge(StudentInfoClass.Age).ToString();
            ContactNumLabel.Text = DelContactNum(StudentInfoClass.ContactNo).ToString();
            StudentNumLabel.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();

        }        
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }        
        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
