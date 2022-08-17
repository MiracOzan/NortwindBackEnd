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

        public static string AuthorizationDenied { get; internal set; }
        public static string UserRegistered { get; internal set; }
        public static User UserNotFound { get; internal set; }
        public static User PasswordError { get; internal set; }
        public static string SuccessfulLogin { get; internal set; }
        public static string UserAlreadyExists { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }
    }
}
