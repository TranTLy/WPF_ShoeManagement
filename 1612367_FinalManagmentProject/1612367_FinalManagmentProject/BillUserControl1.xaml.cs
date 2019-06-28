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
    /// Interaction logic for BillUserControl1.xaml
    /// </summary>
    public partial class BillUserControl1 : UserControl
    {
        DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.ManagementProjectConnectionString);
        List<DetailReceipt> listDetailReciept;
        int order;
        long sumMoney;
        int sumScore;
        const int sizeMin = 36;
        const int idUnregistedCustomer = 3;

        public BillUserControl1()
        {
            InitializeComponent();
            var itemsource = new ReceiptVMs();
            ReceiptDataGrid.ItemsSource = itemsource.models;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            dialogReceipt.IsOpen = true;
            setUpDialogReceipt();
            listDetailReciept = new List<DetailReceipt>();
        }

        private void btnAddDetail_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(comboBoxCustomer.SelectedIndex.ToString());
            if (isInputValid())
            {
                comboBoxCustomer.Visibility = Visibility.Collapsed;
                nameCustomerLable.Visibility = Visibility.Visible;

                addADetailReceipt();
            }
        }

        private bool addADetailReceipt()
        {
            //id customer
            var customer = comboBoxCustomer.SelectedItem as CustomerDb;
            var product = comboBoxNameProduct.SelectedItem as ProductDb;
            int quantity = Convert.ToInt32(quantityTxt.Text);
            int size = (int)comboBoxSize.SelectedItem;

            if (customer == null)
            {
                customer = (from p in dc.CustomerDbs where p.id == idUnregistedCustomer select p).Single(); // customer who unregist information
            }
            nameCustomerLable.Content = customer.nameCustomer;
            
            if (checkQuantity(quantity, size)) //kiểm tra số lượng size còn đủ hàng hay không
            {
                order++;
                DetailReceiptViewModel detail = new DetailReceiptViewModel(customer, product, quantity, size, DateTime.Now, order);
                listDetailReciept.Add(detail);

                try
                {
                    DetailReceiptDataGrid.ItemsSource = null;
                    DetailReceiptDataGrid.ItemsSource = listDetailReciept;
                    sumMoney += detail.sumMoney;
                    sumScore += detail.sumScore;
                    SumMoneyLable.Content = "Tổng tiền: " + Unity.formatMoney(sumMoney);
                    SumScoreLable.Content = "Tổng điểm: " + sumScore;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                   
                }
                return true;
                
            }
            else
            {
                return false;
            }
        }

        private bool checkQuantity(int quantity, int size)
        {
            var product = comboBoxNameProduct.SelectedItem as ProductDb;
            string error = "";

            switch (size)
            {
                case 36:
                    var x = (from p in dc.Size36_Products
                             where p.idProduct == product.id
                             select p).ToList();
                    if (x.Count == 0)
                    {
                        error = "Sản phẩm này không có size " + size + "\nVui lòng chọn size khác\n";
                    }
                    else if (x[0].quantity == 0)
                    {
                        error = "Sản phẩm này hết size " + size + "\nVui lòng chọn size khác\n";
                    }
                    else if (x[0].quantity < quantity)
                    {
                        error = "Không đủ số lượng\nSize " + size + " của " + product.nameProduct + " chỉ còn " + x[0].quantity + " " + (product.unit).ToLower();
                    }
                    break;
                case 37:
                    var x1 = (from p in dc.Size37_Products
                             where p.idProduct == product.id
                             select p).ToList();
                    if (x1.Count == 0)
                    {
                        error = "Sản phẩm này không có size " + size + "\nVui lòng chọn size khác\n";
                    }
                    else if (x1[0].quantity == 0)
                    {
                        error = "Sản phẩm này hết size " + size + "\nVui lòng chọn size khác\n";
                    }
                    else if (x1[0].quantity < quantity)
                    {
                        error = "Không đủ số lượng\nSize " + size + " của " + product.nameProduct + " chỉ còn " + x1[0].quantity + " " + (product.unit).ToLower();
                    }
                    break;
                case 38:
                    var x2 = (from p in dc.Size38_Products
                             where p.idProduct == product.id
                             select p).ToList();
                    if (x2.Count == 0)
                    {
                        error = "Sản phẩm này không có size " + size + "\nVui lòng chọn size khác\n";
                    }
                    else if (x2[0].quantity == 0)
                    {
                        error = "Sản phẩm này hết size " + size + "\nVui lòng chọn size khác\n";
                    }
                    else if (x2[0].quantity < quantity)
                    {
                        error = "Không đủ số lượng\nSize " + size + " của " + product.nameProduct + " chỉ còn " + x2[0].quantity + " " + (product.unit).ToLower();
                    }
                    break;
                case 39:
                    var x3 = (from p in dc.Size39_Products
                             where p.idProduct == product.id
                             select p).ToList();
                    if (x3.Count == 0)
                    {
                        error = "Sản phẩm này không có size " + size + "\nVui lòng chọn size khác\n";
                    }
                    else if (x3[0].quantity == 0)
                    {
                        error = "Sản phẩm này hết size " + size + "\nVui lòng chọn size khác\n";
                    }
                    else if (x3[0].quantity < quantity)
                    {
                        error = "Không đủ số lượng\nSize " + size + " của " + product.nameProduct + " chỉ còn " + x3[0].quantity + " " + (product.unit).ToLower();
                    }
                    break;
                case 40:
                    var x4 = (from p in dc.Size40_Products
                             where p.idProduct == product.id
                             select p).ToList();
                    if (x4.Count == 0)
                    {
                        error = "Sản phẩm này không có size " + size + "\nVui lòng chọn size khác\n";
                    }
                    else if (x4[0].quantity == 0)
                    {
                        error = "Sản phẩm này hết size " + size + "\nVui lòng chọn size khác\n";
                    }
                    else if (x4[0].quantity < quantity)
                    {
                        error = "Không đủ số lượng\nSize " + size + " của " + product.nameProduct + " chỉ còn " + x4[0].quantity + " " + (product.unit).ToLower();
                    }
                    break;
                case 41:
                    var x5 = (from p in dc.Size41_Products
                             where p.idProduct == product.id
                             select p).ToList();
                    if (x5.Count == 0)
                    {
                        error = "Sản phẩm này không có size " + size + "\nVui lòng chọn size khác\n";
                    }
                    else if (x5[0].quantity == 0)
                    {
                        error = "Sản phẩm này hết size " + size + "\nVui lòng chọn size khác\n";
                    }
                    else if (x5[0].quantity < quantity)
                    {
                        error = "Không đủ số lượng\nSize " + size + " của " + product.nameProduct + " chỉ còn " + x5[0].quantity + " " + (product.unit).ToLower();
                    }
                    break;
                case 42:
                    var x6 = (from p in dc.Size42_Products
                             where p.idProduct == product.id
                             select p).ToList();
                    if (x6.Count == 0)
                    {
                        error = "Sản phẩm này không có size " + size + "\nVui lòng chọn size khác\n";
                    }
                    else if (x6[0].quantity == 0)
                    {
                        error = "Sản phẩm này hết size " + size + "\nVui lòng chọn size khác\n";
                    }
                    else if (x6[0].quantity < quantity)
                    {
                        error = "Không đủ số lượng\nSize " + size + " của " + product.nameProduct + " chỉ còn " + x6[0].quantity + " " + (product.unit).ToLower();
                    }
                    break;
                default:
                    break;
            }
            
            if (!error.Equals(""))
            {
                MessageBox.Show(error, "Không còn hàng");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isInputValid()
        {
            string error="";

            if (comboBoxNameProduct.SelectedIndex == -1)
            {
                error = "Bạn hãy chọn sản phẩm";
                comboBoxNameProduct.Focusable = true;
                
            }
            else if (comboBoxSize.SelectedIndex ==-1)
            {
                error = "Bạn hãy chọn size";
                comboBoxSize.Focusable = true;
            }
            else
            {
                int quantity =-1;
                try
                {
                    quantity= Convert.ToInt32(quantityTxt.Text);
                }
                catch
                {
                    error = "Bạn hãy nhập lại số lượng hợp lệ\n";
                }

                if (quantity <= 0)
                {
                    error = "Số lượng phải >=0\n";
                }
            }

            if (!error.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            var customer = comboBoxCustomer.SelectedItem as CustomerDb;

            if (customer == null)
            {
                customer = (from p in dc.CustomerDbs where p.id == idUnregistedCustomer select p).Single(); // customer who unregist information
            }

            Receipt receipt = new Receipt(customer.id, DateTime.Now, sumMoney, sumScore);   

            dc.Receipts.InsertOnSubmit(receipt);    //insert new receipt
            try
            {
                dc.SubmitChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //get id of receipt has just inserted
            Receipt x = (from p in dc.Receipts
                         where p.idCustomer == receipt.idCustomer &&
                                 p.datePay == receipt.datePay && p.sumMoney == receipt.sumMoney 
                                && p.sumScore == receipt.sumScore
                         select p).Single();
            //add detail receipt into database
            for (int i = 0; i < listDetailReciept.Count; i++)
            {
                listDetailReciept[i].addInforDetailReceiptWhenPay(x.id, (int)x.idCustomer, x.datePay); //add more information
                DetailReceipt model = new DetailReceipt(listDetailReciept[i]);

                try
                {
                    dc.DetailReceipts.InsertOnSubmit(model);    //insert detail receipt
                    dc.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //decrease quantity product, decrease sumProduct
            decreaseQuantityProductsInDb();
            //increase bonus score and check type of customer
            increaseBonusScoreCustomerInDb(customer.id);

            try
            {
                dc.SubmitChanges();
                reloadData();
                dialogReceipt.IsOpen = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listDetailReciept = null;
        }

        private void increaseBonusScoreCustomerInDb(int idCustomer)
        {
            var modelCustomer = (from p in dc.CustomerDbs where p.id == idCustomer select p).Single();

            int updatedScore = modelCustomer.score + sumScore;
            //increase bonus score
            modelCustomer.score = updatedScore;
            //check type customer
            //update type customer base on new score
            var scoreType = (from p in dc.Score_TypeCustomers where p.minScore <= updatedScore orderby p.minScore descending select p).ToList();
            modelCustomer.typeCustomer = scoreType[0].id;

            try
            {
                dc.SubmitChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void decreaseQuantityProductsInDb()
        {
            for (int i = 0; i < listDetailReciept.Count; i++)
            {
                var model = listDetailReciept[i];

                var modelProductInDb = (from p in dc.ProductDbs where p.id == model.idProduct select p).Single();
                int count = modelProductInDb.sumQuantity;
                modelProductInDb.sumQuantity = count - model.quantity;

                switch (model.size)
                {
                    case 36:
                        var x1 = (from p in dc.Size36_Products where p.idProduct == model.idProduct select p).Single();
                        x1.quantity = x1.quantity - model.quantity;
                        dc.SubmitChanges();
                        break;
                    case 37:
                        var x2 = (from p in dc.Size37_Products where p.idProduct == model.idProduct select p).Single();
                        x2.quantity = x2.quantity- model.quantity;
                        dc.SubmitChanges();
                        break;
                    case 38:
                        var x3 = (from p in dc.Size38_Products where p.idProduct == model.idProduct select p).Single();
                        x3.quantity = x3.quantity- model.quantity;
                        dc.SubmitChanges();
                        break;
                    case 39:
                        var x4 = (from p in dc.Size39_Products where p.idProduct == model.idProduct select p).Single();
                        x4.quantity = x4.quantity - model.quantity;
                        dc.SubmitChanges();
                        break;
                    case 40:
                        var x5 = (from p in dc.Size40_Products where p.idProduct == model.idProduct select p).Single();
                        x5.quantity = x5.quantity - model.quantity;
                        dc.SubmitChanges();
                        break;
                    case 41:
                        var x6 = (from p in dc.Size41_Products where p.idProduct == model.idProduct select p).Single();
                        x6.quantity = x6.quantity - model.quantity;
                        dc.SubmitChanges();
                        break;
                    case 42:
                        var x7 = (from p in dc.Size42_Products where p.idProduct == model.idProduct select p).Single();
                        x7.quantity = x7.quantity - model.quantity;
                        dc.SubmitChanges();
                        break;
                }

            }
        }

        void reloadData()
        {
            try
            {
                ReceiptDataGrid.ItemsSource = null;
                var itemsource = new ReceiptVMs();
                ReceiptDataGrid.ItemsSource = itemsource.models;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void setUpDialogReceipt()
        {
            comboBoxNameProduct.ItemsSource = dc.ProductDbs;
            int[] size = new int[] { 36, 37, 38, 39, 40, 41, 42 };
            comboBoxSize.ItemsSource = size;
            quantityTxt.Text = "1";
            comboBoxCustomer.ItemsSource = dc.CustomerDbs;

            comboBoxCustomer.Visibility = Visibility.Visible;
            nameCustomerLable.Visibility = Visibility.Collapsed;
            order = 0;
            sumMoney = 0;
            sumScore = 0;
            SumMoneyLable.Content = "Tổng tiền: 0đ";
            SumScoreLable.Content = "Tổng điểm: 0";
            listDetailReciept = new List<DetailReceipt>();

            comboBoxNameProduct.SelectedIndex = 0;
            comboBoxSize.SelectedIndex = 0;
            comboBoxCustomer.SelectedIndex = 0;
            DetailReceiptDataGrid.ItemsSource = null;
        }

        private void bntCancel_Click(object sender, RoutedEventArgs e)
        {
            dialogReceipt.IsOpen = false;
        }

        private void bntCancelBuyProduct(object sender, RoutedEventArgs e)
        {
            var index = DetailReceiptDataGrid.SelectedIndex;
            listDetailReciept.RemoveAt(index);
            DetailReceiptDataGrid.ItemsSource = null;
            DetailReceiptDataGrid.ItemsSource = listDetailReciept;

        }

        private void bntDetail_Click(object sender, RoutedEventArgs e)
        {
            dialogReceiptDetailShow.IsOpen = true;
            DetailReceiptDataGridShow.ItemsSource = null;

            ReceiptViewModel selectModel = ReceiptDataGrid.SelectedItem as ReceiptViewModel;

            var x = (from p in dc.Receipts where p.id == selectModel.id select p).Single();
            var detailArr = (from p in dc.DetailReceipts where x.id == p.idReceipt select p).ToList();


            if (detailArr.Count > 0)
            {
                var itemsource = new DetailReiptVMs(detailArr);
                DetailReceiptDataGridShow.ItemsSource = itemsource.models;
                var cust = (from p in dc.CustomerDbs where p.id == selectModel.idCustomer select p).Single();
                lblNameCustomer.Content = cust.nameCustomer;

                SumMoneyLableShow.Content = "Tổng tiền: "+ selectModel.stringSumMoney;
                SumScoreLableShow.Content = "Tổng điểm: "+ selectModel.sumScore;
            }
           


        }

        private void bntClose_Click(object sender, RoutedEventArgs e)
        {
            dialogReceiptDetailShow.IsOpen = false;
        }
    }
}
