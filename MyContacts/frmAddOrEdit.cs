using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class frmAddOrEdit : Form
    {
        IContactsRepository repository;
        public frmAddOrEdit()
        {
            InitializeComponent();
            repository= new ContactRepositery();
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {

        }
        
        bool validateInput()
        {
            
            if(TxtName.Text == "")
            {
                MessageBox.Show("Please enter Name","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxtLastName.Text == "")
            {
                MessageBox.Show("Please enter Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxtMobile.Text == "")
            {
                MessageBox.Show("Please enter Mobile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxtEmail.Text == "")
            {
                MessageBox.Show("Please enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            

            return true;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
              bool IsSuccess =  repository.Insert(TxtName.Text,TxtLastName.Text,TxtMobile.Text,TxtAddress.Text,TxtEmail.Text);
                if(IsSuccess == true)
                {
                    MessageBox.Show("Submit", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult =DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Not Success","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
