using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace dichotomy
{
    public partial class Form1 : Form
    {
        GraphPane pane;
        public Form1()
        {
            InitializeComponent();
            pane = zedGraphControl.GraphPane;
            pane.Title.Text = "Графики";
        }
        private async void countToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                UserExpression expression = new UserExpression()
                {
                    a = Convert.ToDouble(textBoxA.Text),
                    b = Convert.ToDouble(textBoxB.Text),
                    precision = Convert.ToDouble(textBoxE.Text),
                    userExpression = textBoxExpression.Text
                };
                
                if (double.IsNaN(expression.getPointY(expression.a)))
                {
                    throw new Exception("Неверно записана F(x)!");
                }

                if (expression.precision <= 0)
                {
                    throw new Exception("Неверно записана точность!");
                }

                if (expression.a >= expression.b)
                {
                    throw new Exception("A не может быть больше или равна B!");
                }

                Task<PointPairList> getPoints = expression.getGraphPoints();
                LineItem curve = pane.AddCurve(expression.userExpression, await getPoints, Color.Purple, SymbolType.None);
                zedGraphControl.AxisChange();
                zedGraphControl.Refresh();

                Task<PointPairList> getMinPointCoords = expression.getMinPointCoords();
                LineItem minPoint = pane.AddCurve("", await getMinPointCoords, Color.BlueViolet, SymbolType.Circle);
                textBoxMinPointX.Text = getMinPointCoords.Result[0].X.ToString();
                textBoxMinPointY.Text = getMinPointCoords.Result[0].Y.ToString();

                if(getPoints.Result.Contains(getMinPointCoords.Result[0]))
                {
                    zedGraphControl.AxisChange();
                }
                zedGraphControl.Refresh();
            }
            catch (FormatException)
            {
                MessageBox.Show("Заполните пустые поля!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void clearAllStripMenuItem_Click(object sender, EventArgs e)
        {
            clearValueTextBoxes();
            clearMinPointTextBoxes();
            clearGraph();
        }
        private void clearGraphtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearMinPointTextBoxes();
            clearGraph();
        }
        private void clearValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearValueTextBoxes();
            clearMinPointTextBoxes();
        }
        private void clearValueTextBoxes()
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxE.Clear();
            textBoxExpression.Clear();
        }
        private void clearMinPointTextBoxes()
        {
            textBoxMinPointX.Clear();
            textBoxMinPointY.Clear();
        }
        private void clearGraph()
        {
            pane.CurveList.Clear();
            zedGraphControl.Refresh();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void checkDoubleInput(TextBox textBox, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && textBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
        private void textBoxA_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDoubleInput(textBoxA, e);
        }
        private void textBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDoubleInput(textBoxB, e);
        }
        private void textBoxE_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDoubleInput(textBoxE, e);
        }
    }
}
