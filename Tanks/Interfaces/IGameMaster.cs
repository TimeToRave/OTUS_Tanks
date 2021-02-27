using Tanks.Classes;

namespace Tanks.Interfaces
{
	public interface IGameMaster
	{
		bool CheckIsInField(Point position);
		void DestroyGameObject(IDestroyable entity);
		void AddGameObject(IEntity gameObject);
	}
}
