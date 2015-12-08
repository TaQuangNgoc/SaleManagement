using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class ProductDetailsForm : Form
    {
        private bool isForUpdate;
        private int productID;
        private string imageLocation = "";
        private DataAccess dataAccess;

        public static ProductDetailsForm CreateInsertForm()
        {
            var form = new ProductDetailsForm();
            form.isForUpdate = false;
            form.ShowDialog();

            return form;
        }

        public static ProductDetailsForm CreateUpdateForm(DataRow selectedRow)
        {
            var form = new ProductDetailsForm();
            form.isForUpdate = true;

            form.TransferDataRowDetailToForm(selectedRow);

            form.ShowDialog();

            return form;
        }

        private ProductDetailsForm()
        {
            InitializeComponent();
            dataAccess = new DataAccess();

            comboBox.DisplayMember = "CompanyName";
            comboBox.ValueMember = "SupplierID";

            DataTable dt = dataAccess.SelectSuppliers();
          
            comboBox.DataSource = dt;
            dt.Rows.Add(-1, "chua xac dinh");
        }

        private void ProductsDetail_Load(object sender, EventArgs e)
        {
            LoadDataToCompanyNameSLE();
            LoadDataToCategryNameSLE();
        }

        private void LoadDataToCategryNameSLE()
        {
            categoryNameSLE.Properties.DataSource = dataAccess.SelectCategories();
            categoryNameSLE.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
        }

        private void LoadDataToCompanyNameSLE()
        {
            companyNameSLE.Properties.DataSource = dataAccess.SelectSuppliers();
            companyNameSLE.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
        }

        private void TransferDataRowDetailToForm(DataRow DataRowDetail)
        {
            productNameTxt.Text = DataRowDetail["ProductName"].ToString();
            companyNameSLE.EditValue = decimal.Parse(DataRowDetail["SupplierID"].ToString());
            //comboBox.SelectedValue = decimal.Parse(DataRowDetail["SupplierID"].ToString());
            comboBox.SelectedValue = -1;
            categoryNameSLE.EditValue = decimal.Parse(DataRowDetail["CategoryID"].ToString());
            unitPriceTxt.Text = DataRowDetail["UnitPrice"].ToString();
            unitsInStockTxt.Text = DataRowDetail["UnitsInStock"].ToString();
            productID = int.Parse(DataRowDetail["ProductID"].ToString());
            if (DataRowDetail["Picture"].ToString() != "")
                getAndPresentImage((byte[])(DataRowDetail["Picture"]));
            else
            {
                pictureBox.Image = null;
            }
        }

        private void getAndPresentImage(byte[] imageByte)
        {
            MemoryStream ms = new MemoryStream(imageByte);
            pictureBox.Image = Image.FromStream(ms);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (productNameTxt.Text == "" || unitPriceTxt.Text == "" || unitsInStockTxt.Text == "")
            {
                MessageBox.Show("Invalid field.", "Error");
                return;
            }

            string productName = productNameTxt.Text;
            int supplierID, categoryID, unitsInStock;
            decimal unitPrice;
            
            /*
            bool validSupplierID = int.TryParse(companyNameSLE.EditValue.ToString(), out supplierID),
                validCategoryID = int.TryParse(categoryNameSLE.EditValue.ToString(), out categoryID),
                validUnitsInStock = int.TryParse(unitsInStockTxt.Text, out unitsInStock),
                validUnitPrice = decimal.TryParse(unitPriceTxt.Text, out unitPrice);*/
            Console.WriteLine(comboBox.SelectedValue.ToString());
            Console.WriteLine(categoryNameSLE.EditValue.ToString());
            bool validSupplierID = int.TryParse(comboBox.SelectedValue.ToString(), out supplierID),
                validCategoryID = int.TryParse(categoryNameSLE.EditValue.ToString(), out categoryID),
                validUnitsInStock = int.TryParse(unitsInStockTxt.Text, out unitsInStock),
                validUnitPrice = decimal.TryParse(unitPriceTxt.Text, out unitPrice);

            if (!validSupplierID || !validCategoryID || !validUnitsInStock || !validUnitPrice)
            {
                MessageBox.Show("Invalid field.", "Error");
                return;
            }

            
            ImageConverter imageConverter = new ImageConverter();
            byte[] image = (byte[])imageConverter.ConvertTo(pictureBox.Image, typeof(byte[]));

            if (isForUpdate)
                dataAccess.UpdateProduct(productName, supplierID, categoryID, unitPrice, unitsInStock, image, productID);
            else
                dataAccess.InsertProduct(productName, supplierID, categoryID, unitPrice, unitsInStock, image);

            MessageBox.Show("Success.");
            Close();
        }

        private byte[] handleImageFileAndConvertToImageType(string imageLocation)
        {
            byte[] image = null;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            image = br.ReadBytes((int)fs.Length);
            return image;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select an image file to encrypt.";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName.ToString();
                pictureBox.ImageLocation = imageLocation;
            }
        }
    }
}
