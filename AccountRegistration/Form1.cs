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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = firstName.Text.ToString();
            StudentInfoClass.LastName = lastName.Text.ToString();   
            StudentInfoClass.MiddleName = middleName.Text.ToString();
            StudentInfoClass.Address = address.Text.ToString();
            StudentInfoClass.Program = program.Text.ToString();

            StudentInfoClass.Age = Convert.ToInt64(age.Text.ToString());
            StudentInfoClass.ContactNo = Convert.ToInt64(contactNo.Text.ToString());
            StudentInfoClass.StudentNo = Convert.ToInt64(studentNo.Text.ToString());

            FrmConfirm confirm = new FrmConfirm();
            DialogResult result = confirm.ShowDialog();

            if (result == DialogResult.OK)
            {
                firstName.Clear(); 
                lastName.Clear();
                middleName.Clear();
                address.Clear();
                program.SelectedIndex = -1;
                age.Clear();
                contactNo.Clear();
                studentNo.Clear();

            }

        }
    }
}
