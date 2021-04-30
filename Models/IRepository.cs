using System.Collections.Generic;
using System;
namespace V5L1.Models
{
    public interface IRepository
        {
            IEnumerable<Link> Links { get; }
            void AddLink(Link l);
            Link DelLink(String n);
    }
    }

