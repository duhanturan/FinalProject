using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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

        public static string AuthorizationDenied = "yetkiniz yok";

        public static string UserRegistered = "kullanıcı kaydedildi";

        public static string UserNotFound = "kullanıcı bulunamadı";

        public static string PasswordError = "parola hatalı";

        public static string SuccessfulLogin = "giriş başarılı";

        public static string UserAlreadyExists = "byle bir kullanıcı zaten var";

        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
