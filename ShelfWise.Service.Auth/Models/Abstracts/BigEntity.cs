using System.ComponentModel.DataAnnotations;

namespace ShelfWise.Service.Auth.Models.Abstracts;

public abstract class BigEntity
{
	[Key, Required] public long Id { get; set; }
}
