
using Lab2.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models.View;

public record AddActorVM
{
    private static List<Actor> _Actors;

    [DataType(DataType.EmailAddress)]
    public string Mail { get; init; } = string.Empty; //mail

    [DataType(DataType.Password)]
    public string Password { get; init; } = string.Empty; //password

    [Display(Name = "Is Close")]
    public bool IsClose { get; init; } //checkbox

    [Display(Name = "Country")]
    public int CountryId { get; init; } //=> CountryId
    public Severity Severity { get; init; } //=> Select
    public List<int> AwardsIds { get; init; } = new(); //=>AwardsId => MultiSelect
    public static List<Actor> GetActorsList() => _Actors;
}
