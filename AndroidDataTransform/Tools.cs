using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AndroidDataTransform
{
    /// <summary>
    /// 工具类
    /// </summary>
    public class Tools
    {
        /// <summary>
        /// 合并路径
        /// </summary>
        /// <param name="path1">前路径</param>
        /// <param name="path2">后路径</param>
        /// <returns></returns>
        public static string CombinePath(string path1, string path2)
        {
            if (String.IsNullOrEmpty(path1))
            {
                return path2;
            }
            if (String.IsNullOrEmpty(path2))
            {
                return path1;
            }
            //移除前一路径最后一个“\”
            if (path1.EndsWith(@"\"))
            {
                path1 = path1.Remove(path1.Length - 1);
            }
            //移除后一路径最前一个“\”
            if (path2.StartsWith(@"\"))
            {
                path2 = path2.Remove(0, 1);
            }
            try
            {
                return Path.Combine(path1, path2);
            }
            catch (Exception)
            {
                return String.Empty;
            }
        }

        /// <summary>
        /// 文件是否存在
        /// </summary>
        /// <param name="filename">文件名</param>
        /// <returns></returns>
        public static bool FileExist(string filename)
        {
            return System.IO.File.Exists(filename);
        }
        /// <summary>
        /// 路径是否存在
        /// </summary>
        /// <param name="path">路径名</param>
        /// <returns></returns>
        public static bool DirectoryExist(string path)
        {
            return System.IO.Directory.Exists(path);
        }
        /// <summary>
        /// 递归获取文件夹下所有符合要求的文件
        /// </summary>
        /// <param name="directory">文件夹路径</param>
        /// <param name="files">返回的文件</param>
        /// <param name="searchPattern">后缀名 如： '*.img'</param>
        public static void AddFilesFromDirectory(string directory, ICollection<string> files, string searchPattern)
        {
            var di = new DirectoryInfo(directory);
            foreach (FileInfo fi in di.GetFiles(searchPattern))
            {
                if (fi.FullName.ToLower().EndsWith(searchPattern.Substring(1)))
                {
                    files.Add(fi.FullName);
                }
            }
            foreach (DirectoryInfo cdi in di.GetDirectories())
            {
                AddFilesFromDirectory(cdi.FullName, files, searchPattern);
            }
        }
    }
}
