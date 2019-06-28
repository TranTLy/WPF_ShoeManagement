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
    /// Interaction logic for DiscountUserControl1.xaml
    /// </summary>
    public partial class DiscountUserControl1 : UserControl
    {
        DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.ManagementProjectConnectionString);
        bool isManager;

        public DiscountUserControl1()
        {
            isManager = true;
            InitializeComponent();
            VMs itemsource = new VMs();

            DiscountDataGrid.ItemsSource = itemsource.getViewModel();
        }

        public DiscountUserControl1(bool isManager)
        {
            this.isManager = isManager;
            InitializeComponent();
            VMs itemsource = new VMs();

            DiscountDataGrid.ItemsSource = itemsource.getViewModel();

            if (!isManager)
            {
                btnAdd.Visibility = Visibility.Hidden;
            }

        }

        private void reloadData()
        {
            DiscountDataGrid.ItemsSource = null;
            VMs itemsource = new VMs();
            DiscountDataGrid.ItemsSource = itemsource.getViewModel();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            dialogDiscount.IsOpen = true;
            setupDialog();
            btnSaveDiscount.Visibility = Visibility.Collapsed;
            btnAddDiscount.Visibility = Visibility.Visible;
        }

        private void bntEditCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (isManager)
            {
                //Kiểm tra xem discount này đã được áp dụng vào hóa đơn nào chưa
                var discountVM = DiscountDataGrid.SelectedItem as ViewModel;
                var x = (from p in dc.DetailReceipts where p.idDiscount == discountVM.id select p).ToList();
                if (x.Count > 0)
                {
                    MessageBox.Show("Ưu đãi này đã được áp dụng trong hóa đơn nên không thể chỉnh sửa\n");
                }
                else
                {
                    dialogDiscount.IsOpen = true;
                    setupDialog();
                    btnSaveDiscount.Visibility = Visibility.Visible;
                    btnAddDiscount.Visibility = Visibility.Collapsed;
                    //fill data in dialog
                    nameDiscountTxt.Text = discountVM.nameDiscount;
                    startDate.SelectedDate = discountVM.startDate;
                    endDate.SelectedDate = discountVM.endDate;
                    percentDiscountTxt.Text = discountVM.percentageDiscount.ToString();
                    
                    CategoryDb typeProcut = (from p in dc.CategoryDbs where p.id == discountVM.idProduct select p).Single();
                    comboBoxTypeProduct.SelectedItem = typeProcut;
                    Score_TypeCustomer typeCustomer = (from p in dc.Score_TypeCustomers where p.id == discountVM.idTypeCustomer select p).Single();
                    comboBoxTypeCustomer.SelectedItem = typeCustomer;
                }
            }
        }

        private void setupDialog()
        {
            //DiscountDataGrid
            comboBoxStatusDiscount.ItemsSource = new List<String> { "Hết hạn", "Đang áp dụng"};
            comboBoxTypeCustomer.ItemsSource = dc.Score_TypeCustomers;
            comboBoxTypeProduct.ItemsSource = dc.CategoryDbs;
            startDate.SelectedDate = DateTime.Now;
            endDate.SelectedDate = DateTime.Now;

            try
            {
                comboBoxTypeCustomer.SelectedIndex = 0;
                comboBoxTypeProduct.SelectedIndex = 0;
            }
            catch
            {
                //out of range
            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (isManager)
            {
                //Kiểm tra xem discount này đã được áp dụng vào hóa đơn nào chưa
                
                try
                {
                    var discountVM = DiscountDataGrid.SelectedItem as ViewModel;
                    var x = (from p in dc.DetailReceipts where p.idDiscount == discountVM.id select p).ToList();
                    if (x.Count > 0)
                    {
                        MessageBox.Show("Ưu đãi này đã được áp dụng trong hóa đơn nên không thể xóa\n");
                    }
                    else //xóa
                    {
                        MessageBoxButton mesBox = MessageBoxButton.YesNo;
                        MessageBoxResult result = MessageBox.Show("Bạn có thật sư muốn xóa ưu đãi này?",
                            "Xác nhận", mesBox, MessageBoxImage.Question);
                        if (result == MessageBoxResult.Yes)
                        {
                            var modelDb = (from p in dc.DiscountDbs where p.id == discountVM.id select p).Single();
                            try
                            {
                                dc.DiscountDbs.DeleteOnSubmit(modelDb);
                                dc.SubmitChanges();
                                reloadData();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                

            }
        }

        private void btnAddDiscount_Click(object sender, RoutedEventArgs e)
        {
            if (checkInput())
            {
                string nameDiscountInput = nameDiscountTxt.Text; 
                 DateTime startDateInput = (DateTime)startDate.SelectedDate;
                DateTime endDateInput = (DateTime)endDate.SelectedDate;
                CategoryDb productInput = comboBoxTypeProduct.SelectedValue as CategoryDb;
                Score_TypeCustomer customerInput = comboBoxTypeCustomer.SelectedValue as Score_TypeCustomer;
                int percentageInput = Convert.ToInt32(percentDiscountTxt.Text);

                DiscountDb newDiscount = new DiscountDb(nameDiscountInput, productInput.id, customerInput.id, 1, startDateInput, endDateInput, percentageInput);
                dc.DiscountDbs.InsertOnSubmit(newDiscount);
                try
                {
                    dc.SubmitChanges();
                    reloadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi", ex.Message);
                }
                dialogDiscount.IsOpen = false;
            }
        }

        public bool checkInput()
        {
            string error = "";

            string nameDiscountInput = nameDiscountTxt.Text;
            DateTime startDateInput = (DateTime)startDate.SelectedDate;
            DateTime endDateInput = (DateTime)endDate.SelectedDate;

            if (nameDiscountInput.Equals(""))
            {
                error = "Vui lòng nhập tên ưu đãi";
            }

            else
            {
                int percentageInput = 0;
                try
                {
                    percentageInput = Convert.ToInt32(percentDiscountTxt.Text);
                }
                catch
                {
                    error = "Vui lòng nhập lại phần trăm ưu đãi (Chỉ nhập số, ví dụ: 10)";
                }

                //Kiểm tra này tháng
                DateTime dt = DateTime.Now;
                TimeSpan ts = new TimeSpan(0, 0, 0);
                dt = dt.Date + ts;

                if (DateTime.Compare(startDateInput, dt) < 0)
                {
                    error = "Ngày bắt đầu phải lớn hơn hoặc bằng này hiện tại\n";
                    startDate.IsDropDownOpen = true;
                }
                else if ((DateTime.Compare(startDateInput, endDateInput) > 0))
                {
                    error = "Thời gian kết thúc phải lớn lơn hoặc bằng thời gian bắt đầu ";
                    endDate.IsDropDownOpen = true;
                }
            }

            if (!error.Equals(""))
            {
                MessageBox.Show("Lỗi", error);
                return false;
            }
            else
            {
                return true;
            }

        }

        private void bntSaveDiscount_Click(object sender, RoutedEventArgs e)
        {
            if (checkInput())
            {
                var discountVM = DiscountDataGrid.SelectedItem as ViewModel;
                var modelDb = (from p in dc.DiscountDbs where p.id == discountVM.id select p).Single();

                modelDb.nameDiscount = nameDiscountTxt.Text;
                modelDb.startDate = (DateTime)startDate.SelectedDate;
                modelDb.endDate = (DateTime)endDate.SelectedDate;
                CategoryDb productInput = comboBoxTypeProduct.SelectedValue as CategoryDb;
                modelDb.idProduct = productInput.id;
                Score_TypeCustomer customerInput = comboBoxTypeCustomer.SelectedValue as Score_TypeCustomer;
                modelDb.idTypeCustomer = customerInput.id;
                int percentageInput = Convert.ToInt32(percentDiscountTxt.Text);
                modelDb.percentageDiscount = percentageInput;
                modelDb.statusDiscount = 1;

                try
                {
                    dc.SubmitChanges();
                    reloadData();
                    dialogDiscount.IsOpen = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

        }

        private void btnCancelAddDiscount_Click(object sender, RoutedEventArgs e)
        {
            dialogDiscount.IsOpen = false;
        }

        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {
            var discountVM = DiscountDataGrid.SelectedItem as ViewModel;

            dialogDiscount.IsOpen = true;
            setupDialog();
            btnSaveDiscount.Visibility = Visibility.Visible;
            btnAddDiscount.Visibility = Visibility.Collapsed;
            //fill data in dialog
            nameDiscountTxt.Text = discountVM.nameDiscount;
            startDate.SelectedDate = discountVM.startDate;
            endDate.SelectedDate = discountVM.endDate;
            percentDiscountTxt.Text = discountVM.percentageDiscount.ToString();

            CategoryDb typeProcut = (from p in dc.CategoryDbs where p.id == discountVM.idProduct select p).Single();
            comboBoxTypeProduct.SelectedItem = typeProcut;
            Score_TypeCustomer typeCustomer = (from p in dc.Score_TypeCustomers where p.id == discountVM.idTypeCustomer select p).Single();
            comboBoxTypeCustomer.SelectedItem = typeCustomer;

            btnAddDiscount.Visibility = Visibility.Hidden;
            btnSaveDiscount.Visibility = Visibility.Collapsed;
        }
    }
}
