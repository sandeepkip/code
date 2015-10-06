using System;
using code.matching;

namespace code.prep.movies
{
    internal class IMatchA<T> : IMatchAn<T>
    {
        private MovieLibrary.MovieCriteria criteria;

        public IMatchA(MovieLibrary.MovieCriteria criteria)
        {
            this.criteria = criteria;
        }

        public bool matches(T item)
        {
            return criteria.Invoke(item as Movie);
        }
    }
}