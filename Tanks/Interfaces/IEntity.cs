using System.Collections.Generic;

namespace Tanks.Interfaces
{
	/// <summary>
	/// Интерфейс универсальной игровой сущности
	/// Аналог объекта в javascript или ExpandoObject в шарпе
	/// key - свойство конкретного объекта
	/// </summary>
	public interface IEntity
	{
		/// <summary>
		/// Свойства объекта
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		object this[string key] { get; set; }
		
		/// <summary>
		/// Шаблон поведения объекта
		/// Список шагов, которые последовательно выполняются
		/// каждый тик игрового мира
		/// </summary>
		List<ICommand> Behavior { get; set; }

		/// <summary>
		/// Возвращает информацию об игровом объекте
		/// </summary>
		string GetInfo();
	}
}
