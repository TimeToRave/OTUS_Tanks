using Tanks.Classes.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TanksTest.TestClasses;
using Tanks.Classes;
using Tanks.Interfaces;

namespace TanksTest
{
	[TestClass]
	public class RotateTest
	{
		/// <summary>
		/// Проверяет поворот направо (90 градусов по часовой стрелке)
		/// Все координаты положительные
		/// </summary>
		[TestMethod]
		public void RotateToRight_InFirstGridQuarter()
		{
			Point initialVelocity = new Point(1, 0);
			IRotable objectToRotate = new TestIRotable(initialVelocity);
			ICommand rotator = new RotateRight(objectToRotate);

			rotator.Execute();

			Assert.IsTrue(objectToRotate.Velocity.Equals(new Point(0, 1)));
		}

		/// <summary>
		/// Проверяет поворот направо (90 градусов по часовой стрелке)
		/// Все координаты положительные и ненулевые
		/// </summary>
		[TestMethod]
		public void RotateToRight_FromFirstQuarterTwoFourth()
		{
			Point initialVelocity = new Point(2, 5);
			IRotable objectToRotate = new TestIRotable(initialVelocity);
			ICommand rotator = new RotateRight(objectToRotate);

			rotator.Execute();

			Assert.IsTrue(objectToRotate.Velocity.Equals(new Point(-5, 2)));
		}


		/// <summary>
		/// Проверяет поворот налево (90 градусов против часовой стрелки)
		/// Все координаты положительные
		/// </summary>
		[TestMethod]
		public void RotateToLeft_InSecondQuarter()
		{
			Point initialVelocity = new Point(1, 0);
			IRotable objectToRotate = new TestIRotable(initialVelocity);
			ICommand rotator = new RotateLeft(objectToRotate);

			rotator.Execute();

			Assert.IsTrue(objectToRotate.Velocity.Equals(new Point(0, -1)));
		}

		/// <summary>
		/// Проверяет поворот налево (90 градусов против часовой стрелки)
		/// Все координаты ненулевые
		/// </summary>
		[TestMethod]
		public void RotateToLeft_FromSecondQuarterTwoThird()
		{
			Point initialVelocity = new Point(2, -5);
			IRotable objectToRotate = new TestIRotable(initialVelocity);
			ICommand rotator = new RotateLeft(objectToRotate);

			rotator.Execute();

			Assert.IsTrue(objectToRotate.Velocity.Equals(new Point(-5, -2)));
		}

	}
}
