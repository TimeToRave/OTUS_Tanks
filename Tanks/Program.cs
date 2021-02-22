using System;
using System.Collections.Generic;
using Tanks.Interfaces;
using Tanks.Classes;
using Tanks.Classes.Objects;

namespace Tanks
{
	class Program
	{
		static void Main()
		{
			List<IEntity> gameObjects = new List<IEntity>();

			Tank tank = new Tank(
				new Point(0, 0),
				new Point(1, 1),
				new List<string>
				{
					"Move",
					"Move",
					"Move"
				}
			);

			gameObjects.Add(tank);

			for (int i = 0; i < 100; i++)
			{
				Update(i, gameObjects);
			}

			Console.ReadKey();
		}

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
