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
using CrystalDecisions.CrystalReports.Engine;
using System.Text.RegularExpressions;

namespace EligibilityProformaSystem
{
    public partial class ProductDetails : Form
    {
        DatabaseConnection dc = new DatabaseConnection();
        DataTable dt;
        public ProductDetails()
        {
            InitializeComponent();

           
        }

        private void setDatatable() {
            dt = null;
            dt = new DataTable();
            dt.Columns.Add("ProductID");
            dt.Columns.Add("ProductName");
            dt.Columns.Add("LastYearQuantity");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("WriteOff");
            dt.Columns.Add("CurrentQuantity");
        }

        bool exist = false;
        private void txtProductID_Leave(object sender, EventArgs e)
        {
            if (txtProductID.Text == "" || txtProductID.Text == " ")
            {
                MessageBox.Show("Please Enter Product ID");
                txtProductID.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtProductID.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please Enter Valid Product ID");
                txtProductID.Text = "";
                return;
            }

            if (txtProductID.Text != "")
            {
                string name = dc.chkDataExist(Convert.ToInt32(txtProductID.Text));
                if (name != null)
                {
                    txtProductName.Text = name;
                    exist = true;
                }
            }
            else
            {
                txtProductName.Text = "";
                MessageBox.Show("Enter Product ID");
            }
        }

        public bool chk;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (exist == false)
            {
                chk = true;
                dc.InsertIntoProductIDs(txtProductID.Text, txtProductName.Text, txtProductQty.Text);
            }
            else
            {
                chk = false;
            }

            if (dc.InsertIntoProductDetails(chk,txtProductID.Text, txtPurchaseYear.Text, txtProductSuplier.Text, txtBillNumber.Text, txtProductQty.Text, txtProductAmount.Text, txtTotal.Text) == 0)
            {
                ProductDataGridview.Rows.Add(txtProductID.Text.ToString(), txtProductName.Text, txtPurchaseYear.Text, txtProductSuplier.Text, txtBillNumber.Text, txtProductQty.Text, txtProductAmount.Text, txtTotal.Text);
                ClearAll();
                exist = false;
                getProductID();
                getPurchaseYear();
            }
            else
            {
                MessageBox.Show("Failed To Insert Data");
            }
            showAllProduct();
        }

        private void txtProductAmount_Leave(object sender, EventArgs e)
        {
            if (txtProductAmount.Text == "" || txtProductAmount.Text == " ")
            {
                MessageBox.Show("Please Enter Product Amount");
                txtProductAmount.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtProductAmount.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please Enter Valid Product Amount");
                txtProductAmount.Text = "";
                return;
            }
           
            if (txtProductQty.Text != "" && txtProductAmount.Text != "")
            {
                txtTotal.Text = (Convert.ToInt32(txtProductQty.Text) * Convert.ToInt32(txtProductAmount.Text)).ToString();
            }
            else
            {
                txtTotal.Text = "";
            }
        }

        public void showAllProduct()
        {
            try
            {
                dc.conn.Open();
                dc.query = new SqlCommand("select ProductIDs.ProductID,ProductIDs.ProductName,ProductDetails.ProductYear,ProductDetails.ProductSuplier,ProductDetails.BillNo,ProductDetails.Quantity,ProductDetails.Amount,ProductDetails.Total from ProductIDs inner join ProductDetails on ProductIDs.ProductID = ProductDetails.ProductID", dc.conn);
                SqlDataAdapter da = new SqlDataAdapter(dc.query);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ShowProductGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dc.conn.Close();
            }
        }

        private void ClearAll()
        {
            txtProductID.Text = txtProductName.Text = txtProductSuplier.Text = txtPurchaseYear.Text = txtBillNumber.Text = txtProductQty.Text = txtProductAmount.Text = txtTotal.Text = "";
            txtDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void getProductID()
        {
            SqlDataReader dr = null; ;
            try
            {
                dc.conn.Open();
                dc.query = new SqlCommand("select ProductID from ProductIDs", dc.conn);
                dr = dc.query.ExecuteReader();
                AutoCompleteStringCollection mycoll = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    mycoll.Add(dr.GetInt32(0).ToString());
                }
                txtProductIDInfo.AutoCompleteCustomSource = mycoll;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dc.conn.Close();
            }
        }

