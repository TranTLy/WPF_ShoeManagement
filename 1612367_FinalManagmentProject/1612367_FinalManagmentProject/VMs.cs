using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1612367_FinalManagmentProject
{
    class VMs   //Discount view models
    {
        private List<ViewModel> models { get; set; }

        public VMs()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.ManagementProjectConnectionString);
            List<DiscountDb> modelsDb = dc.DiscountDbs.ToList();

            models = new List<ViewModel>();

            int n = modelsDb.Count;
            for (int i = 0; i < n; i++)
            {
                DiscountDb model = modelsDb[i];

                CategoryDb product = (from p in dc.CategoryDbs where p.id == model.idProduct select p).Single();
                String nameProduct = product.nameType;
                Score_TypeCustomer typeCustomer = (from p in dc.Score_TypeCustomers where p.id == model.idTypeCustomer select p).Single();
                string nameTypeProduct = typeCustomer.nameTypeCustomer;

                if (DateTime.Compare(model.endDate, DateTime.Now) < 0) //discount is out of date
                {
                    modelsDb[i].statusDiscount = 0;
                    dc.SubmitChanges();
                }
                string status = modelsDb[i].statusDiscount == 1 ? "Đang áp dụng" : "Hết hạn";
                int order = i + 1;

                if (nameProduct != null && nameProduct != null)
                {
                    ViewModel newItem = new ViewModel(model, nameProduct, nameTypeProduct, status, order);
                    models.Add(newItem);
                }
            }
        }




        public List<ViewModel> getViewModel()
        {
            return models;
        }
    }

    class CustomerVMs
    {
        List<CustomerViewModel> models;

        public CustomerVMs(List<CustomerDb> modelsDb)
        {
            models = new List<CustomerViewModel>();
            DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.ManagementProjectConnectionString);
            int n = modelsDb.Count;

            for (int i = 0; i < n; i++)
            {
                CustomerDb model = modelsDb[i];
                Score_TypeCustomer x = (from p in dc.Score_TypeCustomers where p.id == model.typeCustomer select p).Single();
                string nameTypeCustomer = x.nameTypeCustomer;

                if (nameTypeCustomer == null)
                {
                    nameTypeCustomer = "";
                }

                models.Add(new CustomerViewModel(model, i + 1, nameTypeCustomer));
            }
        }
        public List<CustomerViewModel> getCustomerViewModel()
        {
            return models;
        }
    }

    class ProductVMs
    {
        List <ProductViewModel> models { get; set; }

        public ProductVMs(List<ProductDb> modelDb)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.ManagementProjectConnectionString);
            models = new List<ProductViewModel>();

            int n = modelDb.Count;
            for (int i = 0; i < n; i++)
            {
                ProductDb model = modelDb[i];
                CategoryDb x = (from p in dc.CategoryDbs where p.id == model.category select p).Single();
                String nameCategory = x.nameType;
                models.Add(new ProductViewModel(model, i + 1, nameCategory));
            }
        }

        public List<ProductViewModel> getProductViewModel()
        {
            return models;
        }
    }

    class ProductSizeQuantityVMs
    {
        List<ProductSizeQuantityViewModel> modelsView { get; set; }
        public int sumProduct { get; set; }

        public ProductSizeQuantityVMs()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.ManagementProjectConnectionString);
            modelsView = new List<ProductSizeQuantityViewModel>();
            sumProduct = 0;

            List<ProductDb> modelDataProduct = dc.ProductDbs.ToList();

            int n = modelDataProduct.Count;
            for (int i = 0; i < n; i++)
            {
                ProductDb model = modelDataProduct[i];
                CategoryDb x = (from p in dc.CategoryDbs where p.id == model.category select p).Single();
                String nameCategory = x.nameType;
                int[] arr = addSizeQuantity(model.id);
                sumProduct += arr.Sum();
                modelsView.Add(new ProductSizeQuantityViewModel(model.id, nameCategory, model.nameProduct, arr, i+1));
            }
        }

        /// <summary>
        /// Hàm lấy số lượng sản phẩm theo size (từ 36 đến 42)
        /// </summary>
        /// <param name="idProduct"></param>
        /// <returns>Mảng chứa số lượng sản phẩm</returns>
        public int[] addSizeQuantity(int idProduct)
        {
            int[] arrSizeQuantity = new int[7] { 0,0,0,0,0,0,0};
            int minSize = 36;
            DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.ManagementProjectConnectionString);

            var x1 = (from p in dc.Size36_Products where p.idProduct == idProduct select p).ToList();
            if (x1.Count > 0)
            {
                arrSizeQuantity[36 - minSize] = x1[0].quantity;
            }
            
            var x2 = (from p in dc.Size37_Products where p.idProduct == idProduct select p).ToList();
            if (x2.Count > 0)
            {
                arrSizeQuantity[37 - minSize] = x2[0].quantity;
            }
           
            var x3 = (from p in dc.Size38_Products where p.idProduct == idProduct select p).ToList();
            if (x3.Count > 0)
            {
                arrSizeQuantity[38 - minSize] = x3[0].quantity;
            }
            
            var x4 = (from p in dc.Size39_Products where p.idProduct == idProduct select p).ToList();
            if (x4.Count > 0)
            {
                arrSizeQuantity[39 - minSize] = x4[0].quantity;
            }
            
            var x5 = (from p in dc.Size40_Products where p.idProduct == idProduct select p).ToList();
            if (x5.Count > 0)
            {
                arrSizeQuantity[40 - minSize] = x5[0].quantity;
            }
           
            var x6 = (from p in dc.Size41_Products where p.idProduct == idProduct select p).ToList();
            if (x6.Count > 0)
            {
                arrSizeQuantity[41 - minSize] = x6[0].quantity;
            }

            var x7 = (from p in dc.Size42_Products where p.idProduct == idProduct select p).ToList();
            if (x7.Count > 0)
            {
                arrSizeQuantity[42 - minSize] = x7[0].quantity;
            }

            return arrSizeQuantity;
        }

        public List<ProductSizeQuantityViewModel> getProductViewModel()
        {
            return modelsView;
        }
    }

    class ReceiptVMs
    {
        public List<ReceiptViewModel> models { get; set; }
        DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.ManagementProjectConnectionString);

        public ReceiptVMs()
        {
            models = new List<ReceiptViewModel>();

            var modelsDb = dc.Receipts.ToList();

            int n = modelsDb.Count;

            for (int i=0; i < n; i++)
            {
                Receipt model = modelsDb[i];
                //get name customer
                var x = (from p in dc.CustomerDbs where p.id==model.idCustomer select p).Single();

                models.Add(new ReceiptViewModel(x.nameCustomer, model, i + 1));
            }
        }
    }

    class DetailReiptVMs
    {
        public List<DetailReceiptViewModel> models { get; set; }
        DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.ManagementProjectConnectionString);

        public DetailReiptVMs(List <DetailReceipt> modelsDb)
        {
            models = new List<DetailReceiptViewModel>();
            //get name
            int x = modelsDb.Count;
            for (int i = 0; i < x; i++)
            {
                models.Add(new DetailReceiptViewModel(modelsDb[i], i + 1));
            }
        }
    }

}
