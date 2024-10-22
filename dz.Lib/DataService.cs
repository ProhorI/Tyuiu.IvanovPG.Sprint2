namespace dz.Lib
{
    public class DataService
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            //if (((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1)) && (x >= 0) && (x <= Math.Sqrt(2)/2) && (y >= Math.Sqrt(2)/2) && y <= 1 && y >= -1)
            if ((x * y + y * y <= 1) && (y >= x))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
