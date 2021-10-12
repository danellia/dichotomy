using System;
using System.Diagnostics;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;
using ZedGraph;

namespace dichotomy
{
    class UserExpression
    {
        public double a { get; set; }
        public double b { get; set; }
        public double precision { get; set; }
        public string userExpression { get; set; }
        int step = 1;

        public Task<PointPairList> getGraphPoints()
        {
            PointPairList pointList = new PointPairList();
            return Task.Run(() => {
                for (double pointX = a; pointX <= b; pointX += step)
                {
                    double pointY = getPointY(pointX);
                    pointList.Add(new PointPair(pointX, pointY));
                }
                return pointList;
            });
        }
        public double getPointY(double pointX)
        {
            Argument x = new Argument("x = " + pointX);
            Expression expression = new Expression(userExpression, x);
            double pointY = expression.calculate();
            return pointY;
        }
        public Task<PointPairList> getMinPointCoords()
        {
            return Task.Run(() =>
            {
                double middleX = 0;
                double middleY = 0;
                while (Math.Abs(getPointY(b) - getPointY(a)) > precision)
                {
                    middleX = (a + b) / 2;
                    if (double.IsNaN(getPointY(middleX)))
                    {
                        middleX -= precision;
                    }
                    middleY = getPointY(middleX);
                    if (getPointY(a) > getPointY(b))
                    {
                        a = middleX;
                    }
                    else
                    {
                        b = middleX;
                    }
                }
                PointPairList minPointList = new PointPairList();
                minPointList.Add(new PointPair(round(middleX), round(middleY)));
                return minPointList;
            });
        }
        private double round(double coord)
        {
            return Math.Round(coord, precision.ToString().Length - 2);
        }
    }
}
