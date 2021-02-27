namespace Tanks.Interfaces
{
	/// <summary>
	/// Интерфейс, описывающий объект, который может быть уничтожен
	/// </summary>
	public interface IDestroyable
	{
		/// <summary>
		/// Название - идентификатор экземпляра
		/// </summary>
		string Name { get; set; }
	}
}
