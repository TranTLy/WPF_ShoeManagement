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
    /// Interaction logic for Sales.xaml
    /// </summary>
    public partial class Sales : Window
    {
        const int PRODUCT = 0;
        const int DISCOUNT = 1;
        const int CUSTOMER = 2;
        const int BILL = 3;
        const int STAFF = 4; //uncomplete, in order to expand

        public Sales()
        {
            InitializeComponent();
        }

        private void ExpandMenuButton_Click(object sender, RoutedEventArgs e)
        {
            ExpandMenuButton.Visibility = Visibility.Collapsed;
            ClollapedMenuButton.Visibility = Visibility.Visible;
        }

        private void ClollapedMenuButton_Click(object sender, RoutedEventArgs e)
        {
            ExpandMenuButton.Visibility = Visibility.Visible;
            ClollapedMenuButton.Visibility = Visibility.Collapsed;
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch
            {
                //error
            }
            
        }

        private void DropMenuUser_MouseLeave(object sender, MouseEventArgs e)
        {
            DropMenuUser.Visibility = Visibility.Collapsed;
        }

        private void shutdownButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var index = MenuList.SelectedIndex;

            switch (index)
            {
                case PRODUCT:
                    GridContent.Children.Clear();
                    GridContent.Children.Add(new Product(false));
                    break;
                case DISCOUNT:
                    GridContent.Children.Clear();
                    GridContent.Children.Add(new DiscountUserControl1(false));
                    break;
                case CUSTOMER:
                    GridContent.Children.Clear();
                    GridContent.Children.Add(new CustomerUserControl());
                    break;
                case STAFF:
                    GridContent.Children.Clear();

                    break;
                case BILL:
                    GridContent.Children.Clear();
                    GridContent.Children.Add(new BillUserControl1());
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

        private void Title_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void UserButton_MouseMove(object sender, MouseEventArgs e)
        {
            DropMenuUser.Visibility = Visibility.Visible;
        }
    }
}
