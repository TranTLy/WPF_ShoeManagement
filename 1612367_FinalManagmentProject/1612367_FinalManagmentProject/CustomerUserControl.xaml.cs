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
using System.Text.RegularExpressions;

namespace _1612367_FinalManagmentProject
{
    /// <summary>
    /// Interaction logic for CustomerUserControl.xaml
    /// </summary>
    public partial class CustomerUserControl : UserControl
    {
        DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.ManagementProjectConnectionString);
        const int idUnregistCustomer = 3;
        public CustomerUserControl()
        {
            InitializeComponent();
            CustomerVMs itemsource = new CustomerVMs( dc.CustomerDbs.ToList());
            CustomerDataGrid.ItemsSource = itemsource.getCustomerViewModel();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int row = CustomerDataGrid.SelectedIndex;
            if (row != -1)
            {
                
                var selectVM = CustomerDataGrid.SelectedItem as CustomerViewModel;
                if (selectVM.id == idUnregistCustomer)
                {
                    MessageBox.Show("Không được xóa khách hàng này\n");
                    return;
                }
                //todo: Kiểm tra hóa đơn liên quan, nếu có thì không được xóa
                var receipt = (from p in dc.Receipts where p.idCustomer == selectVM.id select p).ToList();
                if (receipt.Count > 0)
                {
                    MessageBox.Show("Dữ liệu của khách hàng này có trong hóa đơn nên không được xóa\n");
                    return;
                }
                

                MessageBoxButton mesBox = MessageBoxButton.YesNo;
                MessageBoxResult result = MessageBox.Show("Bạn có thật sư muốn xóa khách hàng này?",
                   "Xác nhận", mesBox, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    CustomerViewModel customer = CustomerDataGrid.SelectedItem as CustomerViewModel;
                    var model = (from p in dc.CustomerDbs where p.id == customer.id select p).Single();

                    try
                    {
                        dc.CustomerDbs.DeleteOnSubmit(model);
                        dc.SubmitChanges();
                        reloadData();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }
        }

        private void reloadData()
        {
            //reload

            CustomerVMs itemsource = new CustomerVMs(dc.CustomerDbs.ToList());
            CustomerDataGrid.ItemsSource = null;
            CustomerDataGrid.ItemsSource = itemsource.getCustomerViewModel();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            dialogCustomer.IsOpen = true;
            setUpDialog();
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            string messageError = "";

            if (!checkInput())
            {
                MessageBox.Show("Lỗi", "Nhập dữ liệu sai");
            }
            else
            {
                String name = nameCustomerTxt.Text;
                String phoneNumer = phoneNumberTxt.Text;
                var dateOfBirth = dateOB.SelectedDate.Value.Date;

                CustomerDb newCustomer = new CustomerDb(name, phoneNumer, dateOfBirth);
                dc.CustomerDbs.InsertOnSubmit(newCustomer);
                try
                {
                    dc.SubmitChanges();
                }
                catch (Exception except)
                {
                    //error
                    messageError = "Lưu dữ liệu không thành công";
                    MessageBox.Show("Lỗi", except.Message);
                }
            }
            
            if (!messageError.Equals(""))
            {
                MessageBox.Show("Lỗi", messageError);
            }
            else
            {
                MessageBox.Show("Thành công", "Lưu thành công");
                dialogCustomer.IsOpen = false;
                reloadData();
            }


        }

        bool checkInput()
        {
            bool result = false ;
            //Kiem tra
            String name = nameCustomerTxt.Text;
            String phoneNumer = phoneNumberTxt.Text;
            DateTime dateOfBirth = (DateTime)dateOB.SelectedDate;

            String messageError = "";
            Regex regex = new Regex("[^0-9., -]+");

            if (name.Equals(""))
            {
                messageError = "Vui lòng nhập tên của bạn\n";
                nameCustomerTxt.Focusable = true;
                result = false;
                //todo: show error
            }
            else if (regex.IsMatch(phoneNumer))
            {
                messageError = "Số điện thoại không hợp lệ";
                phoneNumberTxt.Focusable = true;
                result = false;
                //todo: show error
            }
            else if (DateTime.Compare(dateOfBirth, DateTime.Now)>0)
            {
                messageError = "Ngày sinh không hợp lệ\n";
                result = false;
            }
            else
            {
                result = true;
            }

            if (result == false)
            {
                MessageBox.Show("Lỗi", messageError);
            }
            return result;
        }

        private void btnCancelAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            dialogCustomer.IsOpen = false;
        }

        private void bntEditCustomer_Click(object sender, RoutedEventArgs e)
        {
            int row = CustomerDataGrid.SelectedIndex;
            if (row != -1)
            {
                dialogCustomer.IsOpen = true;
                btnSaveCustomer.Visibility = Visibility.Visible;
                btnAddCustomer.Visibility = Visibility.Collapsed;

                CustomerDb customer = CustomerDataGrid.SelectedItem as CustomerDb;
                nameCustomerTxt.Text = customer.nameCustomer;
                phoneNumberTxt.Text = customer.phoneNumber;
                dateOB.SelectedDate = customer.dateOfBirth;
            }
        }

        private void bntSaveCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (!checkInput())
            {
                //showError
            }
            else
            {

                String name = nameCustomerTxt.Text;
                String phoneNumer = phoneNumberTxt.Text;
                DateTime dateOfBirth = (DateTime)dateOB.SelectedDate;

                CustomerDb customer = CustomerDataGrid.SelectedItem as CustomerDb;

                var customerInDb = from db in dc.CustomerDbs where db.id == customer.id select db;
                foreach(CustomerDb x in customerInDb)
                {
                    x.nameCustomer = name;
                    x.phoneNumber = phoneNumer;
                    x.dateOfBirth = dateOfBirth;
                }

                try
                {
                    dc.SubmitChanges();
                    reloadData();
                }
                catch
                {
                    //show error
                }
                dialogCustomer.IsOpen = false;
            }
        }

        private void setUpDialog()
        {
            nameCustomerTxt.Text = "";
            phoneNumberTxt.Text = "";
        }
    }
}
