using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ImaginLab.CPanel
{
    class CPanelApp
    {
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

        public void SaveData()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(DATA_PATH))
                {
                    JavaScriptSerializer ser = new JavaScriptSerializer();
                    sw.Write(ser.Serialize(Data));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in saving data.json!" + Environment.NewLine + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
