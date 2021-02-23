using Tanks.Interfaces;

namespace Tanks.Classes.Commands
{
	class DestroyableMove : ICommand
	{
		IMovable MovableEntity { get; set; }
		IGameMaster GameMaster { get; set; }
		ICommand AlternameCommand { get; set; }

		public DestroyableMove(IGameMaster gameMaster, IMovable movableEntity, ICommand alternateCommand)
		{
			MovableEntity = movableEntity;
			GameMaster = gameMaster;
			AlternameCommand = alternateCommand;
		}

		public bool Execute()
		{
			Point newPosition = MovableEntity.Position + MovableEntity.Velocity;

			if (GameMaster.CheckIsInField(newPosition))
			{
				MovableEntity.Position = newPosition;
			} 
			else
			{
				AlternameCommand.Execute();
			}
			return true;
		}
	}
}