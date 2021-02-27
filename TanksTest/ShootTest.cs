using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tanks.Classes;
using Tanks.Classes.Commands;
using Tanks.Interfaces;
using TanksTest.TestClasses;

namespace TanksTest
{
	[TestClass]
	public class ShootTest
	{
		/// <summary>
		/// Проверяет, что созданный снаряд добавляется в список игровых объектов
		/// </summary>
		[TestMethod]
		public void Shoot_GameObjectAdding()
		{
			var gameMaster = new GameMaster(
				(
				new Point(0, 0),
				new Point(10, 10)
				),
				new List<IEntity>()
			);

			var shoterEntity = new TestEntity();

			shoterEntity["Position"] = new Point(0, 0);
			shoterEntity["Velocity"] = new Point(0, 1);

			var shoot = new Shoot(gameMaster, new TestIShootable(), shoterEntity);
			shoot.Execute();
			Assert.IsTrue(gameMaster.GameObjects.Count == 1);
		}

		/// <summary>
		/// Проверяет корректность установки начальной скорости снаряда
		/// </summary>
		[TestMethod]
		public void Shoot_BulletVelocityIsDouble()
		{
			var gameMaster = new GameMaster(
				(
				new Point(0, 0),
				new Point(10, 10)
				),
				new List<IEntity>()
			);

			var shoterEntity = new TestEntity();

			shoterEntity["Position"] = new Point(0, 0);
			shoterEntity["Velocity"] = new Point(0, 1);

			var shoot = new Shoot(gameMaster, new TestIShootable(), shoterEntity);
			shoot.Execute();

			var bullet = gameMaster.GameObjects.Last();
			
			Assert.IsTrue(
				((Point)((TestEntity)bullet).properties["Velocity"]).X == 0 &&
				((Point)((TestEntity)bullet).properties["Velocity"]).Y == 2
			);
		}
	}
}
