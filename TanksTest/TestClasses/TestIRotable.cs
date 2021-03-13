using Tanks.Classes;
using Tanks.Interfaces;

namespace TanksTest.TestClasses
{
	class TestIRotable : IRotable
	{
		/// <summary>
		/// Моментальная скорость
		/// </summary>
		public Point Velocity { get; set; }

		/// <summary>
		/// Конструктор по умолчанию
		/// </summary>
		public TestIRotable() : this(new Point(0, 0)) { }

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="velocity">Начальная моментальная скорость</param>
		public TestIRotable(Point velocity)
		{
			Velocity = velocity;
		}
	}
}
