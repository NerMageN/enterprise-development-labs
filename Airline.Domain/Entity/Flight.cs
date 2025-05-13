using System.ComponentModel.DataAnnotations;

namespace Airline.Domain.Entity;

/// <summary>
/// Модель рейса авиакомпании
/// </summary>
public class Flight
{
    /// <summary>
    /// Уникальный идентификатор рейса
    /// </summary>
    [Key]
    public required int Id { get; set; }

    /// <summary>
    /// Код рейса (например, "SU 1234")
    /// </summary>
    public required string Code { get; set; }

    /// <summary>
    /// Город/аэропорт отправления
    /// </summary>
    public required string DeparturePoint { get; set; }

    /// <summary>
    /// Город/аэропорт назначения
    /// </summary>
    public required string ArrivalPoint { get; set; }

    /// <summary>
    /// Дата отправления (без времени)
    /// </summary>
    public required DateTime DepartureDate { get; set; }

    /// <summary>
    /// Дата прибытия (без времени)
    /// </summary>
    public required DateTime ArrivalDate { get; set; }

    /// <summary>
    /// Время вылета (относительно даты отправления)
    /// </summary>
    public required TimeSpan DepartureTime { get; set; }

    /// <summary>
    /// Продолжительность полета
    /// </summary>
    public required TimeSpan TravelTime { get; set; }

    /// <summary>
    /// Тип воздушного судна
    /// </summary>
    public required string AircraftType { get; set; }
}