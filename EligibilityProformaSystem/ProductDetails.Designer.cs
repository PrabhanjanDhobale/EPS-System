namespace EligibilityProformaSystem
{
    partial class ProductDetails
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
            this.ProductTabControl = new System.Windows.Forms.TabControl();
            this.AddProductDetails = new System.Windows.Forms.TabPage();
            this.txtProductSuplier = new System.Windows.Forms.TextBox();
            this.lblProductSuplier = new System.Windows.Forms.Label();
            this.ProductDataGridview = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPurchaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSuplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblProductTotal = new System.Windows.Forms.Label();
            this.txtProductAmount = new System.Windows.Forms.TextBox();
            this.lblProductAmount = new System.Windows.Forms.Label();
            this.txtProductQty = new System.Windows.Forms.TextBox();
            this.lblProductQty = new System.Windows.Forms.Label();
            this.txtBillNumber = new System.Windows.Forms.TextBox();
            this.lblProductBillNumber = new System.Windows.Forms.Label();
            this.txtPurchaseYear = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ProductInfoTab = new System.Windows.Forms.TabPage();
            this.ProductInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TodaysDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WriteOff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrenBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnResetInfo = new System.Windows.Forms.Button();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.txtPurchaseYearInfo = new System.Windows.Forms.TextBox();
            this.lblInfoPurchaseYear = new System.Windows.Forms.Label();
            this.txtProductQuantityInfo = new System.Windows.Forms.TextBox();
            this.lblInfoProductQty = new System.Windows.Forms.Label();
            this.txtProdoctWriteOff = new System.Windows.Forms.TextBox();
            this.lblProductWriteOff = new System.Windows.Forms.Label();
            this.txtProductNameInfo = new System.Windows.Forms.TextBox();
            this.lblInfoProductName = new System.Windows.Forms.Label();
            this.txtProductIDInfo = new System.Windows.Forms.TextBox();
            this.lblInfoProductID = new System.Windows.Forms.Label();
            this.GenerateReport = new System.Windows.Forms.TabPage();
            this.ProductReportPanel = new System.Windows.Forms.Panel();
            this.ProductReportViwer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtProductPurchaseYear = new System.Windows.Forms.TextBox();
            this.btnSerachYearandGenerateReport = new System.Windows.Forms.Button();
            this.lblSelectProductYear = new System.Windows.Forms.Label();
            this.lbltitleOfReport = new System.Windows.Forms.Label();
            this.ShowProductInfoTab = new System.Windows.Forms.TabPage();
            this.ShowProductGridView = new System.Windows.Forms.DataGridView();
            this.ProductTabControl.SuspendLayout();
            this.AddProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridview)).BeginInit();
            this.ProductInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductInfoDataGridView)).BeginInit();
            this.GenerateReport.SuspendLayout();
            this.ProductReportPanel.SuspendLayout();
            this.ShowProductInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductTabControl
            // 
            this.ProductTabControl.Controls.Add(this.AddProductDetails);
            this.ProductTabControl.Controls.Add(this.ProductInfoTab);
            this.ProductTabControl.Controls.Add(this.GenerateReport);
            this.ProductTabControl.Controls.Add(this.ShowProductInfoTab);
            this.ProductTabControl.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTabControl.Location = new System.Drawing.Point(12, 12);
            this.ProductTabControl.Name = "ProductTabControl";
            this.ProductTabControl.SelectedIndex = 0;
            this.ProductTabControl.Size = new System.Drawing.Size(1456, 824);
            this.ProductTabControl.TabIndex = 0;
            // 
            // AddProductDetails
            // 
            this.AddProductDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.AddProductDetails.Controls.Add(this.txtProductSuplier);
            this.AddProductDetails.Controls.Add(this.lblProductSuplier);
            this.AddProductDetails.Controls.Add(this.ProductDataGridview);
            this.AddProductDetails.Controls.Add(this.btnReset);
            this.AddProductDetails.Controls.Add(this.btnSave);
            this.AddProductDetails.Controls.Add(this.txtTotal);
            this.AddProductDetails.Controls.Add(this.lblProductTotal);
            this.AddProductDetails.Controls.Add(this.txtProductAmount);
            this.AddProductDetails.Controls.Add(this.lblProductAmount);
            this.AddProductDetails.Controls.Add(this.txtProductQty);
            this.AddProductDetails.Controls.Add(this.lblProductQty);
            this.AddProductDetails.Controls.Add(this.txtBillNumber);
            this.AddProductDetails.Controls.Add(this.lblProductBillNumber);
            this.AddProductDetails.Controls.Add(this.txtPurchaseYear);
            this.AddProductDetails.Controls.Add(this.txtProductName);
            this.AddProductDetails.Controls.Add(this.lblYear);
            this.AddProductDetails.Controls.Add(this.lblProductName);
            this.AddProductDetails.Controls.Add(this.txtProductID);
            this.AddProductDetails.Controls.Add(this.lblProductID);
            this.AddProductDetails.Controls.Add(this.lblTitle);
            this.AddProductDetails.Location = new System.Drawing.Point(4, 36);
            this.AddProductDetails.Name = "AddProductDetails";
            this.AddProductDetails.Padding = new System.Windows.Forms.Padding(3);
            this.AddProductDetails.Size = new System.Drawing.Size(1448, 784);
            this.AddProductDetails.TabIndex = 0;
            this.AddProductDetails.Text = "Add Product";
            // 
            // txtProductSuplier
            // 
            this.txtProductSuplier.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSuplier.Location = new System.Drawing.Point(1021, 210);
            this.txtProductSuplier.Name = "txtProductSuplier";
            this.txtProductSuplier.Size = new System.Drawing.Size(332, 34);
            this.txtProductSuplier.TabIndex = 3;
            this.txtProductSuplier.Leave += new System.EventHandler(this.txtProductSuplier_Leave);
            // 
            // lblProductSuplier
            // 
            this.lblProductSuplier.AutoSize = true;
            this.lblProductSuplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSuplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblProductSuplier.Location = new System.Drawing.Point(739, 212);
            this.lblProductSuplier.Name = "lblProductSuplier";
            this.lblProductSuplier.Size = new System.Drawing.Size(230, 25);
            this.lblProductSuplier.TabIndex = 31;
            this.lblProductSuplier.Text = "Enter Product Suplier :";
            // 
            // ProductDataGridview
            // 
            this.ProductDataGridview.AllowUserToAddRows = false;
            this.ProductDataGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.ProductPurchaseYear,
            this.ProductSuplier,
            this.BillNo,
            this.ProductQty,
            this.ProductAmount,
            this.ProductTotal});
            this.ProductDataGridview.Location = new System.Drawing.Point(6, 591);
            this.ProductDataGridview.Name = "ProductDataGridview";
            this.ProductDataGridview.RowTemplate.Height = 24;
            this.ProductDataGridview.Size = new System.Drawing.Size(1436, 187);
            this.ProductDataGridview.TabIndex = 29;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            // 
            // ProductPurchaseYear
            // 
            this.ProductPurchaseYear.HeaderText = "ProductPurchaseYear";
            this.ProductPurchaseYear.Name = "ProductPurchaseYear";
            // 
            // ProductSuplier
            // 
            this.ProductSuplier.HeaderText = "ProductSuplier";
            this.ProductSuplier.Name = "ProductSuplier";
            // 
            // BillNo
            // 
            this.BillNo.HeaderText = "BillNo";
            this.BillNo.Name = "BillNo";
            // 
            // ProductQty
            // 
            this.ProductQty.HeaderText = "ProductQty";
            this.ProductQty.Name = "ProductQty";
            // 
            // ProductAmount
            // 
            this.ProductAmount.HeaderText = "ProductAmount";
            this.ProductAmount.Name = "ProductAmount";
            // 
            // ProductTotal
            // 
            this.ProductTotal.HeaderText = "ProductTotal";
            this.ProductTotal.Name = "ProductTotal";
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnReset.Location = new System.Drawing.Point(414, 498);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(148, 67);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSave.Location = new System.Drawing.Point(922, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 67);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1021, 395);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(332, 34);
            this.txtTotal.TabIndex = 7;
            // 
            // lblProductTotal
            // 
            this.lblProductTotal.AutoSize = true;
            this.lblProductTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblProductTotal.Location = new System.Drawing.Point(815, 397);
            this.lblProductTotal.Name = "lblProductTotal";
            this.lblProductTotal.Size = new System.Drawing.Size(154, 25);
            this.lblProductTotal.TabIndex = 25;
            this.lblProductTotal.Text = "Amount Total :";
            // 
            // txtProductAmount
            // 
            this.txtProductAmount.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductAmount.Location = new System.Drawing.Point(311, 401);
            this.txtProductAmount.Name = "txtProductAmount";
            this.txtProductAmount.Size = new System.Drawing.Size(332, 34);
            this.txtProductAmount.TabIndex = 6;
            this.txtProductAmount.Leave += new System.EventHandler(this.txtProductAmount_Leave);
            // 
            // lblProductAmount
            // 
            this.lblProductAmount.AutoSize = true;
            this.lblProductAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblProductAmount.Location = new System.Drawing.Point(31, 403);
            this.lblProductAmount.Name = "lblProductAmount";
            this.lblProductAmount.Size = new System.Drawing.Size(236, 25);
            this.lblProductAmount.TabIndex = 23;
            this.lblProductAmount.Text = "Enter Product Amount :";
            // 
            // txtProductQty
            // 
            this.txtProductQty.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductQty.Location = new System.Drawing.Point(1021, 306);
            this.txtProductQty.Name = "txtProductQty";
            this.txtProductQty.Size = new System.Drawing.Size(332, 34);
            this.txtProductQty.TabIndex = 5;
            this.txtProductQty.Leave += new System.EventHandler(this.txtProductQty_Leave);
            // 
            // lblProductQty
            // 
            this.lblProductQty.AutoSize = true;
            this.lblProductQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblProductQty.Location = new System.Drawing.Point(726, 308);
            this.lblProductQty.Name = "lblProductQty";
            this.lblProductQty.Size = new System.Drawing.Size(243, 25);
            this.lblProductQty.TabIndex = 17;
            this.lblProductQty.Text = "Enter Product Quantity :";
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNumber.Location = new System.Drawing.Point(311, 303);
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(332, 34);
            this.txtBillNumber.TabIndex = 4;
            this.txtBillNumber.Leave += new System.EventHandler(this.txtBillNumber_Leave);
            // 
            // lblProductBillNumber
            // 
            this.lblProductBillNumber.AutoSize = true;
            this.lblProductBillNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductBillNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblProductBillNumber.Location = new System.Drawing.Point(75, 305);
            this.lblProductBillNumber.Name = "lblProductBillNumber";
            this.lblProductBillNumber.Size = new System.Drawing.Size(192, 25);
            this.lblProductBillNumber.TabIndex = 21;
            this.lblProductBillNumber.Text = "Enter Bill Number :";
            // 
            // txtPurchaseYear
            // 
            this.txtPurchaseYear.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseYear.Location = new System.Drawing.Point(311, 210);
            this.txtPurchaseYear.Name = "txtPurchaseYear";
            this.txtPurchaseYear.Size = new System.Drawing.Size(332, 34);
            this.txtPurchaseYear.TabIndex = 2;
            this.txtPurchaseYear.Leave += new System.EventHandler(this.txtPurchaseYear_Leave);
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(1021, 114);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(332, 34);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.Leave += new System.EventHandler(this.txtProductName_Leave);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblYear.Location = new System.Drawing.Point(8, 212);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(259, 25);
            this.lblYear.TabIndex = 17;
            this.lblYear.Text = "Enter Year Of Purchase : ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblProductName.Location = new System.Drawing.Point(751, 116);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(218, 25);
            this.lblProductName.TabIndex = 19;
            this.lblProductName.Text = "Enter Product Name :";
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(311, 114);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(332, 34);
            this.txtProductID.TabIndex = 0;
            this.txtProductID.Leave += new System.EventHandler(this.txtProductID_Leave);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblProductID.Location = new System.Drawing.Point(84, 116);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(183, 25);
            this.lblProductID.TabIndex = 17;
            this.lblProductID.Text = "Enter Product ID :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblTitle.Location = new System.Drawing.Point(617, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 32);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "PRODUCT DETAILS";
            // 
            // ProductInfoTab
            // 
            this.ProductInfoTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ProductInfoTab.Controls.Add(this.ProductInfoDataGridView);
            this.ProductInfoTab.Controls.Add(this.btnResetInfo);
            this.ProductInfoTab.Controls.Add(this.btnSaveInfo);
            this.ProductInfoTab.Controls.Add(this.label1);
            this.ProductInfoTab.Controls.Add(this.txtDate);
            this.ProductInfoTab.Controls.Add(this.lblDate);
            this.ProductInfoTab.Controls.Add(this.txtCurrentBalance);
            this.ProductInfoTab.Controls.Add(this.lblCurrentBalance);
            this.ProductInfoTab.Controls.Add(this.txtPurchaseYearInfo);
            this.ProductInfoTab.Controls.Add(this.lblInfoPurchaseYear);
            this.ProductInfoTab.Controls.Add(this.txtProductQuantityInfo);
            this.ProductInfoTab.Controls.Add(this.lblInfoProductQty);
            this.ProductInfoTab.Controls.Add(this.txtProdoctWriteOff);
            this.ProductInfoTab.Controls.Add(this.lblProductWriteOff);
            this.ProductInfoTab.Controls.Add(this.txtProductNameInfo);
            this.ProductInfoTab.Controls.Add(this.lblInfoProductName);
            this.ProductInfoTab.Controls.Add(this.txtProductIDInfo);
            this.ProductInfoTab.Controls.Add(this.lblInfoProductID);
            this.ProductInfoTab.Location = new System.Drawing.Point(4, 36);
            this.ProductInfoTab.Name = "ProductInfoTab";
            this.ProductInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductInfoTab.Size = new System.Drawing.Size(1448, 784);
            this.ProductInfoTab.TabIndex = 1;
            this.ProductInfoTab.Text = "Product Info";
            // 
            // ProductInfoDataGridView
            // 
            this.ProductInfoDataGridView.AllowUserToAddRows = false;
            this.ProductInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_ID,
            this.Purchase_Year,
            this.Product_Name,
            this.TodaysDate,
            this.Product_Quantity,
            this.WriteOff,
            this.CurrenBalance});
            this.ProductInfoDataGridView.Location = new System.Drawing.Point(6, 535);
            this.ProductInfoDataGridView.Name = "ProductInfoDataGridView";
            this.ProductInfoDataGridView.RowTemplate.Height = 24;
            this.ProductInfoDataGridView.Size = new System.Drawing.Size(1436, 243);
            this.ProductInfoDataGridView.TabIndex = 37;
            // 
            // Product_ID
            // 
            this.Product_ID.HeaderText = "Product_ID";
            this.Product_ID.Name = "Product_ID";
            // 
            // Purchase_Year
            // 
            this.Purchase_Year.HeaderText = "Purchase_Year";
            this.Purchase_Year.Name = "Purchase_Year";
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Product_Name";
            this.Product_Name.Name = "Product_Name";
            // 
            // TodaysDate
            // 
            this.TodaysDate.HeaderText = "TodaysDate";
            this.TodaysDate.Name = "TodaysDate";
            // 
            // Product_Quantity
            // 
            this.Product_Quantity.HeaderText = "Product_Quantity";
            this.Product_Quantity.Name = "Product_Quantity";
            // 
            // WriteOff
            // 
            this.WriteOff.HeaderText = "WriteOff";
            this.WriteOff.Name = "WriteOff";
            // 
            // CurrenBalance
            // 
            this.CurrenBalance.HeaderText = "CurrenBalance";
            this.CurrenBalance.Name = "CurrenBalance";
            // 
            // btnResetInfo
            // 
            this.btnResetInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnResetInfo.Location = new System.Drawing.Point(63, 428);
            this.btnResetInfo.Name = "btnResetInfo";
            this.btnResetInfo.Size = new System.Drawing.Size(148, 67);
            this.btnResetInfo.TabIndex = 8;
            this.btnResetInfo.Text = "Reset";
            this.btnResetInfo.UseVisualStyleBackColor = true;
            this.btnResetInfo.Click += new System.EventHandler(this.btnResetInfo_Click);
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSaveInfo.Location = new System.Drawing.Point(571, 428);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(148, 67);
            this.btnSaveInfo.TabIndex = 7;
            this.btnSaveInfo.Text = "Save";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(398, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "PRODUCT WRITE OFF AND CURRENT BALANCE";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(1023, 225);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(332, 34);
            this.txtDate.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblDate.Location = new System.Drawing.Point(821, 227);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(153, 25);
            this.lblDate.TabIndex = 35;
            this.lblDate.Text = "Today\'s Date :";
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.Enabled = false;
            this.txtCurrentBalance.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentBalance.Location = new System.Drawing.Point(1023, 444);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.Size = new System.Drawing.Size(332, 34);
            this.txtCurrentBalance.TabIndex = 6;
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblCurrentBalance.Location = new System.Drawing.Point(793, 446);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(181, 25);
            this.lblCurrentBalance.TabIndex = 31;
            this.lblCurrentBalance.Text = "Current Balance :";
            // 
            // txtPurchaseYearInfo
            // 
            this.txtPurchaseYearInfo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPurchaseYearInfo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPurchaseYearInfo.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseYearInfo.Location = new System.Drawing.Point(1023, 123);
            this.txtPurchaseYearInfo.Name = "txtPurchaseYearInfo";
            this.txtPurchaseYearInfo.Size = new System.Drawing.Size(332, 34);
            this.txtPurchaseYearInfo.TabIndex = 1;
            this.txtPurchaseYearInfo.Leave += new System.EventHandler(this.txtPurchaseYearInfo_Leave);
            // 
            // lblInfoPurchaseYear
            // 
            this.lblInfoPurchaseYear.AutoSize = true;
            this.lblInfoPurchaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPurchaseYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblInfoPurchaseYear.Location = new System.Drawing.Point(772, 125);
            this.lblInfoPurchaseYear.Name = "lblInfoPurchaseYear";
            this.lblInfoPurchaseYear.Size = new System.Drawing.Size(202, 25);
            this.lblInfoPurchaseYear.TabIndex = 29;
            this.lblInfoPurchaseYear.Text = "Year Of Purchase : ";
            // 
            // txtProductQuantityInfo
            // 
            this.txtProductQuantityInfo.Enabled = false;
            this.txtProductQuantityInfo.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductQuantityInfo.Location = new System.Drawing.Point(262, 339);
            this.txtProductQuantityInfo.Name = "txtProductQuantityInfo";
            this.txtProductQuantityInfo.Size = new System.Drawing.Size(332, 34);
            this.txtProductQuantityInfo.TabIndex = 4;
            // 
            // lblInfoProductQty
            // 
            this.lblInfoProductQty.AutoSize = true;
            this.lblInfoProductQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoProductQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblInfoProductQty.Location = new System.Drawing.Point(33, 342);
            this.lblInfoProductQty.Name = "lblInfoProductQty";
            this.lblInfoProductQty.Size = new System.Drawing.Size(186, 25);
            this.lblInfoProductQty.TabIndex = 27;
            this.lblInfoProductQty.Text = "Product Quantity :";
            // 
            // txtProdoctWriteOff
            // 
            this.txtProdoctWriteOff.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdoctWriteOff.Location = new System.Drawing.Point(1023, 332);
            this.txtProdoctWriteOff.Name = "txtProdoctWriteOff";
            this.txtProdoctWriteOff.Size = new System.Drawing.Size(332, 34);
            this.txtProdoctWriteOff.TabIndex = 5;
            this.txtProdoctWriteOff.Leave += new System.EventHandler(this.txtProdoctWriteOff_Leave);
            // 
            // lblProductWriteOff
            // 
            this.lblProductWriteOff.AutoSize = true;
            this.lblProductWriteOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductWriteOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblProductWriteOff.Location = new System.Drawing.Point(800, 334);
            this.lblProductWriteOff.Name = "lblProductWriteOff";
            this.lblProductWriteOff.Size = new System.Drawing.Size(174, 25);
            this.lblProductWriteOff.TabIndex = 25;
            this.lblProductWriteOff.Text = "Enter Write Off : ";
            // 
            // txtProductNameInfo
            // 
            this.txtProductNameInfo.Enabled = false;
            this.txtProductNameInfo.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductNameInfo.Location = new System.Drawing.Point(262, 228);
            this.txtProductNameInfo.Name = "txtProductNameInfo";
            this.txtProductNameInfo.Size = new System.Drawing.Size(332, 34);
            this.txtProductNameInfo.TabIndex = 2;
            // 
            // lblInfoProductName
            // 
            this.lblInfoProductName.AutoSize = true;
            this.lblInfoProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblInfoProductName.Location = new System.Drawing.Point(58, 231);
            this.lblInfoProductName.Name = "lblInfoProductName";
            this.lblInfoProductName.Size = new System.Drawing.Size(161, 25);
            this.lblInfoProductName.TabIndex = 21;
            this.lblInfoProductName.Text = "Product Name :";
            // 
            // txtProductIDInfo
            // 
            this.txtProductIDInfo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProductIDInfo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProductIDInfo.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductIDInfo.Location = new System.Drawing.Point(262, 121);
            this.txtProductIDInfo.Name = "txtProductIDInfo";
            this.txtProductIDInfo.Size = new System.Drawing.Size(332, 34);
            this.txtProductIDInfo.TabIndex = 0;
            this.txtProductIDInfo.Leave += new System.EventHandler(this.txtProductIDInfo_Leave);
            // 
            // lblInfoProductID
            // 
            this.lblInfoProductID.AutoSize = true;
            this.lblInfoProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblInfoProductID.Location = new System.Drawing.Point(36, 124);
            this.lblInfoProductID.Name = "lblInfoProductID";
            this.lblInfoProductID.Size = new System.Drawing.Size(183, 25);
            this.lblInfoProductID.TabIndex = 19;
            this.lblInfoProductID.Text = "Enter Product ID :";
            // 
            // GenerateReport
            // 
            this.GenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.GenerateReport.Controls.Add(this.ProductReportPanel);
            this.GenerateReport.Controls.Add(this.txtProductPurchaseYear);
            this.GenerateReport.Controls.Add(this.btnSerachYearandGenerateReport);
            this.GenerateReport.Controls.Add(this.lblSelectProductYear);
            this.GenerateReport.Controls.Add(this.lbltitleOfReport);
            this.GenerateReport.Location = new System.Drawing.Point(4, 36);
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Padding = new System.Windows.Forms.Padding(3);
            this.GenerateReport.Size = new System.Drawing.Size(1448, 784);
            this.GenerateReport.TabIndex = 2;
            this.GenerateReport.Text = "Generate Report";
            // 
            // ProductReportPanel
            // 
            this.ProductReportPanel.Controls.Add(this.ProductReportViwer);
            this.ProductReportPanel.Location = new System.Drawing.Point(6, 190);
            this.ProductReportPanel.Name = "ProductReportPanel";
            this.ProductReportPanel.Size = new System.Drawing.Size(1426, 584);
            this.ProductReportPanel.TabIndex = 28;
            // 
            // ProductReportViwer
            // 
            this.ProductReportViwer.ActiveViewIndex = -1;
            this.ProductReportViwer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductReportViwer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductReportViwer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductReportViwer.Location = new System.Drawing.Point(0, 0);
            this.ProductReportViwer.Name = "ProductReportViwer";
            this.ProductReportViwer.Size = new System.Drawing.Size(1426, 584);
            this.ProductReportViwer.TabIndex = 0;
            this.ProductReportViwer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // txtProductPurchaseYear
            // 
            this.txtProductPurchaseYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProductPurchaseYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProductPurchaseYear.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPurchaseYear.Location = new System.Drawing.Point(487, 116);
            this.txtProductPurchaseYear.Name = "txtProductPurchaseYear";
            this.txtProductPurchaseYear.Size = new System.Drawing.Size(332, 34);
            this.txtProductPurchaseYear.TabIndex = 27;
            this.txtProductPurchaseYear.Leave += new System.EventHandler(this.txtProductPurchaseYear_Leave);
            // 
            // btnSerachYearandGenerateReport
            // 
            this.btnSerachYearandGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerachYearandGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerachYearandGenerateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSerachYearandGenerateReport.Location = new System.Drawing.Point(1119, 96);
            this.btnSerachYearandGenerateReport.Name = "btnSerachYearandGenerateReport";
            this.btnSerachYearandGenerateReport.Size = new System.Drawing.Size(247, 67);
            this.btnSerachYearandGenerateReport.TabIndex = 26;
            this.btnSerachYearandGenerateReport.Text = "Generate Report";
            this.btnSerachYearandGenerateReport.UseVisualStyleBackColor = true;
            this.btnSerachYearandGenerateReport.Click += new System.EventHandler(this.btnSerachYearandGenerateReport_Click);
            // 
            // lblSelectProductYear
            // 
            this.lblSelectProductYear.AutoSize = true;
            this.lblSelectProductYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProductYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblSelectProductYear.Location = new System.Drawing.Point(57, 121);
            this.lblSelectProductYear.Name = "lblSelectProductYear";
            this.lblSelectProductYear.Size = new System.Drawing.Size(401, 25);
            this.lblSelectProductYear.TabIndex = 25;
            this.lblSelectProductYear.Text = "Select Product Year To Check Balance :";
            // 
            // lbltitleOfReport
            // 
            this.lbltitleOfReport.AutoSize = true;
            this.lbltitleOfReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitleOfReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lbltitleOfReport.Location = new System.Drawing.Point(380, 21);
            this.lbltitleOfReport.Name = "lbltitleOfReport";
            this.lbltitleOfReport.Size = new System.Drawing.Size(755, 32);
            this.lbltitleOfReport.TabIndex = 24;
            this.lbltitleOfReport.Text = "Select The Data Of Which You Want To Make Report...";
            // 
            // ShowProductInfoTab
            // 
            this.ShowProductInfoTab.Controls.Add(this.ShowProductGridView);
            this.ShowProductInfoTab.Location = new System.Drawing.Point(4, 36);
            this.ShowProductInfoTab.Name = "ShowProductInfoTab";
            this.ShowProductInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.ShowProductInfoTab.Size = new System.Drawing.Size(1448, 784);
            this.ShowProductInfoTab.TabIndex = 3;
            this.ShowProductInfoTab.Text = "Show all Products";
            this.ShowProductInfoTab.UseVisualStyleBackColor = true;
            // 
            // ShowProductGridView
            // 
            this.ShowProductGridView.AllowUserToAddRows = false;
            this.ShowProductGridView.AllowUserToDeleteRows = false;
            this.ShowProductGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShowProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowProductGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowProductGridView.Location = new System.Drawing.Point(3, 3);
            this.ShowProductGridView.Name = "ShowProductGridView";
            this.ShowProductGridView.ReadOnly = true;
            this.ShowProductGridView.RowTemplate.Height = 24;
            this.ShowProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowProductGridView.Size = new System.Drawing.Size(1442, 778);
            this.ShowProductGridView.TabIndex = 1;
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1480, 848);
            this.Controls.Add(this.ProductTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductDetails";
            this.Text = "ProductDetails";
            this.Load += new System.EventHandler(this.ProductDetails_Load);
            this.ProductTabControl.ResumeLayout(false);
            this.AddProductDetails.ResumeLayout(false);
            this.AddProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridview)).EndInit();
            this.ProductInfoTab.ResumeLayout(false);
            this.ProductInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductInfoDataGridView)).EndInit();
            this.GenerateReport.ResumeLayout(false);
            this.GenerateReport.PerformLayout();
            this.ProductReportPanel.ResumeLayout(false);
            this.ShowProductInfoTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowProductGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ProductTabControl;
        private System.Windows.Forms.TabPage AddProductDetails;
        private System.Windows.Forms.TabPage ProductInfoTab;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPurchaseYear;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.Label lblProductBillNumber;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblProductTotal;
        private System.Windows.Forms.TextBox txtProductAmount;
        private System.Windows.Forms.Label lblProductAmount;
        private System.Windows.Forms.TextBox txtProductQty;
        private System.Windows.Forms.Label lblProductQty;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView ProductDataGridview;
        private System.Windows.Forms.TextBox txtProductSuplier;
        private System.Windows.Forms.Label lblProductSuplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPurchaseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSuplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotal;
        private System.Windows.Forms.TextBox txtProductIDInfo;
        private System.Windows.Forms.Label lblInfoProductID;
        private System.Windows.Forms.TextBox txtProdoctWriteOff;
        private System.Windows.Forms.Label lblProductWriteOff;
        private System.Windows.Forms.TextBox txtProductNameInfo;
        private System.Windows.Forms.Label lblInfoProductName;
        private System.Windows.Forms.TextBox txtProductQuantityInfo;
        private System.Windows.Forms.Label lblInfoProductQty;
        private System.Windows.Forms.TextBox txtPurchaseYearInfo;
        private System.Windows.Forms.Label lblInfoPurchaseYear;
        private System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResetInfo;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.DataGridView ProductInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn TodaysDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn WriteOff;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrenBalance;
        private System.Windows.Forms.TabPage GenerateReport;
        private System.Windows.Forms.TextBox txtProductPurchaseYear;
        private System.Windows.Forms.Button btnSerachYearandGenerateReport;
        private System.Windows.Forms.Label lblSelectProductYear;
        private System.Windows.Forms.Label lbltitleOfReport;
        private System.Windows.Forms.Panel ProductReportPanel;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer ProductReportViwer;
        private System.Windows.Forms.TabPage ShowProductInfoTab;
        private System.Windows.Forms.DataGridView ShowProductGridView;
    }
}