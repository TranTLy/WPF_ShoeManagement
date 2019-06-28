using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
    /// Interaction logic for Product.xaml
    /// </summary>
    public partial class Product : UserControl
    {
        DataClasses1DataContext dc = new DataClasses1DataContext (Properties.Settings.Default.ManagementProjectConnectionString);
        bool isManager;
        public Product()
        {
            isManager = true;
            InitializeComponent();
            
            try
            {
                ProductVMs itemsource = new ProductVMs(dc.ProductDbs.ToList());
                ProductDataGrid.ItemsSource = itemsource.getProductViewModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Không thể tải dữ liệu");
            }

            cbTypeProduct.ItemsSource = dc.CategoryDbs;
        }

        public Product(bool isManager)
        {
            this.isManager = isManager;

            InitializeComponent();

            try
            {
                ProductVMs itemsource = new ProductVMs(dc.ProductDbs.ToList());
                ProductDataGrid.ItemsSource = itemsource.getProductViewModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Không thể tải dữ liệu");
            }

            if (isManager == false)
            {
                btnAdd.Visibility = Visibility.Collapsed;
            }

            cbTypeProduct.ItemsSource = dc.CategoryDbs.ToList() ;
        }

        //Edit 
        private void btnEdt_Click(object sender, RoutedEventArgs e)
        {
            setUpdialog();

            //unable to change type product
            categoryLable.Visibility = Visibility.Collapsed;
            comboBoxCategory.Visibility = Visibility.Collapsed;

            btnSave.Visibility = Visibility.Visible;
            bntAddProduct.Visibility = Visibility.Collapsed;
            sizeCheckboxs.Visibility = Visibility.Hidden;
            lblSize.Visibility = Visibility.Hidden;

            //get data from exist model
            var selecteModel = ProductDataGrid.SelectedItem as ProductViewModel;
            nameProductTxt.Text = selecteModel.nameProduct;
            long x = (long)(selecteModel.priceImport);
            priceImprotTxt.Text = x.ToString();
            x = (long)(selecteModel.priceSell);
            priceSellTxt.Text = x.ToString();
            bonusScoreTxt.Text = selecteModel.bonusScore.ToString();
            unitTxt.Text = selecteModel.unit;
        }
        

        //Delete
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!isManager)
            {
                return;
            }

            var indexRow = ProductDataGrid.SelectedIndex;
            if (indexRow != -1)
            {
                ProductDb productRow = ProductDataGrid.SelectedItem as ProductDb;
                var productInDb = (from p in dc.ProductDbs where p.id == productRow.id select p).Single();
                //kiem tra xem trong chi tiet hoa don co du lieu nao lien quan den san pham nay hay khong
                var detailReceipt = (from p in dc.DetailReceipts where p.idProduct == productInDb.id select p).ToList();
                
                if (productInDb.sumQuantity > 0)
                {
                    MessageBox.Show("Sản phẩm này còn "+ productInDb.sumQuantity + " "+ (productInDb.unit).ToLower()
                        +" nên không thể xóa\n");
                }
                else if (detailReceipt.Count > 0)
                {
                    MessageBox.Show("Không thể xóa sản phẩm này vì có dữ liệu liên quan trong các hóa đơn\n");
                }
                else
                {
                    MessageBoxButton mesBox = MessageBoxButton.YesNo;
                    MessageBoxResult result = MessageBox.Show("Bạn có thật sư muốn xóa sản phẩm " + productRow.nameProduct,
                        "Xác nhận", mesBox, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        try
                        {
                            //xóa sản phẩm trong bảng size
                            var x = (from p in dc.Size36_Products
                                     where p.idProduct == productInDb.id
                                     select p).ToList();
                            if (x.Count > 0)
                            {
                                dc.Size36_Products.DeleteOnSubmit(x[0]);
                            }
                            var x1 = (from p in dc.Size37_Products
                                     where p.idProduct == productInDb.id
                                     select p).ToList();
                            if (x1.Count > 0)
                            {
                                dc.Size37_Products.DeleteOnSubmit(x1[0]);
                            }
                            var x2 = (from p in dc.Size38_Products
                                     where p.idProduct == productInDb.id
                                     select p).ToList();
                            if (x2.Count > 0)
                            {
                                dc.Size38_Products.DeleteOnSubmit(x2[0]);
                            }
                            var x3 = (from p in dc.Size39_Products
                                     where p.idProduct == productInDb.id
                                     select p).ToList();
                            if (x3.Count > 0)
                            {
                                dc.Size39_Products.DeleteOnSubmit(x3[0]);
                            }
                            var x4 = (from p in dc.Size40_Products
                                     where p.idProduct == productInDb.id
                                     select p).ToList();
                            if (x4.Count > 0)
                            {
                                dc.Size40_Products.DeleteOnSubmit(x4[0]);
                            }
                            var x5 = (from p in dc.Size41_Products
                                     where p.idProduct == productInDb.id
                                     select p).ToList();
                            if (x5.Count > 0)
                            {
                                dc.Size41_Products.DeleteOnSubmit(x5[0]);
                            }
                            var x6 = (from p in dc.Size42_Products
                                     where p.idProduct == productInDb.id
                                     select p).ToList();
                            if (x6.Count > 0)
                            {
                                dc.Size42_Products.DeleteOnSubmit(x6[0]);
                            }


                            //xóa sản phẩm trong bảng ProductDbs
                            dc.ProductDbs.DeleteOnSubmit(productInDb);
                           
                            dc.SubmitChanges();
                            reloadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Xóa không thành công");
                        }
                    }
                    else
                    {
                        //do nothing
                    }
                }
            }
        }

        private void reloadData()
        {
            try
            {
                ProductDataGrid.ItemsSource = null;
                ProductVMs itemsource = new ProductVMs(dc.ProductDbs.ToList());
                ProductDataGrid.ItemsSource = itemsource.getProductViewModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Không thể tải dữ liệu mới");
            }
        }

        private void setUpdialog()
        {
            dialogAddProduct.IsOpen = true;
            var x = from categoryName in dc.CategoryDbs select categoryName;
            comboBoxCategory.ItemsSource = x;

            try
            {
                comboBoxCategory.SelectedIndex = 0;
            }
            catch
            {
                //Chưa có loại sản phẩm nào
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            categoryLable.Visibility = Visibility.Visible;
            comboBoxCategory.Visibility = Visibility.Visible;

            btnSave.Visibility = Visibility.Collapsed;
            bntAddProduct.Visibility = Visibility.Visible;
            sizeCheckboxs.Visibility = Visibility.Visible;
            lblSize.Visibility = Visibility.Visible;

            setUpdialog();
        }

        private void bntAddProduct_Click(object sender, RoutedEventArgs e)
        {
            //Kiểm tra tính hợp lệ
            if (checkInputNewProduct())
            {
                string name = nameProductTxt.Text;
                string unit = unitTxt.Text;
                long priceImport = Convert.ToInt64(priceImprotTxt.Text);
                long priceSell = Convert.ToInt64(priceSellTxt.Text);
                int bonusScore = Convert.ToInt32(bonusScoreTxt.Text);
                CategoryDb category = comboBoxCategory.SelectedItem as CategoryDb;

                ProductDb newProduct = new ProductDb(name, unit, priceImport, priceSell, bonusScore, category.id);

                dc.ProductDbs.InsertOnSubmit(newProduct);

                try
                {
                    dc.SubmitChanges();
                }
                catch (Exception except)
                {
                    MessageBox.Show("Không thể thêm sản phẩm", except.Message);
                    return;
                }
                //retrieve it to add into size_product table
                ProductDb product = (from p in dc.ProductDbs
                                     where p.nameProduct == name && p.unit == unit && p.priceImport == priceImport
                                        && p.priceSell == priceSell && p.bonusScore == bonusScore && p.category == category.id
                                     select p).Single();
                addSizeProduct(product.id);
                
                reloadData();
                resetDialogAddProduct();
                dialogAddProduct.IsOpen = false;
            }
            else
            {
                //do nothing
            }

        }

        private void addSizeProduct(int idProduct)
        {
            List<CheckBox> cbs = new List<CheckBox>() { checkboxSize36, checkboxSize37, checkboxSize38, checkboxSize39,
                checkboxSize40,  checkboxSize41, checkboxSize42 };
            
            for (int i = 0; i < cbs.Count; i++)
            {
                if (cbs[i].IsChecked==true)
                {
                    switch (i + 36)
                    {
                        case 36:
                            dc.Size36_Products.InsertOnSubmit(new Size36_Product(idProduct, 0));
                            break;
                        case 37:
                            dc.Size37_Products.InsertOnSubmit(new Size37_Product(idProduct, 0));
                            break;
                        case 38:
                            dc.Size38_Products.InsertOnSubmit(new Size38_Product(idProduct, 0));
                            break;
                        case 39:
                            dc.Size39_Products.InsertOnSubmit(new Size39_Product(idProduct, 0));
                            break;
                        case 40:
                            dc.Size40_Products.InsertOnSubmit(new Size40_Product(idProduct, 0));
                            break;
                        case 41:
                            dc.Size41_Products.InsertOnSubmit(new Size41_Product(idProduct, 0));
                            break;
                        case 42:
                            dc.Size42_Products.InsertOnSubmit(new Size42_Product(idProduct, 0));
                            break;
                    }
                }
            }

            try
            {
                dc.SubmitChanges();
            }
            catch (Exception except)
            {
                MessageBox.Show("Không thể thêm size sản phẩm", except.Message);
            }
        }

        public bool checkInputNewProduct()
        {
            string messageError = "";
            bool result = true;

            if (nameProductTxt.Text.Equals(""))
            {
                messageError = "Tên sản phẩm đang trống\n";
                nameProductTxt.Focusable = true;
                result=false; 
            }
            //else if (categoryTxt.Text.Equals("")) {
            //    messageError = "Loại sản phẩm đang trống\n";
            //    categoryTxt.Focusable = true;
            //}
            else if (priceImprotTxt.Text.Equals(""))
            {
                messageError = "Bạn hãy nhập giá nhập kho của sản phẩm\n";
                priceImprotTxt.Focusable = true;
                result=false; 
            }
            else if (priceSellTxt.Text.Equals(""))
            {
                messageError = "Bạn hãy nhập giá xuất của sản phẩm\n";
                priceSellTxt.Focusable = true;
                result=false; 
            }
            else if (bonusScoreTxt.Text.Equals(""))
            {
                messageError = "Bạn hãy nhập điểm tích lũy của sản phẩm (<=10 điểm)";
                bonusScoreTxt.Focusable = true;
                result=false; 
            }
            else if (!(checkboxSize36.IsChecked.Value || checkboxSize37.IsChecked.Value || checkboxSize38.IsChecked.Value ||
               checkboxSize39.IsChecked.Value || checkboxSize36.IsChecked.Value || checkboxSize36.IsChecked.Value))
            {
                messageError = "Bạn hãy chọn size có sẵn của sản phẩm";
                result=false; 
            }

            //kiếm tra tên sản phẩm: Không được trùng với tên sản phẩm đã có
            else if (isNewProductExist())
            {
                messageError = "Tên sản phẩm này đã tồn tại, vui lòng nhập tên khác\n";
                nameProductTxt.Focusable = true;
                result=false; 
            }

            else
            {
                //Kiểm tra giá sản phẩm
                long priceImport=0;
                long priceSell=0;
                try
                {
                    priceImport = Convert.ToInt64(priceImprotTxt.Text);
                }
                catch
                {
                    messageError = "Giá nhập không hợp lệ\n";
                    result=false; 
                }

                try
                {
                    priceSell = Convert.ToInt64(priceSellTxt.Text);
                }
                catch
                {
                    messageError = "Giá xuất không hợp lệ\n";
                    result=false; 
                }

                if (priceImport <= 0)
                {
                    messageError = "Giá xuất phải lớn hơn 0đ\n";
                    result=false; 
                }

                else if (priceSell <= priceImport)
                {
                    messageError = "Giá xuất phải cao hơn giá nhập\n";
                    result=false; 
                }

                int bonusScoreInput = 0;
                try
                {
                    bonusScoreInput = Convert.ToInt32(bonusScoreTxt.Text);
                }
                catch
                {
                    messageError = "Điểm tích lũy không hợp lệ";
                    result=false; 
                }

                if (bonusScoreInput < 0)
                {
                    messageError = "Điểm tích lũy cần >=0\n";
                    result=false; 
                }
            }

            if (!result)
            {
                MessageBox.Show("Error", messageError);
            }
            return result;
        }

        private bool isNewProductExist()
        {
            var nameProductInput = nameProductTxt.Text;
            var productInDb = (from product in dc.ProductDbs where nameProductInput == product.nameProduct select product.nameProduct).ToList();

            if (productInDb.Count>0)    //tên sản phẩm này đã tồn tại
            {
                return true;
            }
            return false;
        }

        private void btnCancelAddProduct_Click(object sender, RoutedEventArgs e)
        {
            dialogAddProduct.IsOpen = false; //đóng dialog
            resetDialogAddProduct();
           
        }

        void resetDialogAddProduct()
        {
            //trả lại trạng thái ban đầu của dialog
            nameProductTxt.Text = "";
            priceImprotTxt.Text = "";
            priceSellTxt.Text = "";
            bonusScoreTxt.Text = "";

            checkboxSize36.IsChecked = true;
            checkboxSize37.IsChecked = true;
            checkboxSize38.IsChecked = true;
            checkboxSize39.IsChecked = true;
            checkboxSize40.IsChecked = true;
            checkboxSize41.IsChecked = true;
            checkboxSize42.IsChecked = true;
        }

        private void btnSave_Click_1(object sender, RoutedEventArgs e)
        {
            if (checkInputNewProduct())
            {
                var selecteModel = ProductDataGrid.SelectedItem as ProductViewModel;
                

                ProductDb model = (from p in dc.ProductDbs where p.id == selecteModel.id select p).Single();
                model.nameProduct = nameProductTxt.Text;
                model.priceSell = Convert.ToInt64(priceSellTxt.Text);
                model.priceImport = Convert.ToInt64(priceImprotTxt.Text);
                model.bonusScore = Convert.ToInt32(bonusScoreTxt.Text);
                model.unit = unitTxt.Text;
                try
                {
                    dc.SubmitChanges();
                    dialogAddProduct.IsOpen = false;
                    reloadData();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        

        private void cbTypeProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = cbTypeProduct.SelectedIndex;

            if (index == -1)
            {
                return;
            }

            var category = cbTypeProduct.SelectedItem as CategoryDb;
            if (category.id == 6)
            {
                reloadData();
            }
            else
            {
                List<ProductDb> models = (from p in dc.ProductDbs where p.category == category.id select p).ToList();

                try
                {
                    ProductDataGrid.ItemsSource = null;
                    ProductVMs itemsource = new ProductVMs(models);
                    ProductDataGrid.ItemsSource = itemsource.getProductViewModel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Không thể tải dữ liệu mới");
                }
            }
        }
    }
}
