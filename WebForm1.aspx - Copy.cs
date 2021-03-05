using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWithDisConnnected
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            if (new BusinessLogic().RegisterUser(new UserInfo(TxtFName.Text,TxtLName.Text,TxtEmail.Text,TxtPwd.Text,FileUpload1.FileName))) 
            {
                FileUpload1.SaveAs(Server.MapPath("~/" + FileUpload1.FileName));
                Label1.Text = "User Added Successfully....";
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (new BusinessLogic().UpdateUserinfo(new UserInfo(TxtFName.Text, TxtLName.Text, TxtEmail.Text, TxtPwd.Text, FileUpload1.FileName)))
            {
                Label1.Text = "User Updated Successfully....";
            }
        }

        protected void BtnDel_Click(object sender, EventArgs e)
        {
            if (new BusinessLogic().DeleteUser(new UserInfo(TxtEmail.Text)))
            {
                Label1.Text = "User Deleted Successfully....";
            }
        }

        protected void BtnShow_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void BtnFind_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new BusinessLogic().Find(TxtEmail.Text);
            TxtFName.Text = userInfo.FName;
            TxtLName.Text = userInfo.LName;
            Image1.ImageUrl ="~/"+userInfo.Image;
        }
    }
}