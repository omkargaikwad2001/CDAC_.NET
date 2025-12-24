using System;
using System.Data;
using System.Data.SqlClient;
using MySqlConnector;

namespace P16_ADO
{
    internal class A1_Book
    {   

        public static void ReadData()
        {
            string str = "server = localhost; uid = root; pwd = root; database = dotnet";

            using (MySqlConnection con = new MySqlConnection(str))
            {
                con.Open();

                Console.WriteLine("Connected with db....");

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from book";
                cmd.CommandType = CommandType.Text;

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Console.WriteLine($"{(int)rd[0]} {(string)rd[1]} {(float)rd[2]}");
                }

                con.Close();
            }

        }

        public static void InsertData()
        {

            string str = "server = localhost; uid = root; pwd = root; database = dotnet";

            using (MySqlConnection con = new MySqlConnection(str))
            {
                con.Open();
                Console.WriteLine("Connected to db...");

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into book (name,price) values(@name,@price)";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@name", "python");
                cmd.Parameters.AddWithValue("@price", 250.00f);
                
                int res = cmd.ExecuteNonQuery();

                if (res > 0)
                {
                    Console.WriteLine("Data inserted successfully...");
                }
                else
                {
                    Console.WriteLine("Somethong went wrong...");
                }

                con.Close() ;
            }
        }

        public static void UpdateBook()
        {

            string str = "server = localhost; uid = root; pwd = root; database = dotnet";

            using (MySqlConnection con = new MySqlConnection(str))
            {
                con.Open();
                Console.WriteLine("Connected to db...");

                Console.WriteLine("Enter book id to update price");
                int bid = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter new price for book");
                float nprice = float.Parse(Console.ReadLine());

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update book set price = @nprice where bookid = @bid";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@nprice", nprice);
                cmd.Parameters.AddWithValue("@bid", bid);

                int res = cmd.ExecuteNonQuery();

                if (res > 0)
                {
                    Console.WriteLine("Data updated successfully...");
                }
                else
                {
                    Console.WriteLine("Something went wrong...");
                }
                
                con.Close();
            }

        }

        public static void DeleteBook()
        {

            string str = "server = localhost; uid = root; pwd = root; database = dotnet";

            using (MySqlConnection con = new MySqlConnection(str))
            {
                con.Open() ;
                Console.WriteLine("Connected with db...");

                Console.WriteLine("Enter bookid to delete");
                int bid = int.Parse(Console.ReadLine());

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "delete from book where bookid = @bid";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@bid",bid);

                int res = cmd.ExecuteNonQuery();

                if (res > 0) {
                    Console.WriteLine("Record deleted successfully...");
                }
                else
                {
                    Console.WriteLine("Something went wrong...");
                }

                con.Close();
            }

        }
        static void Main1(string[] args)
        {
            //ReadData();
            //InsertData();
            //UpdateBook();
            DeleteBook();
        }
    }
}
