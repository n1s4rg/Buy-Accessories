
namespace prjWinCsOrderAccessoriesApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Employee = new System.Windows.Forms.TabPage();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.dataempid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datalname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataphonenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnemplist = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtphonenum = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.phonenum = new System.Windows.Forms.Label();
            this.empid = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.TabPage();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.dataproductid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataproductname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInfo = new System.Windows.Forms.GroupBox();
            this.btnproductlist = new System.Windows.Forms.Button();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.productname = new System.Windows.Forms.Label();
            this.productid = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.TabPage();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.dataorderempid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataorderproductname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataorderdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderInfo = new System.Windows.Forms.GroupBox();
            this.btnorderdelete = new System.Windows.Forms.Button();
            this.btnorderlist = new System.Windows.Forms.Button();
            this.btnorderadd = new System.Windows.Forms.Button();
            this.datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.txtorderproductname = new System.Windows.Forms.TextBox();
            this.txtorderempid = new System.Windows.Forms.TextBox();
            this.orderdate = new System.Windows.Forms.Label();
            this.orderproductname = new System.Windows.Forms.Label();
            this.orderempid = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.empInfo.SuspendLayout();
            this.Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.productInfo.SuspendLayout();
            this.Order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.orderInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Employee);
            this.tabControl1.Controls.Add(this.Product);
            this.tabControl1.Controls.Add(this.Order);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // Employee
            // 
            this.Employee.Controls.Add(this.dataGridViewEmployee);
            this.Employee.Controls.Add(this.empInfo);
            this.Employee.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.Location = new System.Drawing.Point(4, 22);
            this.Employee.Name = "Employee";
            this.Employee.Padding = new System.Windows.Forms.Padding(3);
            this.Employee.Size = new System.Drawing.Size(792, 427);
            this.Employee.TabIndex = 0;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataempid,
            this.datafname,
            this.datalname,
            this.dataphonenum,
            this.dataemail});
            this.dataGridViewEmployee.Location = new System.Drawing.Point(14, 227);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.Size = new System.Drawing.Size(650, 138);
            this.dataGridViewEmployee.TabIndex = 9;
            this.dataGridViewEmployee.DoubleClick += new System.EventHandler(this.dataGridViewEmployee_DoubleClick);
            // 
            // dataempid
            // 
            this.dataempid.HeaderText = "Employee ID";
            this.dataempid.Name = "dataempid";
            // 
            // datafname
            // 
            this.datafname.HeaderText = "First Name";
            this.datafname.Name = "datafname";
            // 
            // datalname
            // 
            this.datalname.HeaderText = "Last Name";
            this.datalname.Name = "datalname";
            // 
            // dataphonenum
            // 
            this.dataphonenum.HeaderText = "Phone Number";
            this.dataphonenum.Name = "dataphonenum";
            // 
            // dataemail
            // 
            this.dataemail.HeaderText = "Email";
            this.dataemail.Name = "dataemail";
            // 
            // empInfo
            // 
            this.empInfo.Controls.Add(this.label1);
            this.empInfo.Controls.Add(this.btnupdate);
            this.empInfo.Controls.Add(this.btnemplist);
            this.empInfo.Controls.Add(this.btnsave);
            this.empInfo.Controls.Add(this.txtemail);
            this.empInfo.Controls.Add(this.txtphonenum);
            this.empInfo.Controls.Add(this.email);
            this.empInfo.Controls.Add(this.phonenum);
            this.empInfo.Controls.Add(this.empid);
            this.empInfo.Controls.Add(this.txtempid);
            this.empInfo.Controls.Add(this.txtlname);
            this.empInfo.Controls.Add(this.fname);
            this.empInfo.Controls.Add(this.lname);
            this.empInfo.Controls.Add(this.txtfname);
            this.empInfo.Location = new System.Drawing.Point(14, 17);
            this.empInfo.Name = "empInfo";
            this.empInfo.Size = new System.Drawing.Size(650, 165);
            this.empInfo.TabIndex = 8;
            this.empInfo.TabStop = false;
            this.empInfo.Text = "Employee Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "(4 digits)";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(548, 81);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 12;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnemplist
            // 
            this.btnemplist.Location = new System.Drawing.Point(548, 115);
            this.btnemplist.Name = "btnemplist";
            this.btnemplist.Size = new System.Drawing.Size(75, 23);
            this.btnemplist.TabIndex = 11;
            this.btnemplist.Text = "List";
            this.btnemplist.UseVisualStyleBackColor = true;
            this.btnemplist.Click += new System.EventHandler(this.btnemplist_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(548, 47);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(235, 115);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(248, 22);
            this.txtemail.TabIndex = 9;
            // 
            // txtphonenum
            // 
            this.txtphonenum.Location = new System.Drawing.Point(6, 115);
            this.txtphonenum.Name = "txtphonenum";
            this.txtphonenum.Size = new System.Drawing.Size(144, 22);
            this.txtphonenum.TabIndex = 8;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(332, 98);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(42, 14);
            this.email.TabIndex = 1;
            this.email.Text = "Email";
            // 
            // phonenum
            // 
            this.phonenum.AutoSize = true;
            this.phonenum.Location = new System.Drawing.Point(20, 98);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(91, 14);
            this.phonenum.TabIndex = 2;
            this.phonenum.Text = "Phone Number";
            // 
            // empid
            // 
            this.empid.AutoSize = true;
            this.empid.Location = new System.Drawing.Point(20, 29);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(84, 14);
            this.empid.TabIndex = 0;
            this.empid.Text = "Employee ID";
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(6, 46);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(127, 22);
            this.txtempid.TabIndex = 5;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(356, 46);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(127, 22);
            this.txtlname.TabIndex = 7;
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(206, 29);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(77, 14);
            this.fname.TabIndex = 4;
            this.fname.Text = "First Name";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(387, 29);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(70, 14);
            this.lname.TabIndex = 3;
            this.lname.Text = "Last Name";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(181, 46);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(127, 22);
            this.txtfname.TabIndex = 6;
            // 
            // Product
            // 
            this.Product.Controls.Add(this.dataGridViewProduct);
            this.Product.Controls.Add(this.productInfo);
            this.Product.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.Location = new System.Drawing.Point(4, 22);
            this.Product.Name = "Product";
            this.Product.Padding = new System.Windows.Forms.Padding(3);
            this.Product.Size = new System.Drawing.Size(792, 427);
            this.Product.TabIndex = 1;
            this.Product.Text = "Product";
            this.Product.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataproductid,
            this.dataproductname});
            this.dataGridViewProduct.Location = new System.Drawing.Point(38, 244);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(508, 150);
            this.dataGridViewProduct.TabIndex = 1;
            this.dataGridViewProduct.DoubleClick += new System.EventHandler(this.dataGridViewProduct_DoubleClick);
            // 
            // dataproductid
            // 
            this.dataproductid.HeaderText = "Product ID";
            this.dataproductid.Name = "dataproductid";
            // 
            // dataproductname
            // 
            this.dataproductname.HeaderText = "Product Name";
            this.dataproductname.Name = "dataproductname";
            // 
            // productInfo
            // 
            this.productInfo.Controls.Add(this.btnproductlist);
            this.productInfo.Controls.Add(this.txtproductname);
            this.productInfo.Controls.Add(this.txtproductid);
            this.productInfo.Controls.Add(this.productname);
            this.productInfo.Controls.Add(this.productid);
            this.productInfo.Location = new System.Drawing.Point(38, 27);
            this.productInfo.Name = "productInfo";
            this.productInfo.Size = new System.Drawing.Size(508, 173);
            this.productInfo.TabIndex = 0;
            this.productInfo.TabStop = false;
            this.productInfo.Text = "Product Information";
            // 
            // btnproductlist
            // 
            this.btnproductlist.Location = new System.Drawing.Point(409, 33);
            this.btnproductlist.Name = "btnproductlist";
            this.btnproductlist.Size = new System.Drawing.Size(75, 23);
            this.btnproductlist.TabIndex = 4;
            this.btnproductlist.Text = "List";
            this.btnproductlist.UseVisualStyleBackColor = true;
            this.btnproductlist.Click += new System.EventHandler(this.btnproductlist_Click);
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(145, 86);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(125, 22);
            this.txtproductname.TabIndex = 3;
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(145, 34);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(125, 22);
            this.txtproductid.TabIndex = 2;
            // 
            // productname
            // 
            this.productname.AutoSize = true;
            this.productname.Location = new System.Drawing.Point(29, 89);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(91, 14);
            this.productname.TabIndex = 1;
            this.productname.Text = "Product Name";
            // 
            // productid
            // 
            this.productid.AutoSize = true;
            this.productid.Location = new System.Drawing.Point(29, 37);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(77, 14);
            this.productid.TabIndex = 0;
            this.productid.Text = "Product ID";
            // 
            // Order
            // 
            this.Order.Controls.Add(this.dataGridViewOrder);
            this.Order.Controls.Add(this.orderInfo);
            this.Order.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.Location = new System.Drawing.Point(4, 22);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(792, 427);
            this.Order.TabIndex = 2;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataorderempid,
            this.dataorderproductname,
            this.dataorderdate});
            this.dataGridViewOrder.Location = new System.Drawing.Point(20, 239);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(641, 150);
            this.dataGridViewOrder.TabIndex = 1;
            this.dataGridViewOrder.DoubleClick += new System.EventHandler(this.dataGridViewOrder_DoubleClick);
            // 
            // dataorderempid
            // 
            this.dataorderempid.HeaderText = "Employee ID";
            this.dataorderempid.Name = "dataorderempid";
            // 
            // dataorderproductname
            // 
            this.dataorderproductname.HeaderText = "Product Name";
            this.dataorderproductname.Name = "dataorderproductname";
            // 
            // dataorderdate
            // 
            this.dataorderdate.HeaderText = "Date";
            this.dataorderdate.Name = "dataorderdate";
            // 
            // orderInfo
            // 
            this.orderInfo.Controls.Add(this.btnorderdelete);
            this.orderInfo.Controls.Add(this.btnorderlist);
            this.orderInfo.Controls.Add(this.btnorderadd);
            this.orderInfo.Controls.Add(this.datetimepicker);
            this.orderInfo.Controls.Add(this.txtorderproductname);
            this.orderInfo.Controls.Add(this.txtorderempid);
            this.orderInfo.Controls.Add(this.orderdate);
            this.orderInfo.Controls.Add(this.orderproductname);
            this.orderInfo.Controls.Add(this.orderempid);
            this.orderInfo.Location = new System.Drawing.Point(20, 17);
            this.orderInfo.Name = "orderInfo";
            this.orderInfo.Size = new System.Drawing.Size(641, 195);
            this.orderInfo.TabIndex = 0;
            this.orderInfo.TabStop = false;
            this.orderInfo.Text = "Order Information";
            // 
            // btnorderdelete
            // 
            this.btnorderdelete.Location = new System.Drawing.Point(543, 55);
            this.btnorderdelete.Name = "btnorderdelete";
            this.btnorderdelete.Size = new System.Drawing.Size(75, 23);
            this.btnorderdelete.TabIndex = 8;
            this.btnorderdelete.Text = "Delete";
            this.btnorderdelete.UseVisualStyleBackColor = true;
            this.btnorderdelete.Click += new System.EventHandler(this.btnorderdelete_Click);
            // 
            // btnorderlist
            // 
            this.btnorderlist.Location = new System.Drawing.Point(543, 87);
            this.btnorderlist.Name = "btnorderlist";
            this.btnorderlist.Size = new System.Drawing.Size(75, 23);
            this.btnorderlist.TabIndex = 7;
            this.btnorderlist.Text = "List";
            this.btnorderlist.UseVisualStyleBackColor = true;
            this.btnorderlist.Click += new System.EventHandler(this.btnorderlist_Click);
            // 
            // btnorderadd
            // 
            this.btnorderadd.Location = new System.Drawing.Point(543, 23);
            this.btnorderadd.Name = "btnorderadd";
            this.btnorderadd.Size = new System.Drawing.Size(75, 23);
            this.btnorderadd.TabIndex = 6;
            this.btnorderadd.Text = "Add";
            this.btnorderadd.UseVisualStyleBackColor = true;
            this.btnorderadd.Click += new System.EventHandler(this.btnorderadd_Click);
            // 
            // datetimepicker
            // 
            this.datetimepicker.Location = new System.Drawing.Point(130, 128);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(229, 22);
            this.datetimepicker.TabIndex = 5;
            // 
            // txtorderproductname
            // 
            this.txtorderproductname.Location = new System.Drawing.Point(130, 76);
            this.txtorderproductname.Name = "txtorderproductname";
            this.txtorderproductname.Size = new System.Drawing.Size(139, 22);
            this.txtorderproductname.TabIndex = 4;
            // 
            // txtorderempid
            // 
            this.txtorderempid.Location = new System.Drawing.Point(130, 29);
            this.txtorderempid.Name = "txtorderempid";
            this.txtorderempid.Size = new System.Drawing.Size(139, 22);
            this.txtorderempid.TabIndex = 3;
            // 
            // orderdate
            // 
            this.orderdate.AutoSize = true;
            this.orderdate.Location = new System.Drawing.Point(16, 128);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(35, 14);
            this.orderdate.TabIndex = 2;
            this.orderdate.Text = "Date";
            // 
            // orderproductname
            // 
            this.orderproductname.AutoSize = true;
            this.orderproductname.Location = new System.Drawing.Point(16, 79);
            this.orderproductname.Name = "orderproductname";
            this.orderproductname.Size = new System.Drawing.Size(91, 14);
            this.orderproductname.TabIndex = 1;
            this.orderproductname.Text = "Product Name";
            // 
            // orderempid
            // 
            this.orderempid.AutoSize = true;
            this.orderempid.Location = new System.Drawing.Point(16, 32);
            this.orderempid.Name = "orderempid";
            this.orderempid.Size = new System.Drawing.Size(84, 14);
            this.orderempid.TabIndex = 0;
            this.orderempid.Text = "Employee ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Computer Accessories Order Application";
            this.tabControl1.ResumeLayout(false);
            this.Employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.empInfo.ResumeLayout(false);
            this.empInfo.PerformLayout();
            this.Product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.productInfo.ResumeLayout(false);
            this.productInfo.PerformLayout();
            this.Order.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.orderInfo.ResumeLayout(false);
            this.orderInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Employee;
        private System.Windows.Forms.TabPage Product;
        private System.Windows.Forms.TabPage Order;
        private System.Windows.Forms.Label empid;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label phonenum;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.GroupBox empInfo;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtphonenum;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataempid;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafname;
        private System.Windows.Forms.DataGridViewTextBoxColumn datalname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataphonenum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnemplist;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox productInfo;
        private System.Windows.Forms.Button btnproductlist;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.Label productname;
        private System.Windows.Forms.Label productid;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataproductid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataproductname;
        private System.Windows.Forms.GroupBox orderInfo;
        private System.Windows.Forms.TextBox txtorderproductname;
        private System.Windows.Forms.TextBox txtorderempid;
        private System.Windows.Forms.Label orderdate;
        private System.Windows.Forms.Label orderproductname;
        private System.Windows.Forms.Label orderempid;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataorderempid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataorderproductname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataorderdate;
        private System.Windows.Forms.Button btnorderdelete;
        private System.Windows.Forms.Button btnorderlist;
        private System.Windows.Forms.Button btnorderadd;
        private System.Windows.Forms.DateTimePicker datetimepicker;
    }
}

