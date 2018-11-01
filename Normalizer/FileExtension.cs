using System.Collections.Generic;

namespace DariaCMS.Utilities.Normalizer
{
    /// <summary>
    /// Check Accepted Extenstion
    /// </summary>
    public static class FileExtension
    {
        public static bool IsFileExtensionISValid(this string ExtensionFileName)
        {
            var ExtList = new List<string>(new List<string>{
                ".gif", ".jpg", ".jpeg", ".png", ".doc",
                ".pdf",".ppt",".zip",".rar",".mp4",".avi",".mkv",".mp3",".doc",".docx"
            });
            if (ExtList.Contains(ExtensionFileName))
                return true;
            else
                return false;
        }
    }
}
