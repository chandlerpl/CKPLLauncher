using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace CKPLLauncher
{
    class FileSize
    {
        public static long DirSize(DirectoryInfo dir)
        {
            return dir.GetFiles().Sum(fi => fi.Length) + dir.GetDirectories().Sum(di => DirSize(di));
        }

        public static string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }

        public static string xmlData(string name, string path, bool temp)
        {
            XmlDocument doc = new XmlDocument();
            if (name.Contains(".xml"))
            {
                doc.Load(name);
            }
            else
            {
                if (File.Exists(Application.StartupPath + "\\appData\\" + name + ".xml") && !temp)
                {
                    doc.Load(Application.StartupPath + "\\appData\\" + name + ".xml");
                }
                else
                {
                    doc.Load(Application.StartupPath + "\\temp\\" + name + ".xml");
                }
            }

            if (doc.DocumentElement.SelectSingleNode(path) == null)
            {
                return null;
            }
            else
            {
                string text = doc.DocumentElement.SelectSingleNode(path).InnerText;
                return text;
            }
        }
    }
}
