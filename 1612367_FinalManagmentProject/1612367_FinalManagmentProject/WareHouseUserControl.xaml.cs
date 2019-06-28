using System;
using System.Collections.Generic;
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

namespace _1612367_FinalManagmentProject
{
    /// <summary>
    /// Interaction logic for WareHouseUserControl.xaml
    /// </summary>
    public partial class WareHouseUserControl : UserControl
    {
        const int SizeQuantity = 7;
        const int minSize = 36;
        DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.ManagementProjectConnectionString);
        public WareHouseUserControl()
        {
            InitializeComponent();
            ProductSizeQuantityVMs itemsource = new ProductSizeQuantityVMs();
            ProductDataGrid.ItemsSource = itemsource.getProductViewModel();
            SumProductLable.Content = "Tổng cộng: " + itemsource.sumProduct;
        }

        private void bntAddItem_Click(object sender, RoutedEventArgs e)
        {
            dialogAddProduct.IsOpen = true;
            setUpDialog();
        }

        private void btnCancelAddProduct_Click(object sender, RoutedEventArgs e)
        {
            dialogAddProduct.IsOpen = false;
        }

        private void setUpDialog()
        {
            size36QuantityTxt.Text = "0";
            size37QuantityTxt.Text = "0";
            size38QuantityTxt.Text = "0";
            size39QuantityTxt.Text = "0";
            size40QuantityTxt.Text = "0";
            size41QuantityTxt.Text = "0";
            size42QuantityTxt.Text = "0";

        }

        private void reloadData()
        {
            ProductDataGrid.ItemsSource = null;
            ProductSizeQuantityVMs itemsource = new ProductSizeQuantityVMs();
            ProductDataGrid.ItemsSource = itemsource.getProductViewModel();
            SumProductLable.Content = "Tổng cộng: "+ itemsource.sumProduct;
        }

