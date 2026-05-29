using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UESAN.GESTIONTALLER.CORE.Core.Entities;

public partial class Cliente
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Paterno { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Materno { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Nombres { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? Correo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [InverseProperty("Cliente")]
    public virtual ICollection<Vehiculo> Vehiculo { get; set; } = new List<Vehiculo>();

    




}
