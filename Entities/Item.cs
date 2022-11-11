using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstApi.Entities
{
    public record Item
    { 
        public Guid id { get; init; }

        public string name
        {
            get; init;
        }

        public int price
        { get; init; }

        public DateTime createdDate
        { get; init; }

    }
}
