using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace WF3App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            dataGridView1.AutoGenerateColumns = true;
            comboBox1.SelectedIndexChanged += ComboChange;
        }


        public void ComboChange(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = categoriesBindingSource;
                    break;
                case 1:
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = customerDemographicsBindingSource;
                    break;
                case 2:
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = customersBindingSource;
                    break;
                case 3:
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = employeesBindingSource;
                    break;
                case 4:
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = employeeTerritoriesBindingSource;
                    break;
                case 5:
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = orderDetailsBindingSource;
                    break;
                case 6:
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = ordersBindingSource;
                    break;
                case 7:
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = productsBindingSource;
                    break;
                case 8:
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = regionBindingSource;
                    break;
                case 9:
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = shippersBindingSource;
                    break;
                case 10:
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = suppliersBindingSource;
                    break;
                case 11:
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = territoriesBindingSource;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Territories". При необходимости она может быть перемещена или удалена.
            this.territoriesTableAdapter.Fill(this.dataSet1.Territories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.dataSet1.Suppliers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Shippers". При необходимости она может быть перемещена или удалена.
            this.shippersTableAdapter.Fill(this.dataSet1.Shippers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Region". При необходимости она может быть перемещена или удалена.
            this.regionTableAdapter.Fill(this.dataSet1.Region);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.dataSet1.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Order_Details". При необходимости она может быть перемещена или удалена.
            this.order_DetailsTableAdapter.Fill(this.dataSet1.Order_Details);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.EmployeeTerritories". При необходимости она может быть перемещена или удалена.
            this.employeeTerritoriesTableAdapter.Fill(this.dataSet1.EmployeeTerritories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.dataSet1.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.CustomerDemographics". При необходимости она может быть перемещена или удалена.
            this.customerDemographicsTableAdapter.Fill(this.dataSet1.CustomerDemographics);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.dataSet1.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.dataSet1.Customers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.CustomerCustomerDemo". При необходимости она может быть перемещена или удалена.
            this.customerCustomerDemoTableAdapter.Fill(this.dataSet1.CustomerCustomerDemo);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.dataSet1.Categories);

        }

        private void categoriesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    categoriesTableAdapter.Update(dataSet1);
                    break;
                case 1:
                    customerDemographicsTableAdapter.Update(dataSet1);
                    break;
                case 2:
                    customersTableAdapter.Update(dataSet1);
                    break;
                case 3:
                    employeesTableAdapter.Update(dataSet1);
                    break;
                case 4:
                    employeeTerritoriesTableAdapter.Update(dataSet1);
                    break;
                case 5:
                    order_DetailsTableAdapter.Update(dataSet1);
                    break;
                case 6:
                    ordersTableAdapter.Update(dataSet1);
                    break;
                case 7:
                    productsTableAdapter.Update(dataSet1);
                    break;
                case 8:
                    regionTableAdapter.Update(dataSet1);
                    break;
                case 9:
                    shippersTableAdapter.Update(dataSet1);
                    break;
                case 10:
                    suppliersTableAdapter.Update(dataSet1);
                    break;
                case 11:
                    territoriesTableAdapter.Update(dataSet1);
                    break;
            }
        }

        private void ToExcel()
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++) 
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToExcel();
        }
    }
}
