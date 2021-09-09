using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

namespace FetchEmployeeTableSQL
{
   public class Employee
    {
        public Dictionary<string,string> getEmpDetails(String table)
        {
            

            SqlConnection con = new SqlConnection(@"Data Source=FBD-PG0025JZ\SQLEXPRESS; Initial Catalog = test1; Persist Security Info = True; User ID =chiranth; Password =fantasy@1");
            con.Open();

            Dictionary<string, string> emp = new Dictionary<string, string>();
            if (table == null)
            {
                return emp;
            }
            //ArrayList empid = new ArrayList();
            //ArrayList empname = new ArrayList();
            //ArrayList empdept = new ArrayList();
            SqlCommand cmddd;
            try
            {
                
                cmddd = con.CreateCommand();
                cmddd.CommandType = CommandType.Text;
                cmddd.CommandText = "select emp_id, emp_name from " + table + "";
                cmddd.ExecuteNonQuery();
            }
            
            catch(Exception e)
            {
                return emp;
            }

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmddd);
            da1.Fill(dt1);

            
            foreach (DataRow dr1 in dt1.Rows)
            {
                //empid.Add(dr1["emp_id"]);
                //empname.Add(dr1["emp_name"].ToString());
                //empdept.Add(dr1["emp_dept"].ToString());

                emp.Add(dr1["emp_id"].ToString(), dr1["emp_name"].ToString());

                con.Close();
            }

            
            //for(int i = 0; i < dt1.Rows.Count; i++)
            //{
            //    Console.WriteLine("Employee {0} with employee id: {1} works at {2} dept", empname[i], empid[i], empdept[i]);
            //    Console.Write("\n");
            //}
             
            foreach(var i in emp)
            {
                Console.WriteLine(i);
            }
            
            return emp;
            
        }
    }
}
