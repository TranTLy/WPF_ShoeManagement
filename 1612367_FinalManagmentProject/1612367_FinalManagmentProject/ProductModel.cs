using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1612367_FinalManagmentProject
{
    class ProductModel
    {
        [DisplayName ("STT")]
        public int id { get; set; }
        [DisplayName("Tên sản phẩm")]
        public String name { get; set; }
        [DisplayName("Loại")]
        public int category { get; set; }
        [DisplayName("Giá nhập")]
        public ulong priceImport { get; set; }
        [DisplayName("Giá xuất")]
        public ulong priceSell { get; set; }
        [DisplayName("Điểm tích lũy")]
        public int bonusScore { get; set; }
        [DisplayName("Đơn vị")]
        public String unit { get; set; }

        public ProductModel(int id, string name, int category, ulong priceImport, ulong priceSell, int bonusScore, string unit)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.priceImport = priceImport;
            this.priceSell = priceSell;
            this.bonusScore = bonusScore;
            this.unit = unit;
        }

        public ProductModel(int category, ulong priceImport, ulong priceSell, string name, int bonusScore, string unit)
        {
            this.category = category;
            this.priceImport = priceImport;
            this.priceSell = priceSell;
            this.name = name;
            this.bonusScore = bonusScore;
            this.unit = unit;
        }

        public ProductModel()
        {
        }
    }


}
