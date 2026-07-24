using Orders.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime;
using System.Text;

namespace Orders.Shared.Entities;

public class State : IEntityWithName
{
    public int Id { get; set; }

    [Display(Name = "Estado")]
    [MaxLength(80, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public required string Name { get; set; }
    public int CountryId { get; set; }
    public Country? Country { get; set; }
    public ICollection<City>? Cities { get; set; }
    public int CitiesNumbers => Cities == null ? 0 : Cities.Count;
}