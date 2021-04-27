using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Shared.Generic
{
    public class PageResponse<T>
    {
        public ICollection<T> DataSource { get; set; }
        public int Count { get; set; }
    }
}
