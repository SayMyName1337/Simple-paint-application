using System;
using System.Collections.Generic;
using System.Drawing;

using OpenTK.Graphics.OpenGL;

namespace LR4
{
    /// <summary>
    /// Класс, реализующий сферу
    /// </summary>
    public class Sphere : List<List<Point3D>>
    {
        #region Свойства
        /// <summary>
        /// Координаты центра сферы
        /// </summary>
        public Point3D Center { get; set; }

        /// <summary>
        /// Радиус сферы
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Цвет сферы
        /// </summary>
        public Color Color { get; set; }

        public DrawingType DrawType { get; set; } 
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Sphere() : base()
        {
            Center = new Point3D();
            Radius = 1;
            Color = Color.Black;
        }

        /// <summary>
        /// Параметрический конструктор
        /// </summary>
        /// <param name="center">Координата центра</param>
        /// <param name="radius">Радиус</param>
        /// <param name="color">Цвет</param>
        public Sphere(Point3D center, double radius, Color color) : base()
        {
            Center = center;
            Radius = radius;
            Color = color;
            Init();
        }
        #endregion

        #region Методы
        /// <summary>
        /// Инициализация сферы
        /// </summary>
        private void Init()
        {
            for (double u = -Math.PI; u <= Math.PI; u += Math.PI / 25)
            {
                List<Point3D> vList = new List<Point3D>();
                for (double v = 0; v <= 2 * Math.PI; v += Math.PI / 25)
                {
                    Point3D point = new Point3D();
                    point.x = Radius * Math.Cos(u) * Math.Cos(v) + Center.x;
                    point.y = Radius * Math.Cos(u) * Math.Sin(v) + Center.y;
                    point.z = Radius * Math.Sin(u) + Center.z;
                    vList.Add(point);
                }
                Add(vList);
            }
        }

        /// <summary>
        /// Обновление сферы
        /// </summary>
        public void Refresh()
        {
            Clear();
            Init();
        }

        public void Draw()
        {
            GL.Disable(EnableCap.ColorMaterial);

            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Ambient, new float[] { 0.2f, 0.2f, 0.2f });
            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Diffuse, new float[] { 0.7f, 0.7f, 0.7f });
            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Specular, new float[] { 0.6f, 0.6f, 0.6f });
            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Shininess, new float[] { 0.8f * 128 });


            switch (DrawType)
            {
                case DrawingType.SOLID:
                    DrawSolid();
                    break;

                case DrawingType.WIRED:
                    DrawWired();
                    break;

                case DrawingType.DOTTED:
                    DrawPoints();
                    break;
            }

            GL.Enable(EnableCap.ColorMaterial);
            GL.ColorMaterial(MaterialFace.FrontAndBack, ColorMaterialParameter.AmbientAndDiffuse);
        }

        /// <summary>
        /// Режим рисования точками
        /// </summary>
        private void DrawPoints()
        {
            GL.Color3(Color);
            for (int i = 0; i < Count - 1; i++)
            {
                for (int j = 0; j < this[i].Count - 1; j++)
                {
                    GL.Begin(BeginMode.Points);
                    GL.Vertex3(this[i][j].x, this[i][j].y, this[i][j].z);
                    GL.End();
                }
            }
        }

        private void DrawWired()
        {
            for (int i = 0; i < Count; i++)
            {
                GL.Begin(BeginMode.LineLoop);
                for (int j = 0; j < this[i].Count - 1; j++)
                {
                    GL.Vertex3(this[i][j].x, this[i][j].y, this[i][j].z);
                }
                GL.End();
            }

            for (int j = 0; j < this[0].Count - 1; j++)
            {
                GL.Begin(BeginMode.LineStrip);
                for (int i = 0; i < Count; i++)
                {
                    GL.Vertex3(this[i][j].x, this[i][j].y, this[i][j].z);
                }
                GL.End();
            }
        }

        /// <summary>
        /// Режим рисования полигонами (сплошное тело)
        /// </summary>
        private void DrawSolid()
        {
            bool c1 = true;

            for (int i = 0; i < Count; i++)
            {
                if(i%2 == 0) c1 = !c1;
                for (int j = 0; j < this[i].Count - 1; j++)
                {
                    if (c1)
                    {
                        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Ambient, new float[] { 0.2f, 0.2f, 0.4f });
                        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Diffuse, new float[] { 0.7f, 0.7f, 0.7f });
                        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Specular, new float[] { 0.6f, 0.6f, 0.6f });
                        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Shininess, new float[] { 0.8f * 128 });
                    }
                    else
                    {
                        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Ambient, new float[] { 0.4f, 0.2f, 0.2f });
                        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Diffuse, new float[] { 0.7f, 0.7f, 0.7f });
                        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Specular, new float[] { 0.6f, 0.6f, 0.6f });
                        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Shininess, new float[] { 0.8f * 128 });
                    }

                    int k = i + 1 < this.Count ? i + 1 : 0;
                    int m = j + 1;

                    GL.Color3(Color);
                    GL.Begin(BeginMode.Polygon);

                    GL.Normal3(this[i][j].x, this[i][j].y, this[i][j].z);
                    GL.Vertex3(this[i][j].x, this[i][j].y, this[i][j].z);

                    GL.Normal3(this[k][j].x, this[k][j].y, this[k][j].z);
                    GL.Vertex3(this[k][j].x, this[k][j].y, this[k][j].z);

                    GL.Normal3(this[k][m].x, this[k][m].y, this[k][m].z);
                    GL.Vertex3(this[k][m].x, this[k][m].y, this[k][m].z);

                    GL.Normal3(this[i][m].x, this[i][m].y, this[i][m].z);
                    GL.Vertex3(this[i][m].x, this[i][m].y, this[i][m].z);

                    GL.End();

                    c1 = !c1;
                }
            }
        }
        #endregion
    }

    public enum DrawingType
    {
        SOLID, WIRED, DOTTED
    }
}
