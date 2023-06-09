using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using cookbook_api.Models.Enums;

namespace cookbook_api.Models;

public class Recipe
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    [Column(TypeName = "varchar(100)")]
    public string Title { get; set; }
    
    [Required]
    public TypeRecipeEnum Category { get; set; }

    [Required]
    [Column(TypeName = "text")]
    public string Preparation { get; set; }

    [Required]
    public int PreparationTime { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    public DateTime UpdateAt { get; set; }

    //navigation property
    public List<Ingredients> Ingredients { get; set; }

    //navigation property 
    public User User { get; set; }

    //foreing key
    public int UserId { get; set; }

}
