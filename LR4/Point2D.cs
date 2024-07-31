using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK.Graphics.OpenGL;

namespace LR4
{
    /// <summary>
    /// Класс точки в 2-х мерном пространстве
    /// </summary>
    public class Point2D
    {
        #region Свойства
        public double X { get; set; }
        public double Y { get; set; }

        public bool IsSelected { get; set; }

        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Point2D()
        {
            X = 0;
            Y = 0;
        }

        /// <summary>
        /// Параметрический конструктор
        /// </summary>
        /// <param name="_x">Координата X</param>
        /// <param name="_y">Координата Y</param>
        public Point2D(double _x, double _y)
        {
            X = _x;
            Y = _y;
        }
        #endregion

        #region Методы

        public bool Hit(int x, int y)
        {
            IsSelected = x >= X - 3 && x <= X + 3 && y >= Y - 3 && y <= Y + 3;
            return IsSelected;
        }

        public void Draw()
        {
            GL.PointSize(6);

            if (IsSelected)
                GL.Color3(Color.Red);
            else
                GL.Color3(Color.Blue);

            GL.Begin(BeginMode.Points);

            GL.Vertex2(X, Y);

            GL.End();
        }

        public void Drag(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        #endregion
    }
}
