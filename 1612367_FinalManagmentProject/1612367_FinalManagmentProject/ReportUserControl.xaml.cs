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
using LiveCharts;
using LiveCharts.Wpf;

namespace _1612367_FinalManagmentProject
{
    /// <summary>
    /// Interaction logic for ReportUserControl.xaml
    /// </summary>
    public partial class ReportUserControl : UserControl
    {
        DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.ManagementProjectConnectionString);
        List<String> time = new List<string> { "Ngày", "Tháng", "Năm" };
        DateTime start, end;

        class StatisticProduct
        {
            public string nameType { get; set; }
            public int quantity { get; set; }
            public int idProduct { get; set; }
            public StatisticProduct(int id, int x)
            {
                this.idProduct = id;
                quantity = x;
            }
        }

        class StatisticInterest
        {
            public string nameType { get; set; }
            public long interest { get; set; }
            public int idProduct { get; set; }
            public StatisticInterest(int id, long x)
            {
                this.idProduct = id;
                interest = x;
            }
        }

        public SeriesCollection SeriesCollectionTypeProduct { get; set; }
        public string[] LabelsTypeProduct { get; set; }
        public Func<double, string> YFormatterTypeProduct { get; set; }


        public SeriesCollection SeriesCollection2{ get; set; }
        public string[] Labels2 { get; set; }
        public Func<double, string> YFormatter2 { get; set; }

        public ReportUserControl()
        {
            InitializeComponent();
            cbTimeStatistic.ItemsSource = time;
            cbTimeStatistic.SelectedIndex = 0;

            startDate.SelectedDate = DateTime.Now;
            endDate.SelectedDate = DateTime.Now;
        }
       
