using System.Collections;

namespace TestShape
{
    public class MyComparer : IComparer
    {
        private const double delta = 0.02;

        public int Compare(object x, object y )
        {
            double x1 = (double)x;
            double y1 = (double)y;

            if (Math.Abs(x1 - y1) <= delta)
                return 0;

            return x1 > y1 ? 1 : -1;
        }
    }

}