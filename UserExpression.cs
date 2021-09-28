using System;
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
        public double step = 1;

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
                double leftX = a;
                double leftY = getPointY(a);
                double rightX = b;
                double rightY = getPointY(b);
                double middleX = (leftX + rightX) / 2;
                double middleY = getPointY(middleX);

                while (Math.Abs(rightY - leftY) > precision)
                {
                    if (leftY > rightY)
                    {
                        leftX = middleX;
                    }
                    else
                    {
                        rightX = middleX;
                    }
                    leftY = getPointY(leftX);
                    rightY = getPointY(rightX);
                    middleX = (leftX + rightX) / 2;
                    middleY = getPointY(middleX);
                }
                PointPairList minPointList = new PointPairList();
                minPointList.Add(new PointPair(middleX, middleY));
                return minPointList;
            });
        }
    }
}
