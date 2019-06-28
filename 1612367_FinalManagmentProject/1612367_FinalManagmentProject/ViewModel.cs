using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1612367_FinalManagmentProject
{
    class ViewModel : DiscountDb
    {
        //DiscountDb model { get; set; }
        public string nameProduct { get; set; }
        public string nameTypeCustomer { get; set; }
        public string status { get; set; }
        public int order { get; set; }
        public string discount { get; set; }
        public string startShortDate { get; set; }
        public string endShortDate { get; set; }

        public ViewModel(DiscountDb model, string product, string typeCustomer, string status, int order) : base(model)
        {
            this.nameProduct = product;
            this.nameTypeCustomer = typeCustomer;
            this.status = status;
            this.order = order;
            this.discount = model.percentageDiscount.ToString() + "%";
            startShortDate = model.startDate.ToShortDateString();
            endShortDate = model.endDate.ToShortDateString();
        }
    }

    class CustomerViewModel: CustomerDb
    {
        public int order { get; set; }
        public string nameTypeCustomer { get; set; }
        public string dateOBShort { get; set; }

        public CustomerViewModel (CustomerDb model, int order, string typeCustomer) : base(model)
        {
            this.order = order;
            this.nameTypeCustomer = typeCustomer;
            DateTime dt = (DateTime)model.dateOfBirth;
            this.dateOBShort = dt.ToShortDateString();

        }
    }

    class ProductViewModel: ProductDb
    {
        public int order { get; set; }
        public string nameCategory { get; set; }
        public string stringPriceSell { get; set; }
        public string stringPriceImport { get; set; }
        public ProductViewModel (ProductDb model,  int order, string nameCategory) :base(model)
        {
            this.order = order;
            this.nameCategory = nameCategory;
            this.stringPriceImport = Unity.formatMoney((long)model.priceImport);
            this.stringPriceSell = Unity.formatMoney((long)model.priceSell);

        }
    }

    class ProductSizeQuantityViewModel
    {
        public string nameTypeProduct { get; set; }
        public string nameProduct { get; set; }
        public int[] arrSizeQuantity { get; set; }
        public int order { get; set; }
        public int sumQuantity { get; set; }
        public int idProduct { get; set; }
        public const  int QuantitySize = 7;

        public ProductSizeQuantityViewModel(int idProduct, string nameTypeProduct, string nameProduct, int[] arrSize, int order)
        {
            this.nameTypeProduct = nameTypeProduct;
            this.nameProduct = nameProduct;
            this.order = order;
            this.idProduct = idProduct;

            arrSizeQuantity = new int[QuantitySize];
            this.sumQuantity = 0;
            for (int i = 0; i < QuantitySize; i++)
            {
                arrSizeQuantity[i] = arrSize[i];
                sumQuantity += arrSize[i];
            }
        }
    }

    class ReceiptViewModel : Receipt
    {
        public string nameCustomer { get; set; }
        public string shortDate { get; set; }
        public int order { get; set; }
        public string nameReceipt { get; set; }
        public string stringSumMoney { get; set; }

        public ReceiptViewModel(string name, Receipt model, int order) : base(model)
        {
            this.nameCustomer = name;
            this.shortDate = model.datePay.ToShortDateString();
            this.order = order;
            this.nameReceipt = "HD" + model.id;
            this.stringSumMoney = Unity.formatMoney((long)model.sumMoney);
            this.sumScore = model.sumScore;
        }
        
    }

    class DetailReceiptViewModel : DetailReceipt
    {
        public string nameProduct { get; set; }
        public long sumMoney { get; set; }
        public string stringSumMoney { get; set; }
        public int sumScore { get; set; }
        public int order { get; set; }
        public string nameDiscount { get; set; }
        public string discountString { get; set; }
        public string stringUnitPrice { get; set; }

        public DetailReceiptViewModel (CustomerDb customer, ProductDb product, int quantity, int sizeOrder, DateTime date, int order)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.ManagementProjectConnectionString);
            nameProduct = product.nameProduct;
            this.quantity = quantity;
            this.unitPriceSell = product.priceSell;
            this.unitBonusScore = product.bonusScore;
            this.sumScore = quantity * (int)unitBonusScore;
            this.order = order;
            this.size = sizeOrder;
            this.stringUnitPrice = Unity.formatMoney((long)unitPriceSell);
            this.idProduct = product.id;
            this.idTypeProduct = product.category;

            //get discount, idTypeCustomer=1 mean all customer, idProduct=6 means all type product
            var discount = (from p in dc.DiscountDbs
                            where p.statusDiscount == 1 && date >= p.startDate && date <= p.endDate &&
                            (p.idTypeCustomer == 1 || p.idTypeCustomer == customer.typeCustomer) &&
                             ( p.idProduct == 6 || p.idProduct == product.category)
                            orderby p.percentageDiscount descending
                            select p).ToList();
            if (discount.Count == 0)
            {
                this.idDiscount = -1;
                this.nameDiscount = "(Không có)";
                this.discountString = "0%";
                this.persentageDiscount = 0;
            }
            else //chọn ưu đãi cao nhất
            {
                this.idDiscount = discount[0].id;
                this.nameDiscount = discount[0].nameDiscount;
                this.discountString = discount[0].percentageDiscount + "%";
                this.persentageDiscount = discount[0].percentageDiscount;
            }
            var x = (long) (quantity * (long)unitPriceSell)* (100.0 - persentageDiscount) / 100.0;
            this.sumMoney = (long)x;
            var y = sumMoney - product.priceImport * quantity;
            this.interest = (long)y;

            this.stringSumMoney = Unity.formatMoney(sumMoney);
        }

        public DetailReceiptViewModel(DetailReceipt model,  int order):base(model)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.ManagementProjectConnectionString);

            CustomerDb customer = (from p in dc.CustomerDbs where p.id == this.idCustomer select p).Single();
            ProductDb product = (from p in dc.ProductDbs where p.id == this.idProduct select p).Single();
            
            nameProduct = product.nameProduct;
            
            this.unitPriceSell = product.priceSell;
            this.unitBonusScore = product.bonusScore;
            this.sumScore = quantity * (int)unitBonusScore;
            this.order = order;
            this.stringUnitPrice = Unity.formatMoney((long)unitPriceSell);
            this.idProduct = product.id;
            this.idTypeProduct = product.category;

            //get discount, idTypeCustomer=1 mean all customer, idProduct=6 means all type product
            if (this.idDiscount == -1)
            {
                this.nameDiscount = "(Không có)";
            }
            else
            {
                var discount = (from p in dc.DiscountDbs where p.id == this.idDiscount select p).Single();
              
                this.nameDiscount = discount.nameDiscount;
                this.discountString = discount.percentageDiscount + "%";
            }
           
            var x = (long)(quantity * (long)unitPriceSell) * (100.0 - persentageDiscount) / 100.0;
            this.sumMoney = (long)x;
            var y = sumMoney - product.priceImport * quantity;
            this.interest = (long)y;

            this.stringSumMoney = Unity.formatMoney(sumMoney);
        }

    }

    

}
