using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsOrderAccessoriesApp
{
    public partial class Form1 : Form
    {
        public readonly OrderAccessoriesEntities orderAccessoriesEntities;
        Employee employee = new Employee();
        Order order = new Order();
        public Form1()
        {
            InitializeComponent();
            orderAccessoriesEntities = new OrderAccessoriesEntities();
        }
        
        private void btnorderdelete_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Employee_ID = int.Parse(txtempid.Text);
            employee.First_Name = txtfname.Text;
            employee.Last_Name = txtlname.Text;
            employee.Phone_Number = txtphonenum.Text;
            employee.Email = txtemail.Text;
            orderAccessoriesEntities.Employees.Add(employee);
            orderAccessoriesEntities.SaveChanges();

            MessageBox.Show("Employee is added!");
            clearempfield();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            employee.First_Name = txtfname.Text;
            employee.Last_Name = txtlname.Text;
            employee.Phone_Number = txtphonenum.Text;
            employee.Email = txtemail.Text;
            orderAccessoriesEntities.Entry(employee).State = System.Data.Entity.EntityState.Modified;
            orderAccessoriesEntities.SaveChanges();

            MessageBox.Show("Employee Updated Successfull!!");
            clearempfield();
            PopulateDataGridViewEmp();
        }

        private void btnorderadd_Click(object sender, EventArgs e)
        {
            order.Employee_ID = int.Parse(txtorderempid.Text);
            order.Product_Name = txtorderproductname.Text;
            order.Date = datetimepicker.Value;
            orderAccessoriesEntities.Orders.Add(order);
            orderAccessoriesEntities.SaveChanges();

            MessageBox.Show("Order added succesfully!!");
            clearorderfield();
        }

        void PopulateDataGridViewEmp()
        {
            dataGridViewEmployee.DataSource = orderAccessoriesEntities.Employees.ToList<Employee>();
        }

        void PopulateDataGridViewOrder()
        {
            dataGridViewOrder.DataSource = orderAccessoriesEntities.Orders.ToList<Order>();
        }

        void PopulateDataGridViewProduct()
        {
            dataGridViewProduct.DataSource = orderAccessoriesEntities.Products.ToList<Product>();
        }

        private void btnemplist_Click(object sender, EventArgs e)
        {
            PopulateDataGridViewEmp();
        }

        private void btnproductlist_Click(object sender, EventArgs e)
        {
            PopulateDataGridViewProduct();
        }

        private void btnorderlist_Click(object sender, EventArgs e)
        {
            PopulateDataGridViewOrder();
        }

        private void clearempfield()
        {
            txtempid.Clear();
            txtfname.Clear();
            txtlname.Clear();
            txtphonenum.Clear();
            txtemail.Clear();
        }

        private void clearorderfield()
        {
            txtorderempid.Clear();
            txtorderproductname.Clear();
        }

        private void dataGridViewEmployee_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.CurrentRow.Index != -1)
            {
                employee.Employee_ID = Convert.ToInt32(dataGridViewEmployee.CurrentRow.Cells["Employee_ID"].Value);

                employee = orderAccessoriesEntities.Employees.Where(x => x.Employee_ID == employee.Employee_ID).FirstOrDefault();
                txtfname.Text = employee.First_Name;
                txtlname.Text = employee.Last_Name;
                txtphonenum.Text = employee.Phone_Number;
                txtemail.Text = employee.Email;
            }
        }

        private void dataGridViewProduct_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridViewOrder_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewOrder.CurrentRow.Index != -1)
            {
                order.Employee_ID = Convert.ToInt32(dataGridViewOrder.CurrentRow.Cells["OrderEmpId"].Value);

                order = orderAccessoriesEntities.Orders.Where(x => x.Employee_ID == order.Employee_ID).FirstOrDefault();
                txtempid.Text = order.Employee_ID.ToString();
                txtproductname.Text = order.Product_Name.ToString();
            }
        }
    }
}
