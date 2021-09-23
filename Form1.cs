using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
//эпсилон 10^-3, 10^-6
//подкрутить precision
//сообщения для NaN
//delete extra usings
//какой шаг?
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

                Task<PointPairList> getPoints = expression.getGraphPoints();
                LineItem curve = pane.AddCurve(expression.userExpression, await getPoints, Color.Purple, SymbolType.None);
                textBoxMinPointY.Text = expression.findMinPoint().ToString();
                zedGraphControl.AxisChange();
                zedGraphControl.Refresh();
            }
            catch (FormatException)
            {
                MessageBox.Show("Заполните пустые поля!");
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
