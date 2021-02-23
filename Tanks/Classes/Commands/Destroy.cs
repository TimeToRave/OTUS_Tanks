using Tanks.Interfaces;

namespace Tanks.Classes.Commands
{
	class Destroy : ICommand
	{
		IDestroyable DestroyableEntity { get; set; }
		IGameMaster GameMaster { get; set; }

		public Destroy(IGameMaster gameMaster, IDestroyable destroyableEntity)
		{
			DestroyableEntity = destroyableEntity;
			GameMaster = gameMaster;
		}

		public bool Execute()
		{
			GameMaster.DestroyGameObject(DestroyableEntity);
			return true;
		}
	}
}
