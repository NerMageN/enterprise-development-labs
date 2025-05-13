using System.ComponentModel.DataAnnotations;

namespace Airline.Domain.Entity;

/// <summary>
/// Модель пассажира авиакомпании
/// </summary>
public class Passenger
{
    /// <summary>
    /// Уникальный идентификатор пассажира
    /// </summary>
    [Key]
    public required int Id { get; set; }

    /// <summary>
    /// Номер паспорта (серия и номер)
    /// </summary>
    public required string PassportNumber { get; set; }

    /// <summary>
    /// Полное имя пассажира (Фамилия Имя Отчество)
    /// </summary>
    public required string FullName { get; set; }
}