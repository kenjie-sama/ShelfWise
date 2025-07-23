using ShelfWise.Service.Auth.AppCode.Globals;
using System.ComponentModel.DataAnnotations;

namespace ShelfWise.Service.Auth.Models.Abstracts
{
	public abstract class HashedEntity
	{
    [Required, Key] public string Id { get; set; }

    public HashedEntity(string prefix, int iteration = 4) => Id = Utils.Security.GenerateExtendedGuid(prefix, iteration);
  }
}
