using System;
using System.Collections.Generic;
using System.Linq;
using Tanks.Interfaces;

namespace Tanks.Classes
{
	public class GameMaster : IGameMaster
	{
		/// <summary>
		/// Ограничивает размер игрового поля
		/// </summary>
		public (Point LeftBottom, Point RightTop) FieldSize { get; set; }

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
			for(int i = 0; i < gameObjects.Count; i++)
			{
				int index = tick % gameObjects[i].Behavior.Count;
				gameObjects[i].Behavior[index].Execute();
				Console.WriteLine(gameObjects[i].GetInfo());
			}
		}

		/// <summary>
		/// Выполняет проверку точки в игровом поле
		/// </summary>
		/// <param name="position">Координаты, проверяемого положения</param>
		/// <returns>Вхождение в поле</returns>
		public bool CheckIsInField (Point position) 
		{
			bool isInField = (
				(FieldSize.LeftBottom.X <= position.X) &&
				(FieldSize.RightTop.X >= position.X) &&
				(FieldSize.LeftBottom.Y <= position.Y) &&
				(FieldSize.RightTop.Y >= position.Y)
			);

			return isInField;
		}

		/// <summary>
		/// Исключает сущность из списка игровых объектов
		/// </summary>
		/// <param name="entity"></param>
		public void DestroyGameObject (IDestroyable entity)
		{
			Console.WriteLine(string.Format("Destroying {0} object", entity.Name));
			GameObjects = GameObjects.Where(go => go["Name"].ToString() != entity.Name).ToList();
			entity = null;	
		}

		public void AddGameObject(IEntity gameObject) 
		{
			GameObjects.Add(gameObject);
		}
	}
}
