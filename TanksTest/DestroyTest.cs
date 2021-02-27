using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tanks.Classes;
using Tanks.Interfaces;
using TanksTest.TestClasses;
using Tanks.Classes.Commands;

namespace TanksTest
{
	[TestClass]
	public class DestroyTest
	{
		/// <summary>
		/// Проверяет уничтожение существующего игрового объекта
		/// </summary>
		[TestMethod]
		public void Destroy_DestroyExistingObject()
		{
			var gameMaster = new GameMaster(
				(
				new Point(0, 0),
				new Point(10, 10)
				),
				new List<IEntity>()
			);

			var entityToDestroy = new TestEntity();
			entityToDestroy.properties["Name"] = "TO_DESTROY";
			gameMaster.AddGameObject(entityToDestroy);

			var iDestroyableEntity = new TestIDestroyable("TO_DESTROY");

			var destroyCommand = new Destroy(gameMaster, iDestroyableEntity);
			destroyCommand.Execute();

			Assert.IsTrue(gameMaster.GameObjects.Count == 0);
		}

		/// <summary>
		/// Проверяет уничтожение НЕсуществующего игрового объекта
		/// </summary>
		[TestMethod]
		public void Destroy_DestroyNonExistingObject()
		{
			var gameMaster = new GameMaster(
				(
				new Point(0, 0),
				new Point(10, 10)
				),
				new List<IEntity>()
			);

			var entityToDestroy = new TestEntity();
			entityToDestroy.properties["Name"] = "NOT_TO_DESTROY";
			gameMaster.AddGameObject(entityToDestroy);

			var iDestroyableEntity = new TestIDestroyable("TO_DESTROY");

			var destroyCommand = new Destroy(gameMaster, iDestroyableEntity);
			destroyCommand.Execute();

			Assert.IsTrue(gameMaster.GameObjects.Count == 1);
		}
	}
}
