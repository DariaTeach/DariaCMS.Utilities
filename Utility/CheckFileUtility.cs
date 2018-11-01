using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DariaCMS.Utilities.Normalizer
{
    /// <summary>
    /// Check File Size , Extention  Before Upload
    /// </summary>
    public static class CheckFileUtility
    {
        public static string FileUpload(IFormFile formFile, bool IsImage, bool IsDocs, bool Videos, decimal Size)
        {
            if (formFile == null)
                return "OK";
            var mmm = (Size * 1024);
            if (formFile.Length > Size * 1024)
                return "حجم فایل مورد نظر نمی تواند بیش از " + Size + "باشد";

            bool IsExtIsTrue = false;
            string FileExt = Path.GetExtension(formFile.FileName);
            FileExt = FileExt.ToLower();
            if (IsImage)
            {
                string[] ExtList = new string[] { ".gif", ".jpg", ".jpeg", ".png" };
                if (ExtList.Contains(FileExt))
                    IsExtIsTrue = true;
            }
            if (IsDocs)
            {
                string[] ExtList = new string[] { ".pdf", ".ppt", ".zip", ".rar", ".doc", ".docx" };
                if (ExtList.Contains(FileExt))
                    IsExtIsTrue = true;
            }
            if (Videos)
            {
                string[] ExtList = new string[] { ".mp4", ".avi", ".3gp", ".mkv" };
                if (ExtList.Contains(FileExt))
                    IsExtIsTrue = true;
            }
            if (!IsExtIsTrue)
                return "فرمت فایل مورد نظر قابل قبول نمی باشد";
            else
                return "OK";
        }
    }
}
