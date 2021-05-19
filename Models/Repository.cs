using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace V5L1.Models
{
    public class Repository : IRepository
    {
            private static Repository sharedRepository = new Repository();
            private Dictionary<string, Link> links = new Dictionary<string, Link>();
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
        }
            public IEnumerable<Link> Links => links.Values;
        public void AddLink(Link r) { if (links.Count <= 50) links.Add(r.Name, r); }
        public Link DelLink(String n)
        {
            Link deletedLink = links.Values.FirstOrDefault(p => p.Name == n) ;
            if (deletedLink != null)
            {
                links.Remove(n);
                
            }
            return deletedLink;
        }
    }
    }
