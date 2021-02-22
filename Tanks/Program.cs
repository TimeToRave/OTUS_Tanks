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

			GameMaster gameMaster = new GameMaster(
				(
				new Point(-10, -10),
				new Point(10, 10)
				),
				gameObjects
			);

			

			Tank tank = new Tank(
				new Point(0, 0),
				new Point(1, 0),
				new List<string>
				{
					"Move",
					"Move",
					"Move",
					"RotateRight",
					"Move",
					"Move",
					"Move",
					"RotateLeft"
				},
				gameMaster
			);

			gameObjects.Add(tank);

			gameMaster.Start(100);

			Console.ReadKey();
		}	
	}
}
