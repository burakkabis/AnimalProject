using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AnimalAdded = "Hayvan eklendi";
        public static string AnimalNameInvalid = "Hayvan ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string AnimalsListed = "Hayvanlar listelendi";
        public static string AnimalOfCategoryError = "Bir kategoride en fazka 10 urun olabilir";
        public static string AnimalNameAlreadyExist = "Bu isimde zaten bir isim var.";
        public static string CategoryLimitExceded = "Kategori limiti asildigi icin yeni urun eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        internal static string AnimalCountOfColorError="Bu color da daha fazla hayvan eklenemez";
    }
}
