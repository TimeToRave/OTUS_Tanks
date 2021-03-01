using Tanks.Interfaces;

namespace Tanks.Classes.Commands
{
	public class Move : ICommand 
	{
		IMovable MovableEntity { get; set; }
		IGameMaster GameMaster { get; set; }

		public Move(IGameMaster gameMaster, IMovable movableEntity)
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
