
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace DariaCMS.Utilities.Utility
{
    /// <summary>
    /// File Upload Utility
    /// </summary>
    public class FileUploadUtility
    {

        public static string FileUpload(IFormFile File, string pathdir, string folderName)
        {
            try
            {
                #region Upload
                string uploadpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", pathdir);
                if (!Directory.Exists(uploadpath))
                {
                    Directory.CreateDirectory(uploadpath);
                }
                Random r = new Random();
                int rand = r.Next(1000);
                string FileName = pathdir + DateTime.Now.ToString("yyyyMMddHHssmm") + rand + Path.GetExtension(File.FileName);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", folderName, FileName);
                using (var Stream = new FileStream(path, FileMode.Create))
                {
                    File.CopyTo(Stream);
                }
                #endregion
                return FileName;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        /// <summary>
        /// برای آپلود فایل با یک اسم خاص مدنظر
        /// </summary>
        /// <param name="FileName">اسم فایل آپلودی چی باشه</param>
        /// <returns></returns>
        public static string FileUploadWithName(IFormFile File, string folderName, string FileName)
        {
            try
            {
                #region Upload
                string uploadpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", folderName);
                if (!Directory.Exists(uploadpath))
                {
                    Directory.CreateDirectory(uploadpath);
                }
                FileName = FileName + Path.GetExtension(File.FileName);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", folderName, FileName);

                using (var Stream = new FileStream(path, FileMode.Create))
                {
                    File.CopyTo(Stream);
                }
                #endregion
                return FileName;
            }
            catch
            {

                return null;
            }
        }


        public static string FileUploadWithTwoFolderName(IFormFile File, string folderNameOne, string FolderName2)
        {
            try
            {

                #region Upload
                string uploadpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", folderNameOne);
                if (!Directory.Exists(uploadpath))
                {
                    Directory.CreateDirectory(uploadpath);
                }
                uploadpath = Path.Combine(uploadpath, FolderName2);
                if (!Directory.Exists(uploadpath))
                {
                    Directory.CreateDirectory(uploadpath);
                }
                Random r = new Random();
                int rand = r.Next(1000);
                string FileName = DateTime.Now.ToString("yyyyMMddHHssmm") + rand + Path.GetExtension(File.FileName);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", folderNameOne, FolderName2, FileName);
                using (var Stream = new FileStream(path, FileMode.Create))
                {
                    File.CopyTo(Stream);
                }
                return FileName;
                #endregion
            }
            catch
            {

                return null;
            }
        }
        public static string FileUploadWithTwoFolderNameHeavyFile(IFormFile File, string folderNameOne, string FolderName2)
        {
            try
            {

                #region Upload
                string uploadpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", folderNameOne);
                if (!Directory.Exists(uploadpath))
                {
                    Directory.CreateDirectory(uploadpath);
                }
                uploadpath = Path.Combine(uploadpath, FolderName2);
                if (!Directory.Exists(uploadpath))
                {
                    Directory.CreateDirectory(uploadpath);
                }
                Random r = new Random();
                int rand = r.Next(1000);
                string FileName = DateTime.Now.ToString("yyyyMMddHHssmm") + rand + Path.GetExtension(File.FileName);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", folderNameOne, FolderName2, FileName);
                using (var Stream = new FileStream(path, FileMode.Create))
                {
                    File.CopyTo(Stream);
                }
                return FileName;
                #endregion
            }
            catch
            {

                return null;
            }
        }
        public static string FileUpload(IFormFile file, string pathdir, string Filename, bool isEdit)
        {
            try
            {
                #region Upload
                string uploadpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", pathdir);
                if (!Directory.Exists(uploadpath))
                {
                    Directory.CreateDirectory(uploadpath);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", pathdir, Filename);


                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                using (var Stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(Stream);
                }

                #endregion
                return Filename;
            }
            catch (Exception)
            {

                return null;
            }
        }

    }
}
