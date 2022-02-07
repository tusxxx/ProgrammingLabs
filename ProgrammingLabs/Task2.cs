using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLabs
{
    class Document
    {
        private string Name;
        private string Author;
        private string Tags;
        private string Genre;
        private string Location;

        public virtual void GetInfo() { }
    }

    class MSWord : Document
    {

    }

    class PDF : Document
    {

    }

    class MSExcel : Document
    {

    }

    class TXT : Document
    {

    }

    class HTML : Document
    {

    }
}
