using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    /// <summary>
    /// Класс точки в 3-х мерном пространстве
    /// </summary>
    public class Point3D
    {
        #region Свойства
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Point3D()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        /// <summary>
        /// Параметрический конструктор
        /// </summary>
        /// <param name="_x">Координата X</param>
        /// <param name="_y">Координата Y</param>
        /// <param name="_z">Координата Z</param>
        public Point3D(double _x, double _y, double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        #endregion
    }
}
