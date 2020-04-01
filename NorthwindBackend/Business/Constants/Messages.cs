using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarı ile eklendi.";
        public static string ProductDeleted = "Ürün başarı ile silindi.";
        public static string ProductUpdated = "Ürün başarı ile güncellendi.";
        public static string CategoryAdded = "Kategori başarı ile eklendi.";
        public static string CategoryDeleted = "Kategori başarı ile silindi.";
        public static string CategoryUpdated = "Kategori başarı ile güncellendi.";

        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Sisteme giriş başarılı.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut.";
        public static string UserRegistered = "Kullanıcı başarı ile kaydedildi.";
        public static string AccessTokenCreated = "Access token başarı ile oluşturuldu.";

    }
}
