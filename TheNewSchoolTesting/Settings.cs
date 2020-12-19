using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TheNewSchoolTesting
{
    public static class Settings
    {
        private static string baseURL;
        public static string BaseURL
        {
            get
            {
                if (baseURL == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("BaseUrl");
                    baseURL = node.InnerText;
                }
                return baseURL;
            }
        }

        private static string login;
        public static string Login
        {
            get
            {
                if (login == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("Login");
                    login = node.InnerText;
                }
                return login;
            }
        }
        
        private static string password;
        public static string Password
        {
            get
            {
                if (password == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("Password");
                    password = node.InnerText;
                }
                return password;
            }
        }
        
        public static string file = Path.Combine(Directory.GetCurrentDirectory(), "Settings.xml");
        private static XmlDocument document;

        static Settings()
        {
            if (!System.IO.File.Exists(file))
            {
                throw new Exception("Problem: settings file not found: " + file);
            }
            document = new XmlDocument();
            document.Load(file);
        }

    }
}