        private void bntAddProduct_Click(object sender, RoutedEventArgs e)
        {
            int[] arrSizeQuantityInput = isInputValid();

            if (arrSizeQuantityInput[0] != -1)
            {
                ProductSizeQuantityViewModel model = ProductDataGrid.SelectedItem as ProductSizeQuantityViewModel;
                int sumQuantityAdd = 0;
                //cho dữ liệu mới vào database
                //Cho vào từng bảng size_product
                for (int i = 0; i < SizeQuantity; i++)
                {
                    if (arrSizeQuantityInput[i] > 0)
                    {
                        switch (i)
                        {
                            case 36 - minSize:
                                var x = (from p in dc.Size36_Products where p.idProduct == model.idProduct select p).ToList();

                                if (x.Count == 0) //Chưa có id sản phẩm này trong bảng size
                                {
                                    dc.Size36_Products.InsertOnSubmit(new Size36_Product(model.idProduct, arrSizeQuantityInput[36 - minSize]));
                                }
                                else
                                {
                                    x[0].quantity = x[0].quantity + arrSizeQuantityInput[36 - minSize];
                                }
                                break;
                            case 37 - minSize:
                                var x1 = (from p in dc.Size37_Products where p.idProduct == model.idProduct select p).ToList();

                                if (x1.Count == 0) //Chưa có id sản phẩm này trong bảng size
                                {
                                    dc.Size37_Products.InsertOnSubmit(new Size37_Product(model.idProduct, arrSizeQuantityInput[37 - minSize]));
                                }
                                else
                                {
                                    x1[0].quantity = x1[0].quantity + arrSizeQuantityInput[37 - minSize];
                                }
                                break;
                            case 38 - minSize:
                                var x2 = (from p in dc.Size38_Products where p.idProduct == model.idProduct select p).ToList();

                                if (x2.Count == 0) //Chưa có id sản phẩm này trong bảng size
                                {
                                    dc.Size38_Products.InsertOnSubmit(new Size38_Product(model.idProduct, arrSizeQuantityInput[38 - minSize]));
                                }
                                else
                                {
                                    x2[0].quantity = x2[0].quantity + arrSizeQuantityInput[38 - minSize];
                                }
                                break;
                            case 39 - minSize:
                                var x3 = (from p in dc.Size39_Products where p.idProduct == model.idProduct select p).ToList();

                                if (x3.Count == 0) //Chưa có id sản phẩm này trong bảng size
                                {
                                    dc.Size39_Products.InsertOnSubmit(new Size39_Product(model.idProduct, arrSizeQuantityInput[39 - minSize]));
                                }
                                else
                                {
                                    x3[0].quantity = x3[0].quantity + arrSizeQuantityInput[39 - minSize];
                                }
                                break;
                            case 40 - minSize:
                                var x4 = (from p in dc.Size40_Products where p.idProduct == model.idProduct select p).ToList();

                                if (x4.Count == 0) //Chưa có id sản phẩm này trong bảng size
                                {
                                    dc.Size40_Products.InsertOnSubmit(new Size40_Product(model.idProduct, arrSizeQuantityInput[40 - minSize]));
                                }
                                else
                                {
                                    x4[0].quantity = x4[0].quantity + arrSizeQuantityInput[40 - minSize];
                                }
                                break;
                            case 41 - minSize:
                                var x5 = (from p in dc.Size41_Products where p.idProduct == model.idProduct select p).ToList();

                                if (x5.Count == 0) //Chưa có id sản phẩm này trong bảng size
                                {
                                    dc.Size41_Products.InsertOnSubmit(new Size41_Product(model.idProduct, arrSizeQuantityInput[41 - minSize]));
                                }
                                else
                                {
                                    x5[0].quantity = x5[0].quantity + arrSizeQuantityInput[41 - minSize];
                                }
                                break;
                            case 42 - minSize:
                                var x6 = (from p in dc.Size42_Products where p.idProduct == model.idProduct select p).ToList();

                                if (x6.Count == 0) //Chưa có id sản phẩm này trong bảng size
                                {
                                    dc.Size42_Products.InsertOnSubmit(new Size42_Product(model.idProduct, arrSizeQuantityInput[42 - minSize]));
                                }
                                else
                                {
                                    x6[0].quantity = x6[0].quantity + arrSizeQuantityInput[42 - minSize];
                                }
                                break;

                            default:
                                break;

                        }
                    }
                    sumQuantityAdd += arrSizeQuantityInput[i];
                }

                //Thay đổi sumQuantity của sản phẩm
                var modelProductInDb = (from p in dc.ProductDbs where p.id == model.idProduct select p).Single();
                modelProductInDb.sumQuantity = model.sumQuantity + sumQuantityAdd;

                try
                {
                    dc.SubmitChanges();
                    reloadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dialogAddProduct.IsOpen = false;
            }

            else
            {
                //do nothing
            }
        }

        /// <summary>
        /// Kiểm tra dữ liệu nhập vào đúng hay không
        /// </summary>
        /// <returns>trả về mảng có a[0]=-1 nếu dữ liệu nhập sai. Ngược lại, trả về mảng số lượng sản phẩm với size tương ứng (từ 36 đến 42)</returns>
        private int[] isInputValid()
        {
            string error = "";
            int[] quantityArr = new int[SizeQuantity] { 0, 0, 0, 0, 0, 0, 0 };
            try
            {
                quantityArr[0] = Convert.ToInt32(size36QuantityTxt.Text);
                quantityArr[1] = Convert.ToInt32(size37QuantityTxt.Text);
                quantityArr[2] = Convert.ToInt32(size38QuantityTxt.Text);
                quantityArr[3] = Convert.ToInt32(size39QuantityTxt.Text);
                quantityArr[4] = Convert.ToInt32(size40QuantityTxt.Text);
                quantityArr[5] = Convert.ToInt32(size41QuantityTxt.Text);
                quantityArr[6] = Convert.ToInt32(size42QuantityTxt.Text);
            }
            catch
            {
                error = "Hãy nhập số lượng đúng";
                //return false;
            }

            for (int i = 0; i < SizeQuantity; i++)
            {
                if (quantityArr[i] < 0)
                {
                    error = "Số lượng không thể âm. Vui lòng nhập lại";
                    //return false;
                }
            }

            if (!error.Equals(""))
            {
                MessageBox.Show(error);
                return new int[1] { -1 };
            }

            return quantityArr;
        }
    }
}
