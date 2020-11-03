using System;

namespace LinqKoans.Engine.Tests.Fakes
{
    public class TestPath : Path
    {
        public TestPath()
        {
            Types = new Type[] {
                typeof(TestKoan)
                };
        }
    }
}