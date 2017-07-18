using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ImagingLab.CPanel
{
    interface DataObject
    {
        int id { get; set;  }
        int order { get; set; }
    }

    [DebuggerDisplay("title = {title}")]
    class ImagingLabData
    {
        public string title { get; set; } = "ImagingLab.ca, Mehran Ebrahimi, UOIT";
        public string updated { get; set; } = DateTime.Now.ToString("MMM yyyy");

        public SortableBindingList<Teaching> teachings { get; set; }
        public SortableBindingList<People> people { get; set; }
        public SortableBindingList<Publication> publications { get; set; }
        public SortableBindingList<string> publicationTypes { get; set; }

        public void AddTeaching(Teaching obj)
        {
            AddEntry(this.teachings, obj);
        }

        public void AddPeople(People obj)
        {
            AddEntry(this.people, obj);
        }

        public void AddPublication(Publication obj)
        {
            AddEntry(this.publications, obj);
        }

        public void ReOrder()
        {
            ReOrder(this.teachings);
            ReOrder(this.people);
            ReOrder(this.publications);
        }

        void AddEntry<T>(IList<T> list, T obj) where T : DataObject
        {
            obj.id = list.Max(t => t.id) + 1;
            obj.order = list.Max(t => t.order) + 1;
            list.Add(obj);
        }

        void ReOrder<T>(IList<T> list) where T : DataObject
        {
            int order = 1;
            foreach (DataObject obj in list.OrderBy(t => t.order).ToList())
            {
                obj.order = order;
                order++;
            }
        }
    }

    [DebuggerDisplay("{university} - {semester} - {title}")]
    class Teaching : DataObject
    {
        public int id { get; set; }
        public int order { get; set; }
        public string semester { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string university { get; set; }
        public string url { get; set; }
        public bool visible { get; set; } = true;
    }

    [DebuggerDisplay("{id} - {name} - {position}")]
    class People : DataObject
    {
        public int id { get; set; }
        public int order { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string title { get; set; }
        public string position { get; set; }
        public string education { get; set; }
        public string photo { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string research { get; set; }
        public string description { get; set; }
        public bool alumnus { get; set; } = false;
        public bool visible { get; set; } = true;

        [ScriptIgnore]
        internal string PhotoPath { get; set; }
    }

    [DebuggerDisplay("{code} - {year} - {title}")]
    class Publication : DataObject
    {
        public int id { get; set; }
        public int order { get; set; }
        public string code { get; set; }
        public string title { get; set; }
        public int year { get; set; } = 2017;
        public string type { get; set; } = "Journal Articles";
        public string url { get; set; }
        public string pdf { get; set; }
        public string bibtex { get; set; }
        public string authors { get; set; }
        public bool visible { get; set; } = true;
        public bool peoplePageVisible { get; set; } = true;
        public BindingList<int> people { get; set; }

        [ScriptIgnore]
        internal string PdfPath { get; set; }
    }

    [DebuggerDisplay("{name}")]
    class PeoplePublication : DataObject
    {
        public int id { get; set; }
        public int order { get; set; }
        public string name { get; set; }
        public bool selected { get; set; }
    }
}