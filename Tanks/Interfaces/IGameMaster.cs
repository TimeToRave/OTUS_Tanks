using Tanks.Classes;

namespace Tanks.Interfaces
{
	interface IGameMaster
	{
		bool CheckIsInField(Point position);
		void DestroyGameObject(IEntity entity);
	}
}
