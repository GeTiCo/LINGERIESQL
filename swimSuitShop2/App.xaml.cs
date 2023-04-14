using Microsoft.Office.Interop.Word;
using swimSuitShop2.DB;
using swimSuitShop2.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using Application = System.Windows.Application;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;


namespace swimSuitShop2
{
    //Вспомогательный класс
    public partial class App : Application
    {

        public static Word.Application wordApp;
        public static Word.Document wordDoc;
        public static Word.Paragraph wordPar;
        public static Word.Range wordRange;
        public static Word.Table wordTable;
        public static Word.InlineShape wordShape;

        public static string pathExe = Environment.CurrentDirectory;  //Путь к дерриктории
        public static string fileMenu = pathExe + @"/swimsuits.xlsx"; //Путь к директории + имя книги

        public static string adminLogin = "";    //Админ логин
        public static string adminPassword = ""; //Админ пароль

        public static int limitSignIn = 4;

        public static string activeCategory = "";
        public static string activeProduct = "";


        /*Формирование листа категорий: Определение экземпляра
            листа категорий товаров(1), цикл получения всех наименований листов из книги(2)*/
        public static List<string> makeCategoryList()
        {
            List<string> listCat;
            listCat = new List<string>();

            string cs = "data source=RODION_GETICO\\SQLEXPRESS;initial catalog=SwimSuitShop;integrated security=True";
            SqlConnection sqlConnection = new SqlConnection(cs);
            sqlConnection.Open();

            SqlDataReader dataReader = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT categoryName FROM category", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();


                while (dataReader.Read())
                {
                    listCat.Add(Convert.ToString(dataReader["categoryName"]));
                }
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                } 
            }

            
            return listCat;
        }



        public static BitmapImage ShowImageBit(string fileName)
        {
            BitmapImage bit = null;
            byte[] photo = File.ReadAllBytes(fileName);
            System.IO.MemoryStream strm = new System.IO.MemoryStream(photo);
            bit = new System.Windows.Media.Imaging.BitmapImage();
            bit.BeginInit();
            bit.StreamSource = strm;
            bit.EndInit();
            return bit;
        }
    }
}
