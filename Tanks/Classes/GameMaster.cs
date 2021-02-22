using System;
using System.Collections.Generic;
using Tanks.Interfaces;

namespace Tanks.Classes
{
	public class GameMaster : IGameMaster
	{
		/// <summary>
		/// Ограничивает размер игрового поля
		/// </summary>
		public (Point, Point) FieldSize { get; set; }

		/// <summary>
		/// Коллекция всех игровых объектов
		/// </summary>
		public List<IEntity> GameObjects { get; set; }

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="fieldSize">Размеры поля</param>
		/// <param name="gameObjects">Коллекция обхектов</param>
		public GameMaster((Point, Point) fieldSize, List<IEntity> gameObjects)
		{
			FieldSize = fieldSize;
			GameObjects = gameObjects;
		}

		/// <summary>
		/// Начинает просчет движений на поле
		/// </summary>
		/// <param name="ticks"></param>
		public void Start(int ticks)
		{
			for (int i = 0; i < ticks; i++)
			{
				Update(i, GameObjects);
			}
		}

		/// <summary>
		/// Вызывает команду для каждого игрового объекта
		/// </summary>
		/// <param name="tick"></param>
		/// <param name="gameObjects"></param>
		public static void Update(int tick, List<IEntity> gameObjects)
		{
			foreach (IEntity gameObject in gameObjects)
			{
				int index = tick % gameObject.Behavior.Count;
				gameObject.Behavior[index].Execute();
				Console.WriteLine(gameObject.GetInfo());
			}
		}
	}
}
