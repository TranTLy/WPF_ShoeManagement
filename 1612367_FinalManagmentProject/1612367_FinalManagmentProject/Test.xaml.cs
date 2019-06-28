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
using System.Windows.Shapes;

namespace _1612367_FinalManagmentProject
{
    /// <summary>
    /// Interaction logic for Test.xaml
    /// </summary>
    ///
    public partial class Test : Window
    {
        const int WIDTH = 1024;
        const int WIDTH_MENU_EXPAND = 200;
        const int WIDTH_MENU_COLLAPSE = 70;
        const int PRODUCT = 0;
        const int WAREHOUSE = 1;
        const int DISCOUNT = 2;
        const int REPORT = 3;
        const int CUSTOMER = 4;
        const int BILL = 5;
        const int STAFF = 6;

        public Test()
        {
            InitializeComponent();
        }

        private void shutdownButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Title_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //DragMove();
        }

        private void ExpandMenuButton_Click(object sender, RoutedEventArgs e)
        {
            ExpandMenuButton.Visibility = Visibility.Collapsed;
            ClollapedMenuButton.Visibility = Visibility.Visible;
            //GridContent.Margin = new Thickness(60, 10, 10, 10);
        }

        private void ClollapedMenuButton_Click(object sender, RoutedEventArgs e)
        {
            ExpandMenuButton.Visibility = Visibility.Visible;
            ClollapedMenuButton.Visibility = Visibility.Collapsed;
            //GridContent.Margin = new Thickness(10, 10, 10, 10);
        }
      
        private void UserButton_MouseMove(object sender, MouseEventArgs e)
        {
            DropMenuUser.Visibility = Visibility.Visible;
        }

        private void DropMenuUser_MouseLeave(object sender, MouseEventArgs e)
        {
            DropMenuUser.Visibility = Visibility.Collapsed;
        }

        private void MenuList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var index = MenuList.SelectedIndex;

            switch (index)
            {
                case PRODUCT:
                    //TODO
                    GridContent.Children.Clear();
                    GridContent.Children.Add(new Product());
                    break;
                case WAREHOUSE:
                    GridContent.Children.Clear();
                    GridContent.Children.Add(new WareHouseUserControl());
                    break;
                case DISCOUNT:
                    GridContent.Children.Clear();
                    GridContent.Children.Add(new DiscountUserControl1());
                    break;
                case REPORT:
                    GridContent.Children.Clear();
                    GridContent.Children.Add(new ReportUserControl());
                    break;
                case CUSTOMER:
                    GridContent.Children.Clear();
                    GridContent.Children.Add(new CustomerUserControl());
                    break;
                case BILL:
                    GridContent.Children.Clear();
                    GridContent.Children.Add(new BillUserControl1());
                    break;
                case STAFF:
                    GridContent.Children.Clear();

                    break;
                default:
                    break;
            }

            moveCursorSlide(index);
        }

        private void moveCursorSlide(int index)
        {
            TrainsitionContentSlide.OnApplyTemplate();
            CursorSlide.Margin = new Thickness(0, 70 * index + 10, 0, 0);
        }


        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    dc.SubmitChanges();
        //}
    }
}