        private void getPurchaseYear()
        {
            SqlDataReader dr = null; ;
            try
            {
                dc.conn.Open();
                dc.query = new SqlCommand("select ProductYear from ProductDetails", dc.conn);
                dr = dc.query.ExecuteReader();
                AutoCompleteStringCollection mycoll = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    mycoll.Add(dr.GetString(0));
                }
                txtPurchaseYearInfo.AutoCompleteCustomSource = mycoll;
                txtProductPurchaseYear.AutoCompleteCustomSource = mycoll;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dc.conn.Close();
            }
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            getProductID();
            getPurchaseYear();
            txtDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void txtProductIDInfo_Leave(object sender, EventArgs e)
        {
            if (txtProductIDInfo.Text == "" || txtProductIDInfo.Text == " ")
            {
                MessageBox.Show("Please Enter Product ID");
                txtProductIDInfo.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtProductIDInfo.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please Enter Valid Product ID");
                txtProductIDInfo.Text = "";
                return;
            }

            if (txtProductIDInfo.Text != "")
            {
                try
                {
                    dc.conn.Open();
                    dc.query = new SqlCommand("select * from ProductIDs where ProductID='" + txtProductIDInfo.Text + "'", dc.conn);
                    SqlDataReader dr = dc.query.ExecuteReader();
                    if (dr.Read())
                    {
                        txtProductNameInfo.Text = dr["ProductName"].ToString();
                        txtProductQuantityInfo.Text = dr["CurrentQuantity"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    // "Data Not Found";
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dc.conn.Close();
                }
            }
            else
            {
                txtProductNameInfo.Text = "";
                txtProductQuantityInfo.Text = "";
            }
        }

        private void txtProdoctWriteOff_Leave(object sender, EventArgs e)
        {
            if (txtProdoctWriteOff.Text == "" || txtProdoctWriteOff.Text == " ")
            {
                MessageBox.Show("Please Enter Product Write Off");
                txtProdoctWriteOff.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtProdoctWriteOff.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please Enter Valid Product Write Off");
                txtProdoctWriteOff.Text = "";
                return;
            }

            if (txtProdoctWriteOff.Text != "" && txtProductQuantityInfo.Text != "")
            {
                if(!(Convert.ToInt32(txtProductQuantityInfo.Text) < Convert.ToInt32(txtProdoctWriteOff.Text)))
                {
                    txtCurrentBalance.Text = (Convert.ToInt32(txtProductQuantityInfo.Text) - Convert.ToInt32(txtProdoctWriteOff.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("Value is greater than Current Balance value");
                }
            }
            else
            {
                txtCurrentBalance.Text = "";
            }
        }

        private void ClearAllInfo()
        {
            txtProdoctWriteOff.Text = txtProductIDInfo.Text = txtProductNameInfo.Text = txtPurchaseYearInfo.Text = txtPurchaseYearInfo.Text = txtProductQuantityInfo.Text =  txtCurrentBalance.Text = "";
            txtDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void btnResetInfo_Click(object sender, EventArgs e)
        {
            ClearAllInfo();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if (dc.InsertIntoProductInfo(txtProductIDInfo.Text, txtPurchaseYearInfo.Text, txtProdoctWriteOff.Text, txtCurrentBalance.Text, txtDate.Text) == 0)
            {
                //MessageBox.Show("Data Inserted Successfully");
                ProductInfoDataGridView.Rows.Add(txtProductIDInfo.Text.ToString(), txtPurchaseYearInfo.Text.ToString(), txtProductNameInfo.Text.ToString(), txtDate.Text.ToString(), txtProductQuantityInfo.Text.ToString(), txtProdoctWriteOff.Text.ToString(), txtCurrentBalance.Text.ToString());
                ClearAllInfo();
            }
            else
            {
                MessageBox.Show("Failed To Insert Data");
            }
            showAllProduct();
        }

        private void btnSerachYearandGenerateReport_Click(object sender, EventArgs e)
        {
            string ProductName,CurrentQuantity,LastYearQuantity,PWriteoff="0",Quantity="0";
            SqlDataReader infodr=null,iddr=null,detdr=null;
            int ProductID;
            setDatatable();
            try
            {
                dc.conn.Open();
                dc.query = new SqlCommand("select * from ProductIDs",dc.conn);
                iddr = dc.query.ExecuteReader();
                while (iddr.Read())
                {
                    ProductID = Convert.ToInt32(iddr["ProductID"].ToString());
                    ProductName = iddr["ProductName"].ToString();
                    CurrentQuantity = iddr["CurrentQuantity"].ToString();
                    LastYearQuantity = iddr["LastYearQuantity"].ToString();
                    try
                    {
                        dc.query = new SqlCommand("select Quantity from ProductDetails where ProductID='" + ProductID + "' and ProductYear='" + txtProductPurchaseYear.Text + "'", dc.conn);
                        detdr = dc.query.ExecuteReader();
                        if (detdr.Read())
                        {
                            Quantity = detdr["Quantity"].ToString();
                        }
                        else
                        {
                            Quantity = "0";
                        }
                    }
                    catch (Exception ex)
                    {
                        //null;
                    }
                    finally
                    {
                        detdr.Close();
                    }
                    try
                    {
                        dc.query = new SqlCommand("select WriteOff from ProductInfo where ProductID='" + ProductID + "' and PurchaseYear='" + txtProductPurchaseYear.Text + "'", dc.conn);
                        infodr = dc.query.ExecuteReader();
                        if (infodr.Read())
                        {
                            PWriteoff = infodr["WriteOff"].ToString();
                        }
                        else
                        {
                            PWriteoff = "0";
                        }
                    }
                    catch (Exception ex)
                    {
                        //null
                    }
                    finally
                    {
                        infodr.Close();
                    }
                    dt.Rows.Add(ProductID.ToString(), ProductName, LastYearQuantity, Quantity, PWriteoff, CurrentQuantity);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dc.conn.Close();
            }

            ReportDocument rpt = new ReportDocument();
            rpt.Load(@"D:\EligibilityProformaSystem\EligibilityProformaSystem\Reports\ProductReport.rpt");
            rpt.Database.Tables["ProductInfo"].SetDataSource(dt);
            ProductReportViwer.ReportSource = rpt;
        }

        private void txtBillNumber_Leave(object sender, EventArgs e)
        {
            if (txtBillNumber.Text == "" || txtBillNumber.Text == " ")
            {
                MessageBox.Show("Please Enter Bill Number");
                txtBillNumber.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtBillNumber.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please Enter Valid Bill Number");
                txtBillNumber.Text = "";
                return;
            }
            if (txtBillNumber.Text.Length > 8)
            {
                MessageBox.Show("Bill Number should not be smaller than 8");
                txtBillNumber.Text = "";
                return;
            }
        }

        private void txtProductQty_Leave(object sender, EventArgs e)
        {
            if (txtProductQty.Text == "" || txtProductQty.Text == " ")
            {
                MessageBox.Show("Please Enter Product Quantity");
                txtProductQty.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtProductQty.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Please Enter Valid Product Quantity");
                txtProductQty.Text = "";
                return;
            }
            if (txtProductQty.Text != "" && txtProductAmount.Text != "")
            {
                txtTotal.Text = (Convert.ToInt32(txtProductQty.Text) * Convert.ToInt32(txtProductAmount.Text)).ToString();
            }
            else
            {
                txtTotal.Text = "";
            }
        }

        private void txtPurchaseYear_Leave(object sender, EventArgs e)
        {
            if (txtPurchaseYear.Text == "" || txtPurchaseYear.Text == " ")
            {
                MessageBox.Show("Please Enter Purchase Year");
                txtPurchaseYear.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtPurchaseYear.Text, @"^([0-9]{4}[- /.][0-9]{2})+$"))
            {
                MessageBox.Show("Please Enter Valid Purchase Year (2012-13)");
                txtPurchaseYear.Text = "";
                return;
            }
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtProductName.Text == " ")
            {
                MessageBox.Show("Please Enter Product Name");
                txtProductName.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtProductName.Text, @"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("Please Enter Valid Product Name");
                txtProductName.Text = "";
                return;
            }
        }

        private void txtProductSuplier_Leave(object sender, EventArgs e)
        {
            if (txtProductSuplier.Text == "" || txtProductSuplier.Text == " ")
            {
                MessageBox.Show("Please Enter Product Supplier name");
                txtProductSuplier.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtProductSuplier.Text, @"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("Please Enter Valid Product Supplier Name");
                txtProductSuplier.Text = "";
                return;
            }
        }

        private void txtPurchaseYearInfo_Leave(object sender, EventArgs e)
        {
            if (txtPurchaseYearInfo.Text == "" || txtPurchaseYearInfo.Text == " ")
            {
                MessageBox.Show("Please Enter Purchase Year");
                txtPurchaseYearInfo.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtPurchaseYearInfo.Text, @"^([0-9]{4}[- /.][0-9]{2})+$"))
            {
                MessageBox.Show("Please Enter Valid Purchase Year (2012-13)");
                txtPurchaseYearInfo.Text = "";
                return;
            }
        }

        private void txtProductPurchaseYear_Leave(object sender, EventArgs e)
        {
            if (txtProductPurchaseYear.Text == "" || txtProductPurchaseYear.Text == " ")
            {
                MessageBox.Show("Please Enter Purchase Year");
                txtProductPurchaseYear.Text = "";
                return;
            }
            if (!Regex.IsMatch(txtProductPurchaseYear.Text, @"^([0-9]{4}[- /.][0-9]{2})+$"))
            {
                MessageBox.Show("Please Enter Valid Purchase Year (2012-13)");
                txtProductPurchaseYear.Text = "";
                return;
            }
        }

    }
}
