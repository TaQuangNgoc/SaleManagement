using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            categoryNameSLE.EditValue = decimal.Parse(DataRowDetail["CategoryID"].ToString());
            unitPriceTxt.Text = DataRowDetail["UnitPrice"].ToString();
            unitsInStockTxt.Text = DataRowDetail["UnitsInStock"].ToString();
            productID= int.Parse(DataRowDetail["ProductID"].ToString());
            if(DataRowDetail["Picture"].ToString()!="")
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
            byte[] image = null;
            image= handleImageFileAndConvertToImageType(imageLocation);
            if (isForUpdate == false)
            {
                DataAccess da = new DataAccess();
                if (da.IsInsertProducts(productNameTxt.Text,decimal.Parse(companyNameSLE.EditValue.ToString()),decimal.Parse(categoryNameSLE.EditValue.ToString()),unitPriceTxt.Text,unitsInStockTxt.Text, image))
                {
                    MessageBox.Show(" Insert Succeed!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This action isn't done because there are 2 record have same name!");
                }
            }
            else
            {
                DataAccess da = new DataAccess();
                if (da.IsUpdateProducts(productNameTxt.Text, decimal.Parse(companyNameSLE.EditValue.ToString()), decimal.Parse(categoryNameSLE.EditValue.ToString()), unitPriceTxt.Text, unitsInStockTxt.Text,image, productID))
                {
                    MessageBox.Show("Update Succeed!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This action isn't done because there are 2 record have same name!");
                }
            }
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
            this.Close();
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
