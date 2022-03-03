using System;
using System.IO;
namespace KeyloggerEvader.Helpers
{
    public class FileHelper
    {
        public static string GetBaseDirectoryPath()
        {
            try
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }
            catch
            {
                return "";
            }
        }

        public static string GetFileExtension(string filePath)
        {
            try
            {
                return Path.GetExtension(filePath);
            }
            catch
            {
                return "";
            }
        }

        public static string GetFileNameWithoutExtension(string filePath)
        {
            try
            {
                return Path.GetFileNameWithoutExtension(filePath);
            }
            catch
            {
                return "";
            }
        }

        public static string GetPathWithoutFileName(string filePath)
        {
            try
            {
                return Path.GetDirectoryName(filePath);
            }
            catch
            {
                return "";
            }
        }
    }
}