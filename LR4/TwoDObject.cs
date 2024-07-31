using System.Collections.Generic;
using System.Drawing;

using OpenTK.Graphics.OpenGL;

namespace LR4
{
    public class TwoDObject
    {
        private List<Point2D> points;
        private Point2D selectedPoint;

        public Color LinesColor { get; set; } = Color.Black;
        public LineTypes LineType { get; set; }
        public int LineWidth { get; set; } = 1;

        public bool IsClosed { get; set; }

        public TwoDObject()
        {
            points = new List<Point2D>();
        }

        public bool Hit(int x, int y)
        {
            selectedPoint = null;
            foreach (Point2D p in points)
                if (p.Hit(x, y))
                    selectedPoint = p;
            return selectedPoint != null;
        }

        public void Draw()
        {
            foreach (Point2D p in points)
                p.Draw();

            GL.Color3(LinesColor);

            GL.LineWidth(LineWidth);

            if (LineType == LineTypes.DOTTED)
            {
                GL.Enable(EnableCap.LineStipple);
                GL.LineStipple(2, 0X00FF);
            }
            else
                GL.Disable(EnableCap.LineStipple);

            if (points.Count > 2 && IsClosed)
                GL.Begin(BeginMode.LineLoop);
            else
                GL.Begin(BeginMode.LineStrip);

            foreach (Point2D p in points)
                GL.Vertex2(p.X, p.Y);
            GL.End();
        }

        public void Drag(int dx, int dy)
        {
            if (selectedPoint == null)
                return;
            selectedPoint.X += dx;
            selectedPoint.Y += dy;
        }

        public void AddPoint(int x, int y)
        {
            points.Add(new Point2D(x, y));
        }

        public void RemovePoint()
        {
            if (selectedPoint == null)
                return;
            points.Remove(selectedPoint);
            selectedPoint = null;
        }

        public void CloseFigure()
        {
            IsClosed = true;
        }
    }

    public enum LineTypes
    {
        SOLID, DOTTED
    }
}
