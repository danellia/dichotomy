
namespace dichotomy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.countToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearGraphtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelExpression = new System.Windows.Forms.Label();
            this.zedGraphControl = new ZedGraph.ZedGraphControl();
            this.labelMinPoint = new System.Windows.Forms.Label();
            this.labelMinPointX = new System.Windows.Forms.Label();
            this.labelMinPointY = new System.Windows.Forms.Label();
            this.textBoxMinPointX = new System.Windows.Forms.TextBox();
            this.textBoxMinPointY = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // countToolStripMenuItem
            // 
            this.countToolStripMenuItem.Name = "countToolStripMenuItem";
            this.countToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.countToolStripMenuItem.Text = "Рассчитать";
            this.countToolStripMenuItem.Click += new System.EventHandler(this.countToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllStripMenuItem,
            this.clearGraphtoolStripMenuItem,
            this.clearValuesToolStripMenuItem});
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.clearToolStripMenuItem.Text = "Очистить";
            // 
            // clearAllStripMenuItem
            // 
            this.clearAllStripMenuItem.Name = "clearAllStripMenuItem";
            this.clearAllStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.clearAllStripMenuItem.Text = "Всё";
            this.clearAllStripMenuItem.Click += new System.EventHandler(this.clearAllStripMenuItem_Click);
            // 
            // clearGraphtoolStripMenuItem
            // 
            this.clearGraphtoolStripMenuItem.Name = "clearGraphtoolStripMenuItem";
            this.clearGraphtoolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.clearGraphtoolStripMenuItem.Text = "График";
            this.clearGraphtoolStripMenuItem.Click += new System.EventHandler(this.clearGraphtoolStripMenuItem_Click);
            // 
            // clearValuesToolStripMenuItem
            // 
            this.clearValuesToolStripMenuItem.Name = "clearValuesToolStripMenuItem";
            this.clearValuesToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.clearValuesToolStripMenuItem.Text = "Значения";
            this.clearValuesToolStripMenuItem.Click += new System.EventHandler(this.clearValuesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(68, 42);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(125, 27);
            this.textBoxA.TabIndex = 1;
            this.textBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxA_KeyPress);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(68, 75);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(125, 27);
            this.textBoxB.TabIndex = 2;
            this.textBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxB_KeyPress);
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(68, 108);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(125, 27);
            this.textBoxE.TabIndex = 3;
            this.textBoxE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxE_KeyPress);
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.Location = new System.Drawing.Point(68, 141);
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(125, 27);
            this.textBoxExpression.TabIndex = 4;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(25, 45);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(37, 20);
            this.labelA.TabIndex = 5;
            this.labelA.Text = "A = ";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(26, 78);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(36, 20);
            this.labelB.TabIndex = 6;
            this.labelB.Text = "B = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "E = ";
            // 
            // labelExpression
            // 
            this.labelExpression.AutoSize = true;
            this.labelExpression.Location = new System.Drawing.Point(11, 144);
            this.labelExpression.Name = "labelExpression";
            this.labelExpression.Size = new System.Drawing.Size(51, 20);
            this.labelExpression.TabIndex = 8;
            this.labelExpression.Text = "F(x) = ";
            // 
            // zedGraphControl
            // 
            this.zedGraphControl.Location = new System.Drawing.Point(213, 33);
            this.zedGraphControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGraphControl.Name = "zedGraphControl";
            this.zedGraphControl.ScrollGrace = 0D;
            this.zedGraphControl.ScrollMaxX = 0D;
            this.zedGraphControl.ScrollMaxY = 0D;
            this.zedGraphControl.ScrollMaxY2 = 0D;
            this.zedGraphControl.ScrollMinX = 0D;
            this.zedGraphControl.ScrollMinY = 0D;
            this.zedGraphControl.ScrollMinY2 = 0D;
            this.zedGraphControl.Size = new System.Drawing.Size(858, 471);
            this.zedGraphControl.TabIndex = 10;
            this.zedGraphControl.UseExtendedPrintDialog = true;
            // 
            // labelMinPoint
            // 
            this.labelMinPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinPoint.AutoSize = true;
            this.labelMinPoint.Location = new System.Drawing.Point(45, 192);
            this.labelMinPoint.Name = "labelMinPoint";
            this.labelMinPoint.Size = new System.Drawing.Size(128, 20);
            this.labelMinPoint.TabIndex = 11;
            this.labelMinPoint.Text = "Точка минимума";
            // 
            // labelMinPointX
            // 
            this.labelMinPointX.AutoSize = true;
            this.labelMinPointX.Location = new System.Drawing.Point(28, 224);
            this.labelMinPointX.Name = "labelMinPointX";
            this.labelMinPointX.Size = new System.Drawing.Size(34, 20);
            this.labelMinPointX.TabIndex = 12;
            this.labelMinPointX.Text = "x = ";
            // 
            // labelMinPointY
            // 
            this.labelMinPointY.AutoSize = true;
            this.labelMinPointY.Location = new System.Drawing.Point(28, 254);
            this.labelMinPointY.Name = "labelMinPointY";
            this.labelMinPointY.Size = new System.Drawing.Size(34, 20);
            this.labelMinPointY.TabIndex = 13;
            this.labelMinPointY.Text = "y = ";
            // 
            // textBoxMinPointX
            // 
            this.textBoxMinPointX.Location = new System.Drawing.Point(68, 221);
            this.textBoxMinPointX.Name = "textBoxMinPointX";
            this.textBoxMinPointX.Size = new System.Drawing.Size(125, 27);
            this.textBoxMinPointX.TabIndex = 14;
            // 
            // textBoxMinPointY
            // 
            this.textBoxMinPointY.Location = new System.Drawing.Point(68, 254);
            this.textBoxMinPointY.Name = "textBoxMinPointY";
            this.textBoxMinPointY.Size = new System.Drawing.Size(125, 27);
            this.textBoxMinPointY.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 517);
            this.Controls.Add(this.textBoxMinPointY);
            this.Controls.Add(this.textBoxMinPointX);
            this.Controls.Add(this.labelMinPointY);
            this.Controls.Add(this.labelMinPointX);
            this.Controls.Add(this.labelMinPoint);
            this.Controls.Add(this.zedGraphControl);
            this.Controls.Add(this.labelExpression);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxExpression);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Метод дихотомии";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem countToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelExpression;
        private ZedGraph.ZedGraphControl zedGraphControl;
        private System.Windows.Forms.ToolStripMenuItem clearAllStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearGraphtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearValuesToolStripMenuItem;
        private System.Windows.Forms.Label labelMinPoint;
        private System.Windows.Forms.Label labelMinPointX;
        private System.Windows.Forms.Label labelMinPointY;
        private System.Windows.Forms.TextBox textBoxMinPointX;
        private System.Windows.Forms.TextBox textBoxMinPointY;
    }
}

