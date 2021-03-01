using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tanks.Classes;

namespace TanksTest
{
	[TestClass]
	public class PointTest
	{
		/// <summary>
		/// Тест, проверяющий сложение векторов
		/// </summary>
		[TestMethod]
		public void Point_PlusOperator()
		{
			Point p1 = new Point(1, 2);
			Point p2 = new Point(4, 5);

			Point result = p1 + p2;

			Assert.IsTrue(
				result.X == 5 &&
				result.Y == 7
			);
		}

		/// <summary>
		/// Тест, проверяющий умножение вектора на число
		/// </summary>
		[TestMethod]
		public void Point_MultiplyOnNumberOperator()
		{
			Point p1 = new Point(1, 2);

			Point result = p1 * 2;

			Assert.IsTrue(
				result.X == 2 &&
				result.Y == 4
			);
		}

		/// <summary>
		/// Тест, проверяющий обмен коориднатами друг с другом
		/// </summary>
		[TestMethod]
		public void Point_SwapCoordinates()
		{
			Point p1 = new Point(1, 2);

			p1.Swap();

			Assert.IsTrue(
				p1.X == 2 &&
				p1.Y == 1
			);
		}

		/// <summary>
		/// Тест, проверяющий метод сравнения двух координат
		/// Сравнивает две одинаковых координаты
		/// </summary>
		[TestMethod]
		public void Point_Equals_TwoEqualPoints()
		{
			Point p1 = new Point(1, 2);

			Assert.IsTrue(
				p1.Equals(new Point(1, 2))
			);
		}

		/// <summary>
		/// Тест, проверяющий метод сравнения двух координат
		/// Сравнивает две разных координаты
		/// </summary>
		[TestMethod]
		public void Point_Equals_TwoNonEqualPoints()
		{
			Point p1 = new Point(1, 2);

			Assert.IsFalse(
				p1.Equals(new Point(2, 2))
			);
		}

		/// <summary>
		/// Тест, проверяющий метод сравнения двух координат
		/// Сравнивает координату и объект
		/// </summary>
		[TestMethod]
		public void Point_Equals_PointAndNotPointObject()
		{
			Point p1 = new Point(1, 2);

			Assert.IsFalse(
				p1.Equals("Hello")
			);
		}
	}
}
