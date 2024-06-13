using System.ComponentModel.DataAnnotations;

namespace Bulkyweb;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public required string Name { get; set; }   //not null because of annotations
    public int DisplayOrder { get; set; }

}
