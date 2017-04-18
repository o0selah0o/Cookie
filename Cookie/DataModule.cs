using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Cookie
{
    public partial class DataModule : Form
    {
        public DataTable dtBrand;
        public DataTable dtSupplier;
        public DataTable dtProduct;
        public DataTable dtProductList;
        public DataView BrandView;
        public DataView SupplierView;
        public DataView ProductView;
        public DataView ProductListView;
        public OleDbConnection CtnCookie;
        public CookieB2CDataSet DSCookie;

        private OleDbCommand oleDbSelectCommand1;
        private OleDbCommand oleDbInsertCommand1;
        private OleDbCommand oleDbUpdateCommand1;
        private OleDbCommand oleDbDeleteCommand1;
        private OleDbDataAdapter daBrand;
        private OleDbCommand oleDbSelectCommand2;
        private OleDbCommand oleDbInsertCommand2;
        private OleDbCommand oleDbUpdateCommand2;
        private OleDbCommand oleDbDeleteCommand2;
        private OleDbDataAdapter daProduct;
        private OleDbCommand oleDbSelectCommand3;
        private OleDbCommand oleDbInsertCommand3;
        private OleDbCommand oleDbUpdateCommand3;
        private OleDbCommand oleDbDeleteCommand3;
        private OleDbDataAdapter daProductList;
        private OleDbCommand oleDbSelectCommand4;
        private OleDbCommand oleDbInsertCommand4;
        private OleDbCommand oleDbUpdateCommand4;
        private OleDbCommand oleDbDeleteCommand4;
        private OleDbDataAdapter daSupplier;
        public DataView AssignmentView;
        public DataModule()
        {
            InitializeComponent();
            DSCookie.EnforceConstraints = false;
            daBrand.Fill(DSCookie);
            daSupplier.Fill(DSCookie);
            daProduct.Fill(DSCookie);
            daProductList.Fill(DSCookie);

            dtBrand = DSCookie.Tables["Brand"];
            dtSupplier = DSCookie.Tables["Supplier"];
            dtProduct = DSCookie.Tables["Product"];
            dtProductList = DSCookie.Tables["ProductList"];

            BrandView = new DataView(dtBrand);
            BrandView.Sort = "BrandID";
            SupplierView = new DataView(dtSupplier);
            SupplierView.Sort = "SupplierID";
            ProductView = new DataView(dtProduct);
            ProductView.Sort = "ProductID";
            ProductListView = new DataView(dtProductList);
            ProductListView.Sort = "ProductListID";
            DSCookie.EnforceConstraints = true;
        }
        public void UpdateCase()
        {
            daBrand.Update(dtBrand);
        }
        public void UpdateClient()
        {
            daSupplier.Update(dtSupplier);
        }
        public void UpdateEquipment()
        {
            daProduct.Update(dtProduct);
        }
        public void UpdateInvestigator()
        {
            daProductList.Update(dtProductList);
        }

        private void daClient_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataModule));
            this.CtnCookie = new System.Data.OleDb.OleDbConnection();
            this.DSCookie = new Cookie.CookieB2CDataSet();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.daBrand = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.daProduct = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.daProductList = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
            this.daSupplier = new System.Data.OleDb.OleDbDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSCookie)).BeginInit();
            this.SuspendLayout();
            // 
            // CtnCookie
            // 
            this.CtnCookie.ConnectionString = "Provider=SQLNCLI11;Data Source=KELVIN-ITX\\SQLEXPRESS01;Integrated Security=SSPI;I" +
    "nitial Catalog=CookieB2C";
            // 
            // DSCookie
            // 
            this.DSCookie.DataSetName = "CookieB2CDataSet";
            this.DSCookie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        BrandID, BrandName, BrandOrigin, BrandCategory\r\nFROM            Bra" +
    "nd\r\nORDER BY BrandID";
            this.oleDbSelectCommand1.Connection = this.CtnCookie;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO [Brand] ([BrandName], [BrandOrigin], [BrandCategory]) VALUES (?, ?, ?" +
    ")";
            this.oleDbInsertCommand1.Connection = this.CtnCookie;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("BrandName", System.Data.OleDb.OleDbType.VarChar, 0, "BrandName"),
            new System.Data.OleDb.OleDbParameter("BrandOrigin", System.Data.OleDb.OleDbType.VarChar, 0, "BrandOrigin"),
            new System.Data.OleDb.OleDbParameter("BrandCategory", System.Data.OleDb.OleDbType.VarChar, 0, "BrandCategory")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE [Brand] SET [BrandName] = ?, [BrandOrigin] = ?, [BrandCategory] = ? WHERE " +
    "(([BrandID] = ?) AND ([BrandName] = ?) AND ([BrandOrigin] = ?) AND ([BrandCatego" +
    "ry] = ?))";
            this.oleDbUpdateCommand1.Connection = this.CtnCookie;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("BrandName", System.Data.OleDb.OleDbType.VarChar, 0, "BrandName"),
            new System.Data.OleDb.OleDbParameter("BrandOrigin", System.Data.OleDb.OleDbType.VarChar, 0, "BrandOrigin"),
            new System.Data.OleDb.OleDbParameter("BrandCategory", System.Data.OleDb.OleDbType.VarChar, 0, "BrandCategory"),
            new System.Data.OleDb.OleDbParameter("Original_BrandID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BrandID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_BrandName", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BrandName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_BrandOrigin", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BrandOrigin", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_BrandCategory", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BrandCategory", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM [Brand] WHERE (([BrandID] = ?) AND ([BrandName] = ?) AND ([BrandOrigi" +
    "n] = ?) AND ([BrandCategory] = ?))";
            this.oleDbDeleteCommand1.Connection = this.CtnCookie;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_BrandID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BrandID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_BrandName", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BrandName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_BrandOrigin", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BrandOrigin", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_BrandCategory", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BrandCategory", System.Data.DataRowVersion.Original, null)});
            // 
            // daBrand
            // 
            this.daBrand.DeleteCommand = this.oleDbDeleteCommand1;
            this.daBrand.InsertCommand = this.oleDbInsertCommand1;
            this.daBrand.SelectCommand = this.oleDbSelectCommand1;
            this.daBrand.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Brand", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("BrandID", "BrandID"),
                        new System.Data.Common.DataColumnMapping("BrandName", "BrandName"),
                        new System.Data.Common.DataColumnMapping("BrandOrigin", "BrandOrigin"),
                        new System.Data.Common.DataColumnMapping("BrandCategory", "BrandCategory")})});
            this.daBrand.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT        Product.*\r\nFROM            Product\r\nOrder by ProductID";
            this.oleDbSelectCommand2.Connection = this.CtnCookie;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO [Product] ([ProductName], [ProductNameCN], [BrandID], [PackageSize], " +
    "[UnitSize], [RetailPrice]) VALUES (?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.CtnCookie;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("ProductName", System.Data.OleDb.OleDbType.VarChar, 0, "ProductName"),
            new System.Data.OleDb.OleDbParameter("ProductNameCN", System.Data.OleDb.OleDbType.VarChar, 0, "ProductNameCN"),
            new System.Data.OleDb.OleDbParameter("BrandID", System.Data.OleDb.OleDbType.Integer, 0, "BrandID"),
            new System.Data.OleDb.OleDbParameter("PackageSize", System.Data.OleDb.OleDbType.VarChar, 0, "PackageSize"),
            new System.Data.OleDb.OleDbParameter("UnitSize", System.Data.OleDb.OleDbType.VarChar, 0, "UnitSize"),
            new System.Data.OleDb.OleDbParameter("RetailPrice", System.Data.OleDb.OleDbType.VarChar, 0, "RetailPrice")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.CtnCookie;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("ProductName", System.Data.OleDb.OleDbType.VarChar, 0, "ProductName"),
            new System.Data.OleDb.OleDbParameter("ProductNameCN", System.Data.OleDb.OleDbType.VarChar, 0, "ProductNameCN"),
            new System.Data.OleDb.OleDbParameter("BrandID", System.Data.OleDb.OleDbType.Integer, 0, "BrandID"),
            new System.Data.OleDb.OleDbParameter("PackageSize", System.Data.OleDb.OleDbType.VarChar, 0, "PackageSize"),
            new System.Data.OleDb.OleDbParameter("UnitSize", System.Data.OleDb.OleDbType.VarChar, 0, "UnitSize"),
            new System.Data.OleDb.OleDbParameter("RetailPrice", System.Data.OleDb.OleDbType.VarChar, 0, "RetailPrice"),
            new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ProductName", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ProductNameCN", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductNameCN", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_BrandID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BrandID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_PackageSize", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PackageSize", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_UnitSize", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UnitSize", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitSize", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitSize", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_RetailPrice", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RetailPrice", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_RetailPrice", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RetailPrice", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.CtnCookie;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ProductName", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ProductNameCN", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductNameCN", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_BrandID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BrandID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_PackageSize", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PackageSize", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_UnitSize", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UnitSize", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitSize", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitSize", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_RetailPrice", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RetailPrice", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_RetailPrice", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RetailPrice", System.Data.DataRowVersion.Original, null)});
            // 
            // daProduct
            // 
            this.daProduct.DeleteCommand = this.oleDbDeleteCommand2;
            this.daProduct.InsertCommand = this.oleDbInsertCommand2;
            this.daProduct.SelectCommand = this.oleDbSelectCommand2;
            this.daProduct.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Product", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
                        new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
                        new System.Data.Common.DataColumnMapping("ProductNameCN", "ProductNameCN"),
                        new System.Data.Common.DataColumnMapping("BrandID", "BrandID"),
                        new System.Data.Common.DataColumnMapping("PackageSize", "PackageSize"),
                        new System.Data.Common.DataColumnMapping("UnitSize", "UnitSize"),
                        new System.Data.Common.DataColumnMapping("RetailPrice", "RetailPrice")})});
            this.daProduct.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT        ProductList.*\r\nFROM            ProductList\r\norder by           Prod" +
    "uctListID";
            this.oleDbSelectCommand3.Connection = this.CtnCookie;
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO [ProductList] ([ProductID], [SupplierID], [Price]) VALUES (?, ?, ?)";
            this.oleDbInsertCommand3.Connection = this.CtnCookie;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 0, "ProductID"),
            new System.Data.OleDb.OleDbParameter("SupplierID", System.Data.OleDb.OleDbType.Integer, 0, "SupplierID"),
            new System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Currency, 0, "Price")});
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = "UPDATE [ProductList] SET [ProductID] = ?, [SupplierID] = ?, [Price] = ? WHERE (([" +
    "ProductListID] = ?) AND ([ProductID] = ?) AND ([SupplierID] = ?) AND ((? = 1 AND" +
    " [Price] IS NULL) OR ([Price] = ?)))";
            this.oleDbUpdateCommand3.Connection = this.CtnCookie;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 0, "ProductID"),
            new System.Data.OleDb.OleDbParameter("SupplierID", System.Data.OleDb.OleDbType.Integer, 0, "SupplierID"),
            new System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Currency, 0, "Price"),
            new System.Data.OleDb.OleDbParameter("Original_ProductListID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductListID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SupplierID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Price", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = "DELETE FROM [ProductList] WHERE (([ProductListID] = ?) AND ([ProductID] = ?) AND " +
    "([SupplierID] = ?) AND ((? = 1 AND [Price] IS NULL) OR ([Price] = ?)))";
            this.oleDbDeleteCommand3.Connection = this.CtnCookie;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ProductListID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductListID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SupplierID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Price", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, null)});
            // 
            // daProductList
            // 
            this.daProductList.DeleteCommand = this.oleDbDeleteCommand3;
            this.daProductList.InsertCommand = this.oleDbInsertCommand3;
            this.daProductList.SelectCommand = this.oleDbSelectCommand3;
            this.daProductList.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ProductList", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ProductListID", "ProductListID"),
                        new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
                        new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
                        new System.Data.Common.DataColumnMapping("Price", "Price")})});
            this.daProductList.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // oleDbSelectCommand4
            // 
            this.oleDbSelectCommand4.CommandText = "SELECT        Supplier.*\r\nFROM            Supplier\r\norder by SupplierID";
            this.oleDbSelectCommand4.Connection = this.CtnCookie;
            // 
            // oleDbInsertCommand4
            // 
            this.oleDbInsertCommand4.CommandText = "INSERT INTO [Supplier] ([SupplierName]) VALUES (?)";
            this.oleDbInsertCommand4.Connection = this.CtnCookie;
            this.oleDbInsertCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("SupplierName", System.Data.OleDb.OleDbType.VarChar, 0, "SupplierName")});
            // 
            // oleDbUpdateCommand4
            // 
            this.oleDbUpdateCommand4.CommandText = "UPDATE [Supplier] SET [SupplierName] = ? WHERE (([SupplierID] = ?) AND ([Supplier" +
    "Name] = ?))";
            this.oleDbUpdateCommand4.Connection = this.CtnCookie;
            this.oleDbUpdateCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("SupplierName", System.Data.OleDb.OleDbType.VarChar, 0, "SupplierName"),
            new System.Data.OleDb.OleDbParameter("Original_SupplierID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SupplierName", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SupplierName", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand4
            // 
            this.oleDbDeleteCommand4.CommandText = "DELETE FROM [Supplier] WHERE (([SupplierID] = ?) AND ([SupplierName] = ?))";
            this.oleDbDeleteCommand4.Connection = this.CtnCookie;
            this.oleDbDeleteCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_SupplierID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SupplierName", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SupplierName", System.Data.DataRowVersion.Original, null)});
            // 
            // daSupplier
            // 
            this.daSupplier.DeleteCommand = this.oleDbDeleteCommand4;
            this.daSupplier.InsertCommand = this.oleDbInsertCommand4;
            this.daSupplier.SelectCommand = this.oleDbSelectCommand4;
            this.daSupplier.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Supplier", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
                        new System.Data.Common.DataColumnMapping("SupplierName", "SupplierName")})});
            this.daSupplier.UpdateCommand = this.oleDbUpdateCommand4;
            // 
            // DataModule
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "DataModule";
            ((System.ComponentModel.ISupportInitialize)(this.DSCookie)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