        private void btnStatistic_Click(object sender, RoutedEventArgs e)
        {
            if (isInputValid())
            {

                 start = startDate.SelectedDate.Value;
                 end = endDate.SelectedDate.Value;
                
                int x = cbTimeStatistic.SelectedIndex;
                findCustomer(x);
                findProduct(x);
                setUpChartTypeProduct(x);
                setUpChartInterest(x);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"> x là tiêu chí chọn</param>
       private void findCustomer(int x)
        {
            string name="";
            int score=0;

            switch (x)
            {
                case 0: //day
                    var y1 = dc.Receipts.Where(a=> (a.datePay >= start && a.datePay <= end))
                        .GroupBy(a => a.idCustomer)
                        .Select(a => new { id = a.Key, sum = a.Sum(b => b.sumScore) })
                        .OrderByDescending(a => a.sum)
                        .ToList();
                    if (y1.Count > 0)
                    {
                        //get customer
                        var model = (from p in dc.CustomerDbs where p.id == y1[0].id select p).Single();
                        name = model.nameCustomer;
                        score = model.score;
                    }
                    break;
                case 1: //month
                    var y2 = dc.Receipts.Where(a => (start.Year < end.Year && a.datePay.Year >= start.Year && a.datePay.Year <= end.Year)
                        || (a.datePay.Month >= start.Month && a.datePay.Month <= end.Month))
                        .GroupBy(a => a.idCustomer)
                        .Select(a => new { id = a.Key, sum = a.Sum(b => b.sumScore) })
                        .OrderByDescending(a => a.sum)
                        .ToList();
                    if (y2.Count > 0)
                    {
                        //get customer
                        var model = (from p in dc.CustomerDbs where p.id == y2[0].id select p).Single();
                        name = model.nameCustomer;
                        score = model.score;
                    }
                    break;
                case 2: //year
                    var y3 = dc.Receipts.Where(a => a.datePay.Year >= start.Year && a.datePay.Year <= end.Year)
                        .GroupBy(a => a.idCustomer)
                        .Select(a => new { id = a.Key, sum = a.Sum(b => b.sumScore) })
                        .OrderByDescending(a => a.sum)
                        .ToList();
                    if (y3.Count > 0)
                    {
                        //get customer
                        var model = (from p in dc.CustomerDbs where p.id == y3[0].id select p).Single();
                        name = model.nameCustomer;
                        score = model.score;
                    }
                    break;
            }

            nameCustomerlbl.Content = name;
            scoreCustomerlbl.Content = score.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"> x là tiêu chí chọn</param>
        private void findProduct(int x)
        {
            string name="";
            int quantity = 0;
            switch (x)
            {
                case 0: //day
                    var y1 = dc.DetailReceipts.Where(a => (a.datePay >= start && a.datePay <= end))
                        .GroupBy(a => a.idProduct)
                        .Select(a => new { id = a.Key, sum = a.Sum(b => b.quantity) })
                        .OrderByDescending(a => a.sum)
                        .ToList();
                    if (y1.Count > 0)
                    {
                        //get product
                        var model = (from p in dc.ProductDbs where p.id == y1[0].id select p).Single();
                        name = model.nameProduct;
                        quantity = model.sumQuantity;
                    }
                    break;
                case 1: //month
                    var y2 = dc.DetailReceipts.Where(a => (start.Year < end.Year && a.datePay.Year >= start.Year && a.datePay.Year<= end.Year) 
                        ||(a.datePay.Month >= start.Month && a.datePay.Month <= end.Month))
                        .GroupBy(a => a.idProduct)
                        .Select(a => new { id = a.Key, sum = a.Sum(b => b.quantity) })
                        .OrderByDescending(a => a.sum)
                        .ToList();
                    if (y2.Count > 0)
                    {
                        //get product
                        var model = (from p in dc.ProductDbs where p.id == y2[0].id select p).Single();
                        name = model.nameProduct;
                        quantity = model.sumQuantity;
                    }
                    break;
                case 2: //year
                    var y3 = dc.DetailReceipts.Where(a => a.datePay.Year >= start.Year && a.datePay.Year <= end.Year)
                        .GroupBy(a => a.idProduct)
                        .Select(a => new { id = a.Key, sum = a.Sum(b => b.quantity) })
                        .OrderByDescending(a => a.sum)
                        .ToList();
                    if (y3.Count > 0)
                    {
                        //get product
                        var model = (from p in dc.ProductDbs where p.id == y3[0].id select p).Single();
                        name = model.nameProduct;
                        quantity = model.sumQuantity;
                    }
                    break;
            }
            nameProductlbl.Content = name;
            quantityProductlbl.Content = quantity.ToString();
        }
        
        private bool isInputValid()
        {
            string error = "";
            DateTime startDateInput = startDate.SelectedDate.Value;
            DateTime endDateInput = endDate.SelectedDate.Value;
            
            if (DateTime.Compare(startDateInput, endDateInput) >= 0)
            {
                error = "Ngày bắt đầu phải nhỏ hơn ngày kết thúc\n";
                MessageBox.Show(error);
                return false;
            }
            return true;
        }


        private void setUpChartTypeProduct(int typeStatistic)
        {
            List<StatisticProduct> y = new List<StatisticProduct>();

            switch (typeStatistic)
            {
                case 0:
                    y = dc.DetailReceipts.Where(a => (a.datePay >= start && a.datePay <= end))
                      .GroupBy(a => a.idTypeProduct)
                      .Select(a => new StatisticProduct (a.Key, a.Sum(b => b.quantity) ))
                      .ToList();
                    break;
                case 1:
                    y = dc.DetailReceipts.Where(a => (start.Year < end.Year && a.datePay.Year >= start.Year && a.datePay.Year <= end.Year))
                      .GroupBy(a => a.idTypeProduct)
                      .Select(a => new StatisticProduct(a.Key, a.Sum(b => b.quantity)))
                      .ToList();
                    break;
                case 2:
                    y = dc.DetailReceipts.Where(a => a.datePay.Year >= start.Year && a.datePay.Year <= end.Year)
                      .GroupBy(a => a.idTypeProduct)
                      .Select(a => new StatisticProduct(a.Key, a.Sum(b => b.quantity)))
                      .ToList();
                    break;

            }

            List<StatisticProduct> listData = new List<StatisticProduct>();
            SeriesCollectionTypeProduct = new SeriesCollection();

            for (int i = 0; i < y.Count; i++)
            {
                //get name type product
                var x = (from p in dc.CategoryDbs where p.id == y[i].idProduct select p).Single();
                //listData.Add(new StatisticProduct(x.nameType, y[i].sum));
                y[i].nameType = x.nameType;
                var line = new LineSeries
                {
                    Title = x.nameType,
                    Values = new ChartValues<double> { y[i].quantity }
                };

                SeriesCollectionTypeProduct.Add(line);
            }

            LabelsTypeProduct = new[] {"Từ "+ start.ToShortDateString() +" đến "+ end.ToShortDateString() };
            //DataContext = this;
        }

        private void setUpChartInterest(int typeStatistic)
        {
            List<StatisticInterest> y = new List<StatisticInterest>();

            switch (typeStatistic)
            {
                case 0:
                    y = dc.DetailReceipts.Where(a => (a.datePay >= start && a.datePay <= end))
                      .GroupBy(a => a.idTypeProduct)
                      .Select(a => new StatisticInterest(a.Key, a.Sum(b => (long)b.interest)))
                      .ToList();
                    break;
                case 1:
                    y = dc.DetailReceipts.Where(a => (start.Year < end.Year && a.datePay.Year >= start.Year && a.datePay.Year <= end.Year))
                      .GroupBy(a => a.idTypeProduct)
                      .Select(a => new StatisticInterest(a.Key, a.Sum(b => (long)b.interest)))
                      .ToList();
                    break;
                case 2:
                    y = dc.DetailReceipts.Where(a => a.datePay.Year >= start.Year && a.datePay.Year <= end.Year)
                      .GroupBy(a => a.idTypeProduct)
                      .Select(a => new StatisticInterest(a.Key, a.Sum(b => (long)b.interest)))
                      .ToList();
                    break;

            }

            SeriesCollection2 = new SeriesCollection();

            for (int i = 0; i < y.Count; i++)
            {
                //get name type product
                var x = (from p in dc.CategoryDbs where p.id == y[i].idProduct select p).Single();
                //listData.Add(new StatisticProduct(x.nameType, y[i].sum));
                y[i].nameType = x.nameType;
                var line = new LineSeries
                {
                    Title = x.nameType,
                    Values = new ChartValues<double> { y[i].interest }
                };

                SeriesCollection2.Add(line);
            }
            Labels2 = new[] { "Từ " + start.ToShortDateString() + " đến " + end.ToShortDateString() };
            DataContext = this;
        }
    }
}
