using System;
using LinqKoans.Engine;

namespace LinqKoans.Koans
{
    public class PathToEnlightenment : Path
    {
        public PathToEnlightenment()
        {
            Types = new Type[]
            {
                typeof(ListsKoan),
                typeof(RangesKoan),
                typeof(LinqKoan),
            };
        }
    }
}
