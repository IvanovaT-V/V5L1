using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace V5L1.Models
{
    public class Repository
    {
            private static Repository sharedRepository = new Repository();
            private Dictionary<string, Link> links
            = new Dictionary<string, Link>();
            public static Repository SharedRepository => sharedRepository;
            public Repository()
            {
            var initialItems = new[] {
new Link { Name = "aaaa", Url = "aaaa" },
new Link { Name = "bbbbb", Url = "bbbbb" },
new Link { Name = "ccccc", Url = "ccccc" },
new Link { Name = "dddddd", Url = "dddddd" }
};
                foreach (var r in initialItems)
                {
                    AddLink(r);
                }
                   links.Add("Error", null);
        }
            public IEnumerable<Link> Links=> links.Values;
        public void AddLink(Link r) => links.Add(r.Name, r);
        }
    }
