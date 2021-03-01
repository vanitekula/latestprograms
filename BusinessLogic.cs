using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace ApplicationExample
{

    public class BusinessLogic
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        public BusinessLogic()
        {

            con = new SqlConnection(""); //basic configratation
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Close();
        }
        public bool AddEmployee(int eid, string ename, int esal)
        {

            cmd.CommandText = string.Format($"insert into emptable values({eid},'{ename}',{esal}");
            con.Open();
            int val = cmd.ExecuteNonQuery();
            con.Close();
            return val == 1;
        }
        public bool DelEmployee(int eid)
        {

            cmd.CommandText = string.Format($"delete from emptable where eid = {eid}");
            con.Open();
            int val = cmd.ExecuteNonQuery();
            con.Close();
            return val == 1;
        }
        public bool UpdateEmployee(int eid, string ename, int esal)
        {

            cmd.CommandText = string.Format($"update emptable set ename = {ename},esal={esal} where eid = {eid}");
            con.Open();
            int val = cmd.ExecuteNonQuery();
            con.Close();
            return val == 1;
        }

        public DataTable ShowEmployees()
        {
            cmd.CommandText = "select * from emtpable";
            con.Open();
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            con.Close();
            return dt;

        }
        public string[] GetEmplyeeById(int id)
        {
            string[] res = new string[3];
            cmd.CommandText = string.Format($"select * from emptable where eid = {id}");
            con.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                res[0] = dr[0].ToString();
                res[1] = dr[1].ToString();
                res[2] = dr[2].ToString();
            }
            con.Close();
            return res;

        }
    }


}
