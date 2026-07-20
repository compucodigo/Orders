using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orders.Shared.Entities;

public class Category
{
    public int Id { get; set; }

    [Display(Name = "Categoria")]
    [MaxLength(80, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public required string Name { get; set; }
}

