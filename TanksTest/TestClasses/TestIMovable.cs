using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Classes;
using Tanks.Interfaces;

namespace TanksTest.TestClasses
{
	public class TestIMovable  : IMovable
	{
		/// <summary>
		/// Текущая позиция
		/// </summary>
		public Point Position { get; set; }

		/// <summary>
		/// Моментальная скорость
		/// </summary>
		public Point Velocity { get; set; }
		public TestIMovable(Point start, Point velocity)
		{
			Position = start;
			Velocity = velocity;
		}
	}
}
