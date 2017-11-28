using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml;

namespace CKPLLauncher
{
    class SQLConnection
    {
        public SqlConnection myConnection = new SqlConnection("Server=localhost;Database=CKPLLauncher;Trusted_Connection=True;");

        public void sqlOpen()
        {
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void sqlClose()
        {
            try
            {
                myConnection.Close();
                myConnection.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public List<String> sqlSelect(string data, string table, string where)
        {
            try
            {
                SqlDataReader myReader = null;
                SqlCommand myCommand;
                if (where == "")
                {
                    myCommand = new SqlCommand("select " + data + " from " + table, myConnection);
                } else
                {
                    myCommand = new SqlCommand("select " + data + " from " + table + " where " + where, myConnection);
                }
                myReader = myCommand.ExecuteReader();

                List<String> list = new List<String>();
                while (myReader.Read())
                {
                    list.Add(myReader["Name"].ToString());
                }
                myReader.Close();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public void sqlDownload(string saveLocation, string data, string table)
        {
            try
            {
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from " + table + " where Name='" + data + "'", myConnection);
                myReader = myCommand.ExecuteReader();
                
                using (XmlWriter writer = XmlWriter.Create(saveLocation + data + ".xml"))
                {
                    writer.WriteWhitespace("\n");
                    writer.WriteStartElement("app");
                    while (myReader.Read())
                    {
                        for (int i = 0; i < myReader.FieldCount; i++)
                        {
                            writer.WriteWhitespace("\n\t");
                            writer.WriteElementString(myReader.GetName(i), myReader.GetValue(i).ToString());
                        }
                    }
                    writer.WriteWhitespace("\n");
                    writer.WriteEndElement();
                    writer.Flush();
                }
                myReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
