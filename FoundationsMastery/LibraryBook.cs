using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    class LibraryBook : LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int DatePublished { get; set; }
        public virtual int CircPeriodDay { get; } = 14;
    }
   
}
