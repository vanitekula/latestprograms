using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace WebApplicationWithDisConnnected
{
    public class BusinessLogic
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataSet ds;
        DataRow row;
        public BusinessLogic()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            con = new SqlConnection(cs);
            da = new SqlDataAdapter("select * from usertable", con);
            cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "usertable");
            da.Update(ds.Tables["usertable"]);
            ds.Tables["usertable"].Constraints.Add("Email_pk", ds.Tables["usertable"].Columns["EmailId"], true);
        }
        public bool RegisterUser(UserInfo info)
        {
            row = ds.Tables["usertable"].NewRow();
            row["fname"] = info.FName;
            row["lname"] = info.LName;
            row["emailid"] = info.EmailId;
            row["password"] = info.Password;
            row["imageurl"] = info.Image;
            ds.Tables["usertable"].Rows.Add(row);
            return da.Update(ds.Tables["usertable"]) == 1;
        }
        public bool DeleteUser(UserInfo info)
        {
            ds.Tables["usertable"].Rows.Find(info.EmailId).Delete();
            return da.Update(ds.Tables["usertable"]) == 1;
        }

        public bool UpdateUserinfo(UserInfo info)
        {
            row = ds.Tables["usertable"].Rows.Find(info.EmailId);
            row["fname"] = info.FName;
            row["lname"] = info.LName;
            row["password"] = info.Password;
            row["imageurl"] = info.Image;
            return da.Update(ds.Tables["usertable"]) == 1;
        }

        public UserInfo Find(string Email)
        {
            UserInfo userInfo = new UserInfo();
            row = ds.Tables["usertable"].Rows.Find(Email);
            userInfo.FName = row["fname"].ToString();
            userInfo.LName = row["lname"].ToString();
            userInfo.EmailId = row["emailid"].ToString();
            userInfo.Password = row["password"].ToString();
            userInfo.Image = row["imageurl"].ToString();
            return userInfo;

        }
        public DataSet ShowUsers()
        {
            return ds;
        }
    }


}
