using System;
using System.Collections.Generic;
using Tanks.Classes;
using Tanks.Interfaces;

namespace TanksTest.TestClasses
{
	class TestEntity : IEntity
	{
		/// <summary>
		/// Сценарий поведения объекта, представляет из себя
		/// список действий, которые выполняются друг за другом каждый
		/// момент игрового времени
		/// </summary>
		public List<ICommand> Behavior { get; set; }

		/// <summary>
		/// Конструктор
		/// </summary>
		public TestEntity()
		{
			properties = new Dictionary<string, object>();
			properties["Name"] = "Test entity " + Guid.NewGuid().ToString();
		}

		public TestEntity(string name, Point start, Point initialVelocity, List<string> behaviors, IGameMaster gameMaster)
		{
			properties = new Dictionary<string, object>();
			Behavior = new List<ICommand>();

			properties["Name"] = name;
			properties["Position"] = start;
			properties["Velocity"] = initialVelocity;
		}

		/// <summary>
		/// Свойства объекта
		/// </summary>
		public Dictionary<string, object> properties { get; set; }
		public object this[string key]
		{
			get { return properties[key]; }
			set { properties[key] = value; }
		}


		/// <summary>
		/// Возвращает информацию об объекте
		/// </summary>
		/// <returns></returns>
		public string GetInfo()
		{
			return "Test entity info";
		}
	}

	public class TestIShootable : IShootable
	{
		public IEntity Weapon { get; set; }

		public TestIShootable ()
		{
			var entity = new TestEntity();
			entity.properties.Add("Weapon", new TestEntity());
			Weapon = entity;
		}
	}
}
