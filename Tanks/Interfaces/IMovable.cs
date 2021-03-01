using Tanks.Classes;

namespace Tanks.Interfaces
{
	/// <summary>
	/// Интерфейс, описывающий объект, который может двигаться
	/// </summary>
	public interface IMovable
	{
		/// <summary>
		/// Текущая позиция
		/// </summary>
		Point Position { get; set; }

		/// <summary>
		/// Моментальная скорость
		/// </summary>
		Point Velocity { get; set; }
	}
}
