using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tanks.Classes;
using Tanks.Adapters;
using Tanks.Interfaces;
using TanksTest.TestClasses;

namespace TanksTest
{
	[TestClass]
	public class GameMasterTest
	{
		/// <summary>
		/// Тест метода проверки вхождения точки в игровое поле.
		/// На вход подается точка, входящая в игровое поле
		/// </summary>
		[TestMethod]
		public void CheckIsInField_IsInField()
		{
			var gameMaster = new GameMaster(
				(
				new Point(0, 0),
				new Point(10, 10)
				),
				new List<IEntity>()
			);

			Assert.IsTrue(gameMaster.CheckIsInField(new Point(5, 5)));
		}

		/// <summary>
		/// Тест метода проверки вхождения точки в игровое поле.
		/// На вход подается точка, НЕ входящая в игровое поле
		/// </summary>
		[TestMethod]
		public void CheckIsInField_NotIsInField()
		{
			var gameMaster = new GameMaster(
				(
				new Point(0, 0),
				new Point(10, 10)
				),
				new List<IEntity>()
			);

			Assert.IsFalse(gameMaster.CheckIsInField(new Point(-5, -5)));
		}

		/// <summary>
		/// Тест метода проверки вхождения точки в игровое поле.
		/// На вход подается точка, лежащая на границе игрового поля
		/// </summary>
		[TestMethod]
		public void CheckIsInField_PointOnBorder()
		{
			var gameMaster = new GameMaster(
				(
				new Point(0, 0),
				new Point(10, 10)
				),
				new List<IEntity>()
			);

			Assert.IsTrue(gameMaster.CheckIsInField(new Point(0, 0)));
		}

		/// <summary>
		/// Тест метода удаления сущности из списка игровых объектов
		/// Проверяется удаление сущности, которая находится в списке игровых объектов
		/// </summary>
		[TestMethod]
		public void DestroyGameObject_DeleteExistingEntity()
		{

			var entityToDelete = new TestEntity();
			var entityNotToDelete = new TestEntity();
			List<IEntity> gameObjects = new List<IEntity>{
				entityToDelete,
				entityNotToDelete
			};

			var gameMaster = new GameMaster(
				(
				new Point(0, 0),
				new Point(10, 10)
				),
				gameObjects
			);


			gameMaster.DestroyGameObject(new DestroyableAdapter(entityToDelete));

			Assert.AreEqual(gameMaster.GameObjects.Count, 1);
		}

		/// <summary>
		/// Тест метода удаления сущности из списка игровых объектов
		/// Проверяется удаление сущности, которая отсутствует в списке игровых объектов
		/// </summary>
		[TestMethod]
		public void DestroyGameObject_DeleteNotExistingEntity()
		{

			var entityToDelete = new TestEntity();
			var entityNotToDelete = new TestEntity();
			List<IEntity> gameObjects = new List<IEntity>{
				entityToDelete,
				entityNotToDelete
			};

			var gameMaster = new GameMaster(
				(
				new Point(0, 0),
				new Point(10, 10)
				),
				gameObjects
			);


			gameMaster.DestroyGameObject(new DestroyableAdapter(new TestEntity()));

			Assert.AreNotEqual(gameMaster.GameObjects.Count, 1);
		}
	}
}
