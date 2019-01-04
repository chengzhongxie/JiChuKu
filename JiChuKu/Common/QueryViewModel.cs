using DAL.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APP.Common
{
    public class QueryViewModel : PaginationBase
    {
        public string SearchTerm { get; set; }
        public string Fields { get; set; }
    }
}
