using System.ComponentModel.DataAnnotations;

namespace Orders.Shared.Entities;

public class Country
{
    public int Id { get; set; }

    [Display(Name = "Pais")]
    [MaxLength(80, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public required string Name { get; set; }
}
