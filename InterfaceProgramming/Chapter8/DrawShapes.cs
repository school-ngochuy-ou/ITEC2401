using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter8 {

    public partial class DrawShapes : Form {

        private List<DecoratedRectangle> drawnRectangles = new List<DecoratedRectangle>();

        private List<DecoratedRectangle> drawnEllipses = new List<DecoratedRectangle>();

        private List<DecoratedTriangle> drawnTriangles = new List<DecoratedTriangle>();

        private Rectangle hoverRectangle;

        private Point[] trianglePoints = new Point[] {
            new Point(-1, -1), new Point(-1, -1), new Point(-1, -1)
        };

        private StatefulCursor cursor = new StatefulCursor();

        private DrawOption options = new DrawOption(Color.Red, Shape.RECTANGLE);

        public DrawShapes() {
            InitializeComponent();
            drawPanel.Paint += new PaintEventHandler(drawPanel_Paint);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        public void setOption(DrawOption options) {
            this.options = options;
        }

        private void hoverPanel_MouseClick(object sender, MouseEventArgs e) {
            if (cursor.state == CursorState.HOVER) {
                cursor.initX = e.X;
                cursor.initY = e.Y;
                trianglePoints[0] = new Point(e.X, e.Y);
                cursor.state = CursorState.DRAW;
                return;
            }

            switch (options.shape) {
                case Shape.RECTANGLE: {
                        drawnRectangles.Add(new DecoratedRectangle(options.color, new Rectangle(Math.Min(e.X, cursor.initX), Math.Min(e.Y, cursor.initY), Math.Abs(e.X - cursor.initX), Math.Abs(e.Y - cursor.initY))));
                        hoverRectangle = new Rectangle(-1, -1, 0, 0);

                        break;
                };
                case Shape.ELLIPSE: {
                        drawnEllipses.Add(new DecoratedRectangle(options.color, new Rectangle(Math.Min(e.X, cursor.initX), Math.Min(e.Y, cursor.initY), Math.Abs(e.X - cursor.initX), Math.Abs(e.Y - cursor.initY))));
                        hoverRectangle = new Rectangle(-1, -1, 0, 0);

                        break;
                };
                case Shape.TRIANGLE: {
                        drawnTriangles.Add(new DecoratedTriangle(options.color, trianglePoints));
                        trianglePoints = new Point[] {
                            new Point(-1, -1), new Point(-1, -1), new Point(-1, -1)
                        };

                        break;
                };
            }

            cursor.state = CursorState.HOVER;
            drawPanel.Invalidate();
            hoverPanel.Invalidate();
            return;
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e) {
            SolidBrush brush;

            foreach (DecoratedRectangle dr in drawnRectangles) {
                brush = new SolidBrush(dr.color);
                e.Graphics.FillRectangle(brush, dr.rectangle);
            }

            foreach (DecoratedRectangle dr in drawnEllipses) {
                brush = new SolidBrush(dr.color);
                e.Graphics.FillEllipse(brush, dr.rectangle);
            }

            foreach (DecoratedTriangle dt in drawnTriangles) {
                brush = new SolidBrush(dt.color);
                e.Graphics.FillPolygon(brush, dt.points);
            }
        }

        private void hoverPanel_Paint(object sender, PaintEventArgs e) {
            Pen pen = new Pen(Color.Black, 1);

            pen.Alignment = PenAlignment.Inset;

            switch (options.shape) {
                case Shape.RECTANGLE: {
                        e.Graphics.DrawRectangle(pen, hoverRectangle);
                        return;
                };
                case Shape.ELLIPSE: {
                        e.Graphics.DrawEllipse(pen, hoverRectangle);
                        return;
                };
                case Shape.TRIANGLE: {
                        e.Graphics.DrawPolygon(pen, trianglePoints);
                        return;
                }
            }
        }
        
        private void hoverPanel_MouseMove(object sender, MouseEventArgs e) {
            if (cursor.state == CursorState.DRAW) {
                if (options.shape != Shape.TRIANGLE) {
                    hoverRectangle = new Rectangle(Math.Min(e.X, cursor.initX), Math.Min(e.Y, cursor.initY), Math.Abs(e.X - cursor.initX), Math.Abs(e.Y - cursor.initY));
                    hoverPanel.Refresh();
                    return;
                }
                
                trianglePoints[1] = new Point(e.X, e.Y);
                trianglePoints[2] = new Point((Math.Abs(e.X - cursor.initX) / 2) + Math.Min(e.X, cursor.initX), e.Y + 100);
                hoverPanel.Refresh();
                return;
            }
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e) {
            drawnRectangles = new List<DecoratedRectangle>();
            drawnEllipses = new List<DecoratedRectangle>();
            drawnTriangles = new List<DecoratedTriangle>();
            hoverRectangle = new Rectangle(-1, -1, 0, 0);
            drawPanel.Invalidate();
            hoverPanel.Invalidate();
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e) {
            ShapeOption options = new ShapeOption();

            options.setParent(this);
            options.Show();
        }

    }

    public enum CursorState {
        HOVER, DRAW, FILL
    }

    public enum Shape {
        RECTANGLE, ELLIPSE, TRIANGLE
    }

    class StatefulCursor {

        public int initX { get; set; }

        public int initY { get; set; }

        public CursorState state = CursorState.HOVER;

    }

    public class DrawOption {

        public Color color { get; set; }

        public Shape shape { get; set; }

        public DrawOption(Color color, Shape shape) {
            this.color = color;
            this.shape = shape;
        }

    }

    public class DecoratedRectangle: DrawOption {

        public Rectangle rectangle { get; set; }

        public DecoratedRectangle(Color color, Rectangle rect): base(color, Shape.RECTANGLE) {
            rectangle = rect;
        }

    }

    public class DecoratedTriangle : DrawOption {

        public Point[] points { get; set; }

        public DecoratedTriangle(Color color, Point[] points) : base(color, Shape.TRIANGLE) {
            this.points = points;
        }

    }

}
