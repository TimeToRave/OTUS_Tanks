using System;

namespace Tanks.Classes
{
	/// <summary>
	///  Координата
	/// </summary>
	public class Point
	{
		public float X { get; set; }
		public float Y { get; set; }

		/// <summary>
		/// Конструктор по умолчанию
		/// </summary>
		public Point() : this(0, 0) {}

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="x">Координата по оси X</param>
		/// <param name="y">Координата по оси Y</param>
		public Point(float x, float y)
		{
			X = x;
			Y = y;
		}

		/// <summary>
		/// Опреатор сложения двух координат
		/// </summary>
		/// <param name="point1">Слагаемое 1</param>
		/// <param name="point2">Слагаемое 2</param>
		/// <returns>Сумма двух координат</returns>
		public static Point operator +(Point point1, Point point2)
		{
			Point sum = new Point();
			sum.X = point1.X + point2.X;
			sum.Y = point1.Y + point2.Y;
			return sum;
		}

		/// <summary>
		/// Оператор умножения координаты на число
		/// </summary>
		/// <param name="point1">Исходная координата</param>
		/// <param name="multiplier">Целое число, на которое будет умножен вектор</param>
		/// <returns>Реузльтат перемножения</returns>
		public static Point operator *(Point point1, int multiplier)
		{
			Point result = new Point();
			result.X = point1.X * multiplier;
			result.Y = point1.Y * multiplier;
			return result;
		}

		/// <summary>
		/// Преобразование координаты в текстовое представление
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return String.Format("( {0} ; {1} )", X, Y);
		}

		/// <summary>
		/// Производит обмен X и Y
		/// </summary>
		public void Swap ()
		{
			(X, Y) = (Y, X);
		}

		/// <summary>
		/// метод проверки равенства двух координат
		/// </summary>
		/// <param name="obj">Сравниваемый объект</param>
		/// <returns></returns>
		public override bool Equals (object obj)
		{
			bool result = false;

			if (obj is Point equalPoint)
			{
				result = (
					this.X == equalPoint.X &&
					this.Y == equalPoint.Y
				);
			}

			return result;
		}

		/// <summary>
		/// Получение хэша по умолчанию
		/// </summary>
		/// <returns>Хэш объекта</returns>
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
