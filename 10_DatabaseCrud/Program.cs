using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CRUD --> Create-Read-Update-Delete


            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****\n");
            Console.WriteLine("-------------------------------------");


            #region Kategori Ekleme İşlemi 
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-FE38PFH\\SQLEXPRESS; initial catalog=EducationCampDb; " +
            //    "integrated security = true ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Categories (CategoryName) values (@category)", connection);
            //command.Parameters.AddWithValue("@category", categoryName);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi");

            #endregion

            #region Ürün Ekleme İşlemi

            //string prodcutName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürünün adı: ");
            //prodcutName = Console.ReadLine();

            //Console.Write("Ürünün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            ////Console.Write("Ürünün durumu: ");
            ////productStatus = bool.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-FE38PFH\\SQLEXPRESS; initial catalog=EducationCampDb; " +
            //    "integrated security = true ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Products (ProductName,ProductPrice,ProductStatus) values" +
            //    " (@prodcutName,@productPrice,@productStatus)", connection);

            //command.Parameters.AddWithValue("@prodcutName", prodcutName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün başarıyla eklendi.");


            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection
            //("Data Source=DESKTOP-FE38PFH\\SQLEXPRESS; initial Catalog=EducationCampDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * from Products", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);


            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            //Console.Read();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek ürün Id: ");
            //int prodctId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FE38PFH\\SQLEXPRESS; " +
            //    "initial Catalog=EducationCampDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete from Products where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", prodctId);
            //command.ExecuteNonQuery();


            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı.");

            #endregion

            #region Ürün Güncelleme İşlemi


            //Console.Write("Güncellenecek Ürün Id: ");
            //int prodctId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FE38PFH\\SQLEXPRESS; " +
            //    "initial Catalog=EducationCampDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update Products Set ProductName=@productName, ProductPrice=@productPrice " +
            //    "where ProductId=@productId", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", prodctId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı.");

            #endregion

            Console.Read();

        }
    }
}
