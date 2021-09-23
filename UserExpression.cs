using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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
        public PointPairList pointList { get; set; }
        public double step = 1;

        public Task<PointPairList> getGraphPoints()
        {
            //expression.checkSyntax();
            //expression.getErrorMessage();
            pointList = new PointPairList();
            return Task.Run(() => {
                for (double pointX = a; pointX <= b; pointX += step)
                {
                    double pointY = getPointY(pointX);
                    pointList.Add(new PointPair(pointX, pointY));
                    Debug.WriteLine(String.Format("x={0}, y={1}", pointX, pointY));
                }
                return pointList;
            });
        }

        private double getPointY(double pointX)
        {
            Argument x = new Argument("x = " + pointX);
            Expression expression = new Expression(userExpression, x);
            double pointY = expression.calculate();
            return pointY;
        }

        public double findMinPoint()
        {
            //ищет макс вместо мин
            double leftX = a;
            double rightX = b;
            double leftY = getPointY(a);
            double rightY = getPointY(b);
            double middleX = (leftX + rightX) / 2;
            double middleY = getPointY(middleX);
            while (rightX - leftX >= precision)
            {
                Debug.WriteLine(String.Format("rightX - leftX={0}", rightX - leftX));
                if (leftY * middleY < 0)
                {
                    leftX = middleX;
                }
                else
                {
                    rightX = middleX;
                }
                middleX = (leftX + rightX) / 2;
                middleY = getPointY(middleX);
                Debug.WriteLine(String.Format("middleX={0}, middleY={1}", middleX, middleY));
            }
            return middleY;
        }
    }
}
