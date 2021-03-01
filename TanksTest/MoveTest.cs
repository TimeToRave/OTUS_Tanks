using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tanks.Classes;
using Tanks.Classes.Commands;
using Tanks.Interfaces;
using TanksTest.TestClasses;

namespace TanksTest
{
	[TestClass]
	public class MoveTest
	{
		/// <summary>
		/// Проверяет изменение позиции при выполнении команды
		/// Стартовая позиция (0,0)
		/// </summary>
		[TestMethod]
		public void Move_FromZeroPoint()
		{
			var gameMaster = new GameMaster(
				(
				new Point(0, 0),
				new Point(10, 10)
				),
				new List<IEntity>()
			);

			var movebleObject = new TestIMovable(
				new Point(0, 0),
				new Point(0, 1)
			);

			var move = new Move(gameMaster, movebleObject);

			move.Execute();
			movebleObject.Position.Equals(new Point(0, 1));
		}

		/// <summary>
		/// Проверяет изменение позиции при выполнении команды
		/// Стартовая позиция не является (0,0)
		/// </summary>
		[TestMethod]
		public void Move_FromNonZeroPoint()
		{
			var gameMaster = new GameMaster(
				(
				new Point(0, 0),
				new Point(10, 10)
				),
				new List<IEntity>()
			);

			var movebleObject = new TestIMovable(
				new Point(5, 3),
				new Point(0, 3)
			);

			var move = new Move(gameMaster, movebleObject);

			move.Execute();
			movebleObject.Position.Equals(new Point(5, 6));
		}

		/// <summary>
		/// Проверяет изменение позиции при выполнении команды
		/// Движение по диагонали
		/// </summary>
		[TestMethod]
		public void Move_Diagonal()
		{
			var gameMaster = new GameMaster(
				(
				new Point(0, 0),
				new Point(10, 10)
				),
				new List<IEntity>()
			);

			var movebleObject = new TestIMovable(
				new Point(3, 3),
				new Point(2, 2)
			);

			var move = new Move(gameMaster, movebleObject);

			move.Execute();
			movebleObject.Position.Equals(new Point(5, 5));
		}
	}
}
