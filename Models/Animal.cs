using System.ComponentModel.DataAnnotations.Schema;
using ZooManagment.Enums;

namespace ZooManagment.Models;

public class Animal
{
    public int Id {get; set;} // automatic id allocation that datevbase has.That's why we dont have it required by user
    public required string Name{get; set;}

    public int SpeciesId {get; set;}

    //[ForeignKey("SpeciesId")]
    [ForeignKey(nameof(SpeciesId))]

    public Species Species {get; set;} = null!;

    public required Sex Sex {get; set;}

    public DateOnly? DateOfBirth {get; set;}

    public required DateOnly DateOfAcquisition {get; set;}
}
