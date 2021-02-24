using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategorError= "Bir kategoride en fazla 10 ürün olmalıdır";
        public static string ProductNameAlreadyExist= "Bu isimde zaten başka bir ürün var";
        internal static string CategoryLimitExceded= "Kategori limiti aşıldığı için ürün eklenemiyor";
    }
}
