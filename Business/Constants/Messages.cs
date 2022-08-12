using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string EmployeeNotFound = "Çalışan bulunamadı";
        public static string EmployeeIdAlreadyExists = "Çalışan Kayıtlı";
        public static string EmployessAdded = "Çalışan Eklendi";
        public static string EmployessDeleted = "Çalışan Silindi";
        public static string EmployessUpdated = "Çalışan Bilgileri Güncellendi";

        public static string AuthorizationDenied = "Yetkisiz Giriş";
        public static string UserRegistered = "Kayıtlı Kullanıcı";
        public static string UserNotFound = "Kullanıcı Bulunulamadı";
        public static string PasswordError = "Şifre Hatası";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Bu Kullanıcı Kayıtlıdır";
        public static string AccessTokenCreated = "Erişim Anahtarı Hazırlandı";
    }
}
