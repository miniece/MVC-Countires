using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace MVC_Countries
{
    public class CountryListView
    {
        public List<Country> Countries { get; set; }

        public void Display()
        {
            for(int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine(i + " " + Countries[i].Name);
            }
        }
    }
}
