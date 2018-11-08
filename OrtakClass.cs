using System;

namespace tMaxOrtak
{
    public static class OrtakProps
    {
        // SMTP: Transorient via Relay
        /*
        public static string Firma = "TRANSORIENT";
        public static string SmtpMailFromAddress = "doc@transorient.com.tr";
        public static string SmtpMailFromDisplayName = "Transorient";
        public static string SmtpClientHost = "192.168.1.246";
        public static string SmtpCredentialsUserName = "smtp@transorient.com.tr";
        public static string SmtpCredentialsUserPassword = "Sadmin34";
        public static bool SmtpEnableSsl = false;
        public static int SmtpPort = 25;
        */
        
       
        // SMTP: Transorient Aktif
        public static string Firma = "TRANSORIENT";
        public static string SmtpMailFromAddress = "doc@transorient.com.tr";
        public static string SmtpMailFromDisplayName = "Transorient";
        public static string SmtpClientHost = "smtp.office365.com";
          //public static string SmtpClientHost = "outlook.office365.com";
        public static string SmtpCredentialsUserName = "smtp@transorient.com.tr";
        public static string SmtpCredentialsUserPassword = "Sadmin34";
        public static bool SmtpEnableSsl = true;
        public static int SmtpPort = 587;      
        
        
        // SMTP: tunaset.com Aktif
        // SMTP & POP Sunucu :   mail.tunaset.com
        // Kullanıcı Adı : bio@tunaset.com
        // Yeni Parola   : Berlin34
        // SSL : Kapalı
        // SMTP Port : 587
 /*
        public static string Firma = "TUNASET";
        public static string SmtpMailFromAddress = "bio@tunaset.com";
        public static string SmtpMailFromDisplayName = "TunasetBiofarma";
        public static string SmtpClientHost = "mail.tunaset.com";
        public static string SmtpCredentialsUserName = "bio@tunaset.com";
        public static string SmtpCredentialsUserPassword = "Berlin34";
        public static bool SmtpEnableSsl = false;
        public static int SmtpPort = 587;
  */     

        // SMTP: biotunaset.com
        /*
        public static string Firma = "TUNASET";
        public static string SmtpMailFromAddress = "bio@biotunaset.com";
        public static string SmtpMailFromDisplayName = "TunasetBiofarma";
        public static string SmtpClientHost = "smtp.office365.com";
        public static string SmtpCredentialsUserName = "smtp@biotunaset.com";
        public static string SmtpCredentialsUserPassword = "Tuna47";
        public static bool SmtpEnableSsl = true;
        public static int SmtpPort = 587;

        */
    }
}