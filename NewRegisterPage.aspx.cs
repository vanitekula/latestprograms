using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication37
{
    public partial class NewRegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fname = TxtFname.Text;
            string lname = TxtLname.Text;
            string gen = RblListGender.SelectedItem.Text;
            string hob = string.Empty;
            for (int i = 0; i < CheBoxListHobbies.Items.Count; i++)
            {
                if (CheBoxListHobbies.Items[i].Selected)
                {
                    hob = hob + CheBoxListHobbies.Items[i].Text;
                }
            }
            string con = TxtContact.Text;
            string address = TxtAdress.Text;
            string qual = DDLQualification.SelectedItem.Text;
            LblResult.Text = string.Format($"Name :{fname}<br>LastName :{lname}<br>Gedner :{gen}<br>Hobbies : {hob}<br>Contact number :{con}<br>Qualification : {qual}<Br>Address : {address}");



        }
    }
}