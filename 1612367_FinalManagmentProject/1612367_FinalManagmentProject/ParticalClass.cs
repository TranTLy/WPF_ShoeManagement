using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1612367_FinalManagmentProject
{
    public partial class CategoryDb
    {
        public override String ToString()
        {
            return nameType;
        }
    }

    public partial class Score_TypeCustomer
    {
        public override String ToString()
        {
            return nameTypeCustomer;
        }
    }

    public partial class DiscountDb
    {
        public DiscountDb(string name, int idProduct, int idCustomer, int statusDiscount, DateTime start, DateTime end, int percent)
        {
            this.nameDiscount = name;
            this.idProduct = idProduct;
            this.idTypeCustomer = idCustomer;
            this.statusDiscount =  statusDiscount;
            this.startDate = start;
            this.endDate = end;
            this.percentageDiscount = percent;
        }

        public DiscountDb(DiscountDb model)
        {
            this.nameDiscount = model.nameDiscount;
            this.idProduct = model.idProduct;
            this.idTypeCustomer = model.idTypeCustomer;
            this.statusDiscount = model.statusDiscount;
            this.startDate = model.startDate;
            this.endDate = model.endDate;
            this.percentageDiscount = model.percentageDiscount;
            this.id = model.id;
        }
    }

    public partial class ProductDb
    {
        public ProductDb(string name, string unit, long priceImport, long priceSell, int bonusScore, int idCategory)
        {
            this.nameProduct = name;
            this.unit = unit;
            this.priceImport = priceImport;
            this.priceSell = priceSell;
            this.bonusScore = bonusScore;
            this.category = idCategory;
        }

        public ProductDb(ProductDb model)
        {
            this.nameProduct = model.nameProduct;
            this.unit = model.unit;
            this.priceImport = model.priceImport;
            this.priceSell = model.priceSell;
            this.bonusScore = model.bonusScore;
            this.category = model.category;
            this.id = model.id;
            this.sumQuantity = model.sumQuantity;
        }
    }

    public partial class CustomerDb
    {
        public CustomerDb(string name, string phoneNumber, DateTime dateOB)
        {
            this.nameCustomer = name;
            this.phoneNumber = phoneNumber;
            this.dateOfBirth = dateOB;
            score = 0;
            typeCustomer = 1;
            
        }
        public CustomerDb(CustomerDb model)
        {
            this.nameCustomer = model.nameCustomer;
            this.phoneNumber = model.phoneNumber;
            this.dateOfBirth = model.dateOfBirth;
            this.id = model.id;
            this.score =model.score;
            this.typeCustomer = model.typeCustomer;
        }
    }

    public class Size_Product
    {
        //public Size_Product(int id, int quantity)
        //{
        //    this.id = id;
        //    this.quantity = quantity;
        //}
    }

    
    public partial class Size36_Product : Size_Product
    {
        public Size36_Product(int id, int quantity)
        {
            this.idProduct = id;
            this.quantity = quantity;
        }
    }

    public partial class Size37_Product : Size_Product
    {
        public Size37_Product(int id, int quantity)
        {
            this.idProduct = id;
            this.quantity = quantity;
        }
    }

    public partial class Size38_Product : Size_Product
    {
        public Size38_Product(int id, int quantity)
        {
            this.idProduct = id;
            this.quantity = quantity;
        }
    }

    public partial class Size39_Product : Size_Product
    {
        public Size39_Product(int id, int quantity)
        {
            this.idProduct = id;
            this.quantity = quantity;
        }
    }

    public partial class Size40_Product : Size_Product
    {
        public Size40_Product(int id, int quantity)
        {
            this.idProduct = id;
            this.quantity = quantity;
        }
    }

    public partial class Size41_Product : Size_Product
    {
        public Size41_Product(int id, int quantity)
        {
            this.idProduct = id;
            this.quantity = quantity;
        }
    }

    public partial class Size42_Product : Size_Product
    {
        public Size42_Product(int id, int quantity)
        {
            this.idProduct = id;
            this.quantity = quantity;
        }
    }

    public partial class Receipt
    {
        public Receipt(Receipt model)
        {
            this.id = model.id;
            this.idCustomer = model.idCustomer;
            this.datePay = model.datePay;
            this.sumMoney = model.sumMoney;
            this.sumScore = model.sumScore;
        }
        public Receipt (int idCustomer, DateTime date, long sumMoney, int sumScore)
        {
            this.idCustomer = idCustomer;
            this.datePay = date;
            this.sumMoney = sumMoney;
            this.sumScore = sumScore;
        }
    }

    public partial class ProductDb
    {
        public override string ToString()
        {
            return this.nameProduct;
        }
    }

    public partial class CustomerDb
    {
        public override string ToString()
        {
            return this.nameCustomer;
        }
    }

    public partial class DetailReceipt
    {
        public void addInforDetailReceiptWhenPay(int idReceipt, int idCustomer, DateTime date)
        {
            this.idReceipt = idReceipt;
            this.idCustomer = idCustomer;
            this.datePay = date;
        }

        public DetailReceipt(DetailReceipt model)
        {
            idReceipt = model.idReceipt;
            idCustomer = model.idCustomer;
            idProduct = model.idProduct;
            idTypeProduct = model.idTypeProduct;
            quantity = model.quantity;
            unitPriceSell = model.unitPriceSell;
            size = model.size;
            idDiscount = model.idDiscount;
            persentageDiscount = model.persentageDiscount;
            unitBonusScore = model.unitBonusScore;
            datePay = model.datePay;
            interest = model.interest;
        }
    }







}
