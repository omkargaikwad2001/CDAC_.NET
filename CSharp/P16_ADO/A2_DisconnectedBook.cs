using System;
using System.Data;
using MySqlConnector;

namespace P16_ADO
{
    internal class A2_DisconnectedBook
    {
        static string conStr = "server=localhost;uid=root;pwd=root;database=dotnet";

        public static void DisplayData()
        {
            using (MySqlConnection con = new MySqlConnection(conStr))
            {
                con.Open();

                MySqlCommand createCmd = new MySqlCommand(
                    @"CREATE TABLE IF NOT EXISTS book (
                        bookid INT PRIMARY KEY AUTO_INCREMENT,
                        name VARCHAR(50),
                        price FLOAT
                    )", con);

                createCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter("select * from book", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "book");

                if (ds.Tables["book"].Rows.Count == 0)
                {
                    DataRow r1 = ds.Tables["book"].NewRow();
                    r1["name"] = "C#";
                    r1["price"] = 300;
                    ds.Tables["book"].Rows.Add(r1);

                    DataRow r2 = ds.Tables["book"].NewRow();
                    r2["name"] = "Java";
                    r2["price"] = 350;
                    ds.Tables["book"].Rows.Add(r2);

                    MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                    da.Update(ds, "book");
                }

                Console.WriteLine("Book Data:");
                foreach (DataRow row in ds.Tables["book"].Rows)
                {
                    Console.WriteLine($"{row["bookid"]} {row["name"]} {row["price"]}");
                }
            }
        }

        public static void InsertBook()
        {
            using (MySqlConnection con = new MySqlConnection(conStr))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from book", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "book");

                Console.WriteLine("Enter book name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter book price:");
                float price = float.Parse(Console.ReadLine());

                DataRow row = ds.Tables["book"].NewRow();
                row["name"] = name;
                row["price"] = price;
                ds.Tables["book"].Rows.Add(row);

                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                da.Update(ds, "book");

                Console.WriteLine("Book inserted successfully (Disconnected mode).");
            }
        }

        static void Main1(string[] args)
        {
            DisplayData();
            InsertBook();
        }
    }
}
