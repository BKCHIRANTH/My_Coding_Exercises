using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace PrintTableAndColumnNames
{
   public class PrintTableColumns
    {
        public ArrayList getTables(String db)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FBD-PG0025JZ\SQLEXPRESS; Initial Catalog ="+db+"; Persist Security Info = True; User ID =chiranth; Password =fantasy@1");
            con.Open();
            SqlCommand command = con.CreateCommand();

            ArrayList tables = new ArrayList();
            ArrayList columns = new ArrayList();
           
            DataTable dt = con.GetSchema("Tables");

            if(dt.Rows.Count == 0)
            {
                return null;
            }
            
            foreach (DataRow row in dt.Rows)
            {
                string tablename = (string)row[2];
                tables.Add(tablename);
                Console.Write("\n");
                Console.WriteLine("Table name: {0}", tablename);

                getColumns(tablename,db);
                
            }

            
            return tables;

        }

        public ArrayList getColumns(string tablename, String db)
        {
            SqlConnection con = new SqlConnection(@"Data Source=FBD-PG0025JZ\SQLEXPRESS; Initial Catalog =" + db + "; Persist Security Info = True; User ID =chiranth; Password =fantasy@1");
            con.Open();

            SqlCommand command = con.CreateCommand();
            ArrayList columns = new ArrayList();

            command.CommandText = "select c.name from sys.columns c inner join sys.tables t on t.object_id = c.object_id and t.name = '" + tablename + "' and t.type = 'U'";
            Console.WriteLine("Column names:");
            using (var reader = command.ExecuteReader())
            {
                if(reader.Read() == false)
                {
                    return null;
                }

                while (reader.Read())
                {
                    columns.Add(reader.GetString(0));

                    Console.Write(reader.GetString(0));
                    Console.Write("\n");
                }
            }

            return columns;
        }
      
    }
}
