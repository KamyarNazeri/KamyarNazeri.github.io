using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImaginLab.CPanel
{
    [DebuggerDisplay("title = {title}")]
    class ImagingLabData
    {
        public string title { get; set; } = "ImagingLab.ca, Mehran Ebrahimi, UOIT";
        public DateTime updated { get; set; } = DateTime.Now;

        public Teaching[] teachings { get; set; }
        public People[] people { get; set; }
        public Publication[] publications { get; set; }
        public string[] publicationTypes { get; set; }
    }

    [DebuggerDisplay("{university} - {semester} - {title}")]
    class Teaching
    {
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
        public DateTime? start { get; set; }
        public DateTime? end { get; set; }
        public string description { get; set; }
        public bool alumni { get; set; }
        public bool visible { get; set; }
    }

    [DebuggerDisplay("{code} - {year} - {title}")]
    class Publication
    {
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
        public int[] people { get; set; }
    }
}
