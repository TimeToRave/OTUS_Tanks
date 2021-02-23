using Tanks.Interfaces;

namespace Tanks.Classes.Commands
{
	class Move : ICommand 
	{
		IMovable MovableEntity { get; set; }
		IGameMaster GameMaster { get; set; }
		public Move(IMovable movableEntity, IGameMaster gameMaster)
		{
			MovableEntity = movableEntity;
			GameMaster = gameMaster;
		}

		public bool Execute ()
		{
			Point newPosition = MovableEntity.Position + MovableEntity.Velocity;

			if (GameMaster.CheckIsInField(newPosition))
			{
				MovableEntity.Position = newPosition;
			}
			return true;
		}
	}
}
