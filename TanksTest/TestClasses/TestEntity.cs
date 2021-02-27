using System;
using System.Collections.Generic;
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

		/// <summary>
		/// Свойства объекта
		/// </summary>
		private Dictionary<string, object> properties { get; set; }
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
}
