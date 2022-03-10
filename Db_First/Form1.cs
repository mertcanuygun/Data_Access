using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Db_First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Calling an instance to be able to apply the object in my queries.
        MyDataEntities myDataBaseEntities = new MyDataEntities();

        //Simple category listing command for the database I created in SQL.
        private void btn_toList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = myDataBaseEntities.Categories.ToList();
        }

        //Listing products with category no.1 using where filter and selecting specific columns.
        private void btn_select_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = myDataBaseEntities.Products.Where(x => x.CategoryId == 1).Select(x => new { x.Product_Name, x.CategoryId, x.BrandId, x.Price, x.SupplierId }).ToList();
        }

        //Listing products with selected columns.
        private void btn_select2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = myDataBaseEntities.Products.Select(x => new { x.CategoryId, x.ProductId, x.Product_Name }).ToList();
        }

        //Listing products with category no.4 using where filter and selecting specific columns.
        private void btn_where_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = myDataBaseEntities.Products.Where(x => x.CategoryId == 4).Select(x => new { x.ProductId, x.Price, x.BrandId, x.CreateDate, x.Product_Name }).ToList();
        }

        //Finding the first category right after category no.1. I would receive an exception if the searched item wasn't found.
        private void btn_first_Click(object sender, EventArgs e)
        {
            try
            {
                Category categories = myDataBaseEntities.Categories.First(x => x.CategoryId > 1);

                MessageBox.Show($"First available category number right after 1 is { categories.CategoryId}");
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot find any category number after 1");
            }
        }

        //Finding the first product right after product no.27. I would receive the default value if the searched item wasn't found.
        private void btn_firstordefault_Click(object sender, EventArgs e)
        {
            Product products = myDataBaseEntities.Products.FirstOrDefault(x => x.ProductId > 27);

            if (products == null)
                MessageBox.Show("No such productId after 27..!");
            else
                MessageBox.Show($"CategoryID: {products.CategoryId}\nProductID:{products.ProductId}\nName: {products.Product_Name}");
        }

        //Finding a category with id no 2.
        private void btn_Find_Click(object sender, EventArgs e)
        {
            Category category = myDataBaseEntities.Categories.Find(2);

            if (category == null)
                MessageBox.Show("No such category Id..!");
            else
                MessageBox.Show($"ID:{category.CategoryId}\nName: {category.Category_Name}");
        }

        //Listing the first 7 suppliers using take method.
        private void btn_take_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = myDataBaseEntities.Suppliers.Take(7).ToList();
        }

        //Listing first 2 female employees.
        private void btn_take2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = myDataBaseEntities.Employees.Where(x => x.Gender == "female").Take(2).ToList();
        }

        //Listing employees whose names contain letter "m".
        private void btn_contains_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = myDataBaseEntities.Employees.Where(x => x.Name.Contains("m"))
                                                   .OrderBy(x => x.Name)
                                                   .Select(x => new
                                                   {
                                                       x.EmployeeId,
                                                       x.Name,
                                                       x.LastName,
                                                       x.Title
                                                   }).ToList();
        }

        //Listing employees whose names start with letter "a".
        private void btn_startswith_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = myDataBaseEntities.Employees.Where(x => x.Name.StartsWith("A"))
                                                   .Select(x => new
                                                   {
                                                       x.EmployeeId,
                                                       x.Name,
                                                       x.LastName,
                                                       x.Title
                                                   }).ToList();
        }

        //Listing products where product name ending with the letter "a".
        private void btn_endswith_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = myDataBaseEntities.Products.Where(x => x.Product_Name.EndsWith("A"))
                                                  .Select(x => new
                                                  {
                                                      x.Product_Name,
                                                      x.ProductId,
                                                      x.CategoryId,
                                                      x.Price,
                                                  }).ToList();
        }

        //Searching for a category name to check if it exist.
        private void btn_any_Click(object sender, EventArgs e)
        {
            bool result = myDataBaseEntities.Categories.Any(x => x.Category_Name == "Makarnalar");

            if (result)
                MessageBox.Show("Aradığınız kategori bulunmaktadır.");
            else
                MessageBox.Show("Aradığınız kategori bulunmamaktadır!");
        }

        //Counting the amount of products.
        private void btn_count_Click(object sender, EventArgs e)
        {
            int productCount = myDataBaseEntities.Products.Count();
            MessageBox.Show($"Count of Product: {productCount}");
        }

        //Finding the total price summation of products.
        private void btn_sum_Click(object sender, EventArgs e)
        {
            decimal? price = myDataBaseEntities.Products.Sum(x => x.Price);

            MessageBox.Show($"Stock amount is {price}");
        }
    }
}
