using System.ComponentModel.DataAnnotations;

namespace Airline.Domain.Entity;

/// <summary>
/// Модель воздушного судна
/// </summary>
public class Aircraft
{
    /// <summary>
    /// Уникальный идентификатор самолета
    /// </summary>
    [Key]
    public required int Id { get; set; }

    /// <summary>
    /// Модель самолета (например, "Boeing 737-800")
    /// </summary>
    public required string Model { get; set; }

    /// <summary>
    /// Грузоподъемность в тоннах
    /// </summary>
    public required double LoadCapacity { get; set; }

    /// <summary>
    /// Производительность (показатель эффективности)
    /// </summary>
    public required double Performance { get; set; }

    /// <summary>
    /// Максимальное количество пассажиров
    /// </summary>
    public required int MaxPassengers { get; set; }
}