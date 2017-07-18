using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ImagingLab.CPanel
{
    class AppSettings
    {
        const string NAME = "__CPanel__";
        static readonly object InterLock = new object();

        private AppSettings()
        {
            Load();
        }

        static AppSettings _current;
        public static AppSettings Current
        {
            get
            {
                if (_current == null)
                {
                    lock (InterLock)
                    {
                        if (_current == null)
                        {
                            _current = new AppSettings();
                        }
                    }
                }

                return _current;
            }
        }

        Dictionary<string, object> _properties = new Dictionary<string, object>();

        public string Username
        {
            get { return Val<string>(nameof(Username)); }
            set { Val(nameof(Username), value); }
        }

        public string Password
        {
            get { return Val<string>(nameof(Password)); }
            set { Val(nameof(Password), value); }
        }

        T Val<T>(string key)
        {
            if (_properties.ContainsKey(key))
                return (T)_properties[key];

            return default(T);
        }

        void Val<T>(string key, T val)
        {
            _properties[key] = val;
        }

        public void Save()
        {
            try
            {
                IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForAssembly();
                using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream(NAME, FileMode.OpenOrCreate, storage))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write((new JavaScriptSerializer()).Serialize(_properties));
                    }
                }
            }
            catch { }
        }

        void Load()
        {
            try
            {
                IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForAssembly();
                using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream(NAME, FileMode.Open, storage))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        _properties = (new JavaScriptSerializer()).Deserialize<Dictionary<string, object>>(reader.ReadToEnd());
                    }
                }
            }
            catch { }
        }
    }
}
