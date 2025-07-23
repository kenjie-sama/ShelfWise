using System.ComponentModel.DataAnnotations;

namespace ShelfWise.Service.Auth.Models.Abstracts;

public abstract class SmallEntity
{
	[Key, Required] public int ID { get; set; }
}
