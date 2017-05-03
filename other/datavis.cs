using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVis
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = LoadData();
            var data = table.AsEnumerable().Select(t => new Order
            {
                OrderDate = (DateTime)t["order_date"],
                OrderTotal = (double)t["order_total"],
                CustomerID = t["customer_id"].ToString(),
                Offset = 0
            })
            .ToList()
            .OrderBy(t => t.CustomerID)
            .ThenBy(t => t.OrderDate)
            .GroupBy(t => t.CustomerID)
            .Select(t => new
            {
                CustomerID = t.Key,
                Orders = t.OrderBy(u => u.OrderDate).ToList()
            })
            .ToList();

            foreach (var item in data)
            {
                var prevDate = default(DateTime);
                foreach (var order in item.Orders)
                {
                    order.Offset = prevDate == default(DateTime) ? 0 : (order.OrderDate - prevDate).TotalDays;
                    order.Count = item.Orders.Count;
                    prevDate = order.OrderDate;
                }
            }

            var average = data
                .SelectMany(t => t.Orders)
                .Where(t => t.Offset > 0)
                .Select(t => t.Offset)
                .Average();

            using (var sw = new StreamWriter("c:\\data.csv"))
            {
                foreach (var cus in data)
                {
                    var year = cus.Orders.Sum(t => t.Offset) / 365D;
                    var amount = cus.Orders.Sum(t => t.OrderTotal);
                    var lifetime = year * amount;
                    var count = cus.Orders.Count;

                    sw.WriteLine(cus.CustomerID + "," + year + "," + amount + "," + lifetime + "," + count);
                }

                //foreach (var item in data.SelectMany(t => t.Orders))
                //{
                //    sw.WriteLine(item.CustomerID + "," + item.OrderTotal + "," + item.OrderDate.ToString("yyyy/MM/dd") + "," + item.Offset + "," + item.Count);
                //}

            }
        }


        static DataTable LoadData()
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data source=C:\db.mdb";
            try
            {
                conn.Open();
                DataTable table = new DataTable();
                OleDbCommand command = new OleDbCommand("SELECT orders.*, Customers.ID, Customers.* FROM Customers INNER JOIN orders ON Customers.[ID] = orders.[customer_id]")
                {
                    Connection = conn
                };
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                adapter.Fill(table);
                return table;
            }
            finally
            {
                conn.Close();
            }
        }

        class Order
        {
            public DateTime OrderDate { get; set; }
            public double OrderTotal { get; set; }
            public string CustomerID { get; set; }
            public double Offset { get; set; }
            public int Count { get; set; }
        }
    }
}
