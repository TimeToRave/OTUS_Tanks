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
				"Tank 1",
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
					"RotateLeft",
					"Shoot"
				},
				gameMaster
			);

			Tank tank2 = new Tank(
				"Tank 2",
				new Point(10, 10),
				new Point(0, -1),
				new List<string>
				{
					"Move",
					"Move",
					"Move",
					"Move",
					"Move",
					"Move",
					"Move",
					"Move",
					"Move",
					"RotateLeft",
					"Shoot",
					"RotateLeft"					
				},
				gameMaster
			);

			gameObjects.Add(tank);
			gameObjects.Add(tank2);

			gameMaster.Start(100);

			Console.ReadKey();
		}	
	}
}
