using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using code.enumerables;
using code.prep.movies;

namespace code.matching
{
    public static class AnonymousMatchFactory
    {
        public static AnonymousMatch<Item> GetAnonymousMatch<Item>(Criteria<Item> criteria)
        {
            return new AnonymousMatch<Item>(criteria);
        } 
    }
}
