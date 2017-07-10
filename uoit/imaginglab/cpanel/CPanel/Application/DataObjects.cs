using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagingLab.CPanel
{
    [DebuggerDisplay("title = {title}")]
    class ImagingLabData
    {
        public string title { get; set; } = "ImagingLab.ca, Mehran Ebrahimi, UOIT";
        public string updated { get; set; } = DateTime.Now.ToString("MMM yyyy");

        public BindingList<Teaching> teachings { get; set; }
        public BindingList<People> people { get; set; }
        public BindingList<Publication> publications { get; set; }
        public BindingList<string> publicationTypes { get; set; }
    }

    [DebuggerDisplay("{university} - {semester} - {title}")]
    class Teaching
    {
        public int id { get; set; }
        public string semester { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string university { get; set; }
        public string url { get; set; }
    }

    [DebuggerDisplay("{id} - {name} - {position}")]
    class People
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string position { get; set; }
        public string education { get; set; }
        public string photo { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string description { get; set; }
        public bool alumni { get; set; }
        public bool visible { get; set; }
    }

    [DebuggerDisplay("{code} - {year} - {title}")]
    class Publication
    {
        public int id { get; set; }
        public string code { get; set; }
        public string title { get; set; }
        public int year { get; set; } = 2017;
        public string type { get; set; } = "Journal Articles";
        public string url { get; set; }
        public string pdf { get; set; }
        public string bibtex { get; set; }
        public string contributors { get; set; }
        public bool publicationsPageVisible { get; set; } = true;
        public bool peoplePageVisible { get; set; } = true;
        public BindingList<int> people { get; set; }
    }
}
