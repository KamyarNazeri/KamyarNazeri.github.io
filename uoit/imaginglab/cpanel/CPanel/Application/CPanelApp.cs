using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ImagingLab.CPanel
{
    class CPanelApp
    {
        public const string DATA_DIR = "Data";
        public const string DATA_PATH = @"Data\data.json";

        public ImagingLabData Data { get; private set; }

        static object InterLock = new object();
        static CPanelApp _current;

        private CPanelApp()
        {
            Data = LoadData();
        }

        public static CPanelApp Current
        {
            get
            {
                if (_current == null)
                {
                    lock (InterLock)
                    {
                        if (_current == null)
                        {
                            _current = new CPanelApp();
                        }
                    }
                }

                return _current;
            }
        }

        public ImagingLabData LoadData()
        {
            try
            {
                if (!File.Exists(DATA_PATH))
                {
                    MessageBox.Show("data.json file not found!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }

                using (StreamReader sr = new StreamReader(DATA_PATH))
                {
                    string str = sr.ReadToEnd();
                    JavaScriptSerializer ser = new JavaScriptSerializer();
                    return ser.Deserialize<ImagingLabData>(str);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in loading data.json!" + Environment.NewLine + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return null;
        }

        public bool SaveData()
        {
            DirectoryInfo datadir = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, DATA_DIR));

            try
            {
                Data.publications.Select(t => t.PdfPath)
                .Union(Data.people.Select(t => t.PhotoPath))
                .Where(t => !String.IsNullOrEmpty(t))
                .Distinct()
                .Select(t => new FileInfo(t))
                .Where(t => t.Exists && t.Directory.FullName.ToUpper() != datadir.FullName.ToUpper())
                .ToList()
                .ForEach(t => t.CopyTo(Path.Combine(DATA_DIR, t.Name), true));

                using (StreamWriter sw = new StreamWriter(DATA_PATH, false, Encoding.Unicode))
                {
                    JavaScriptSerializer ser = new JavaScriptSerializer();
                    string json = ser.Serialize(Data);
                    string unescape = Regex.Unescape(json).Replace("\n", "\\n"); ;
                    sw.Write(unescape);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in saving data.json!" + Environment.NewLine + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public void Publish(string path)
        {
            DirectoryCopy(Path.Combine(Environment.CurrentDirectory, DATA_DIR), Path.Combine(path, DATA_DIR));
        }

        public void DirectoryCopy(string sourceDirName, string destDirName)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            foreach (FileInfo file in dir.GetFiles())
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);
            }

            foreach (DirectoryInfo subdir in dir.GetDirectories())
            {
                string temppath = Path.Combine(destDirName, subdir.Name);
                DirectoryCopy(subdir.FullName, temppath);
            }
        }
    }
}
