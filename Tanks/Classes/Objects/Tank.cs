using System.Collections.Generic;
using Tanks.Adapters;
using Tanks.Classes.Commands;
using Tanks.Interfaces;

namespace Tanks.Classes.Objects
{
	class Tank : IEntity
	{
		/// <summary>
		/// Справочник команд, которые может выполнять объект
		/// </summary>
		public Dictionary<string, ICommand> Commands { get; set; }

		/// <summary>
		/// Сценарий поведения объекта, представляет из себя
		/// список дейсвтвий, которые выполняются друг за другом каждый
		/// момент игрового времени
		/// </summary>
		public List<ICommand> Behavior { get; set; }

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="start">Начальные координаты</param>
		/// <param name="initialVelocity">Скорость танка</param>
		/// <param name="behaviors">Список шагов, определяющие поведение танка</param>
		public Tank(Point start, Point initialVelocity, List<string> behaviors)
		{
			properties = new Dictionary<string, object>();
			Behavior = new List<ICommand>();

			properties["Position"] = start;
			properties["Velocity"] = initialVelocity;

			Commands = new Dictionary<string, ICommand>();
			Commands.Add("Move", new Move(new MovableAdapter(this)));

			foreach (string behavior in behaviors)
			{
				Behavior.Add(Commands[behavior]);
			}
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

		public string GetInfo()
		{
			string info = string.Format("Position: {0}", this["Position"].ToString());
			return info;
		}
	}
}
