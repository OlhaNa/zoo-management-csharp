using ZooManagment.Enums;

namespace ZooManagment.Models;

public class Species
{
    public int Id {get; set;}
    public required string Name {get; set;}
    public required Classification Classification {get; set;}

}