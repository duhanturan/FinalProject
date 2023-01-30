using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün adı Geçersiz";
        internal static string MaintenanceTime = "Sistem bakımda.";
        internal static string ProductListed = "Ürünler Listelendi.";

        public static string UnitPriceInvalid = "Ürünün değeri 0'dan büyük olmalıdır.";

        public static string ProductCountOfCategoryError = "Ürünün kategorisinde en fazla 10 adet ürün bulunmalı.";

        public static string ProductNameAlreadyExist = "Bu isimde bir ürün bulunmaktadır.";

        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
    }
}
