using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XStudio.School.Input.Model.Paging
{
    public class DatatablesView<T> 
    {
        public DatatablesView(int draw, int recordsTotal, int recordsFiltered, List<T> data)
        {
            this.draw = draw;
            this.recordsTotal = recordsTotal;
            this.recordsFiltered = recordsFiltered;
            this.data = data;
        }

        public List<T> data { get; set; }

        public int recordsTotal { get; set; }

        public int recordsFiltered { get; set; }

        public int draw { get; set; }
    }
}
