using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Shared.Generic
{
    public class PageRequest<T>
    {
        public T Filter { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
        public string SortBy { get; set; }
        public string SortDirection { get; set; }
    }
}

