using swimSuitShop2.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.VisualBasic;
using Microsoft.Office.Interop.Excel;
using Button = System.Windows.Controls.Button;
using Page = System.Windows.Controls.Page;
using Microsoft.Win32;
using Microsoft.Office.Interop.Word;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Security.Policy;

namespace swimSuitShop2.VievList
{
    /// <summary>
    /// Логика взаимодействия для AddItem.xaml
    /// </summary>
    public partial class AddItem : Page
    {
        List<Classes.Product> listProducts;

        public AddItem()
        {
            InitializeComponent();

            this.DataContext = this;

            listCategory.Items.Clear();
            listCategory.ItemsSource = App.makeCategoryList();
        }

        private void ListCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            App.activeCategory = listCategory.SelectedItem.ToString();

            listProducts = new List<Classes.Product>();
            try
            {
                string cs = "data source=RODION_GETICO\\SQLEXPRESS;initial catalog=SwimSuitShop;integrated security=True";
                SqlConnection sqlConnection = new SqlConnection(cs);
                sqlConnection.Open();

                SqlDataReader dataReader = null;

                SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM product INNER JOIN  category ON product.categoryId = category.categoryId WHERE category.categoryName = '{App.activeCategory}'", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Classes.Product product = new Classes.Product();

                    product.Name = Convert.ToString(dataReader["productName"]);
                    product.Cost = Convert.ToInt32(dataReader["productCost"]);
                    product.Uid = Convert.ToString(dataReader["productId"]);
                    product.Size = Convert.ToString(dataReader["productSize"]);
                    product.Material = Convert.ToString(dataReader["productMaterial"]);
                    product.Structure = Convert.ToString(dataReader["productStructure"]);
                    product.Information = Convert.ToString(dataReader["productInformation"]);
                    try
                    {
                        string url = App.pathExe + $@"{Convert.ToString(dataReader["productPhotoUrl"])}";
                        product.Photo = App.ShowImageBit(url);
                    }
                    catch
                    {
                        string url = App.pathExe + @"/default.png";
                        product.Photo = App.ShowImageBit(url);
                    }
                    listProducts.Add(product);
                }
                listViewProducts.ItemsSource = listProducts;
                dataReader.Close();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void NewItemClick(object sender, RoutedEventArgs e)
        {
            string url = App.pathExe + $@"/photo/{App.activeCategory}/{NameItem.Text}.png";

            if (App.activeCategory != "" && UidItem.Text != "" || CostItem.Text != "" || SizeItem.Text != "" || NameItem.Text != "" || MaterialItem.Text != "" || StructureItem.Text != "" || InformationItem.Text != "")
            {
                if (File.Exists(url) != true)
                {
                    try
                    {
                        string cs = "data source=RODION_GETICO\\SQLEXPRESS;initial catalog=SwimSuitShop;integrated security=True";
                        SqlConnection sqlConnection = new SqlConnection(cs);
                        sqlConnection.Open();

                        SqlDataReader datacatid = null;
                        SqlCommand catid = new SqlCommand($"SELECT categoryId FROM category WHERE categoryName = '{App.activeCategory}'", sqlConnection);
                        datacatid = catid.ExecuteReader();
                        datacatid.Close();
                        int idcat = (Int32)catid.ExecuteScalar();


                        Classes.Product product = new Classes.Product();

                        OpenFileDialog dlg = new OpenFileDialog();
                        dlg.FileName = $"{NameItem.Text}";
                        dlg.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
                        

                        if (dlg.ShowDialog() == true)
                        {
                            File.Copy(dlg.FileName, url);
                        }
                        else
                        {
                            
                            File.Copy(App.pathExe + @"/default.png", App.pathExe + $@"/photo/{App.activeCategory}/{dlg.FileName}.png");
                        }

                        string adres = String.Format("/photo/{0}/{1}.png", App.activeCategory, NameItem.Text);

                        SqlDataReader dataReader = null;
                        SqlCommand sqlCommand = new SqlCommand($"INSERT INTO product (categoryId, productName, productCost, productSize, productMaterial, productStructure, productInformation, productPhotoUrl)" +
                            $"VALUES ({idcat},'{NameItem.Text}',{Convert.ToInt32(CostItem.Text)},'{SizeItem.Text}','{MaterialItem.Text}','{StructureItem.Text}','{InformationItem.Text}','{adres}');", sqlConnection);
                        dataReader = sqlCommand.ExecuteReader();

                        dataReader.Close();
                        sqlConnection.Close();

                        MessageBox.Show("Товар успешно добавлен");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Такой товар уже существует");
                }
                
            }
            else
            {
                MessageBox.Show("Присутствуют пустые строки");
            }
            listCategory.UpdateLayout();
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            UidItem.Text = null;
            CostItem.Text = null;
            SizeItem.Text = null;
            NameItem.Text = null;
            InformationItem.Text = null;
            MaterialItem.Text = null;
            StructureItem.Text = null;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Classes.Product product = (sender as Button).DataContext as Classes.Product;//(2)
            string name = $"Наименование:\n{product.Name}\n\nИдентификатор:\n{product.Uid}\n\nЦена:\n{product.Cost}\n\nРазмеры:\n{product.Size}\n\nМатериалы:\n{product.Material}\n\nСостав комплекта:\n{product.Structure}\n\nДополнительная информация:\n{product.Information}";
            MessageBox.Show(name);
        }

        private void Button_Click_NewList(object sender, RoutedEventArgs e)
        {
            string input = Interaction.InputBox("Введите наименование новой категории", "Добавление категории");
            try
            {
                string css = "data source=RODION_GETICO\\SQLEXPRESS;initial catalog=SwimSuitShop;integrated security=True";
                SqlConnection sqlConnection = new SqlConnection(css);
                sqlConnection.Open();

                SqlDataReader datacatid = null;
                SqlCommand catid = new SqlCommand($"INSERT INTO category (categoryName) VALUES ('{input}')", sqlConnection);
                datacatid = catid.ExecuteReader();
                datacatid.Close();

                Directory.CreateDirectory(App.pathExe + $@"/photo/{input}");
                sqlConnection.Close();
                MessageBox.Show("Категория успешно добавлена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listCategory.UpdateLayout();
        }

        private void Button_Click_DelList(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show($"Вы действительно хотите\nудалить категорию {App.activeCategory}", "Удаление категории", MessageBoxButton.YesNo);

            try
            {
                if (App.activeCategory != "" && result == MessageBoxResult.Yes)
                {
                    try
                    {
                        
                        string css = "data source=RODION_GETICO\\SQLEXPRESS;initial catalog=SwimSuitShop;integrated security=True";
                        SqlConnection sqlConnection = new SqlConnection(css);
                        sqlConnection.Open();

                        SqlDataReader datacatid = null;
                        SqlCommand itemdel = new SqlCommand($"DELETE product FROM product INNER JOIN category ON product.categoryId = category.categoryId WHERE category.categoryName = '{App.activeCategory}'", sqlConnection);
                        datacatid = itemdel.ExecuteReader();
                        datacatid.Close();
                        SqlCommand catdel = new SqlCommand($"DELETE category FROM category WHERE categoryName = '{App.activeCategory}'", sqlConnection);
                        datacatid = catdel.ExecuteReader();
                        datacatid.Close();

                        Directory.Delete(App.pathExe + $@"/photo/{App.activeCategory}", true);

                        sqlConnection.Close();

                        MessageBox.Show("Категория Удалена");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
