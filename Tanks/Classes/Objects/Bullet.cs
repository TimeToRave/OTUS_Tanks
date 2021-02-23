using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Adapters;
using Tanks.Classes.Commands;
using Tanks.Interfaces;

namespace Tanks.Classes.Objects
{
	class Bullet : IEntity
	{
		/// <summary>
		/// Справочник команд, которые может выполнять объект
		/// </summary>
		public Dictionary<string, ICommand> Commands { get; set; }

		/// <summary>
		/// Сценарий поведения объекта, представляет из себя
		/// список действий, которые выполняются друг за другом каждый
		/// момент игрового времени
		/// </summary>
		public List<ICommand> Behavior { get; set; }

		/// <summary>
		/// Объект, содержащий ограничения
		/// </summary>
		IGameMaster GameMaster { get; set; }

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="start">Начальные координаты</param>
		/// <param name="initialVelocity">Скорость</param>
		/// <param name="behaviors">Список шагов, определяющие поведение</param>
		public Bullet(string name, Point start, Point initialVelocity, List<string> behaviors, IGameMaster gameMaster)
		{
			GameMaster = gameMaster;

			properties = new Dictionary<string, object>();
			Behavior = new List<ICommand>();

			properties["Name"] = name;
			properties["Position"] = start;
			properties["Velocity"] = initialVelocity;

			Commands = new Dictionary<string, ICommand>
			{
				{ "DestoyableMove", new DestroyableMove(GameMaster, new MovableAdapter(this), new Destroy(GameMaster, new DestroyableAdapter(this))) }
			};

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


		/// <summary>
		/// Возвращает информацию об объекте
		/// </summary>
		/// <returns></returns>
		public string GetInfo()
		{
			string info = string.Format("[{0}] Position: {1}, Velocity {2}", this["Name"], this["Position"].ToString(), this["Velocity"].ToString());
			return info;
		}
	}
}
