using System;
using System.Collections.Generic;
using Tanks.Interfaces;

namespace Tanks.Classes.Commands
{
	public class Shoot : ICommand
	{
		public IShootable ShootableEntity { get; set; }

		public IEntity Shoter { get; set; }

		public IGameMaster GameMaster { get; set; }

		public Shoot(IGameMaster gameMaster, IShootable shootableEntity, IEntity shoter)
		{
			ShootableEntity = shootableEntity;
			GameMaster = gameMaster;
			Shoter = shoter;
		}

		public bool Execute ()
		{
			Type bulletType = ShootableEntity.Weapon.GetType();
			IEntity instance = (IEntity) Activator.CreateInstance(
				bulletType,
				bulletType.Name,
				(Point)Shoter["Position"],
				(Point)Shoter["Velocity"] * 2,
				new List<string>
				{
					"DestoyableMove"
				},
				GameMaster
			);

			GameMaster.AddGameObject(instance);
			
			return true;
		}
	}
}
 