using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UESAN.GESTIONTALLER.CORE.Core.Entities;

public partial class Vehiculo
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Placa { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Marca { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Modelo { get; set; } = null!;

    public int Anio { get; set; }

    public int ClienteId { get; set; }

    [ForeignKey("ClienteId")]
    [InverseProperty("Vehiculo")]
    public virtual Cliente Cliente { get; set; } = null!;

    [InverseProperty("Vehiculo")]
    public virtual ICollection<OrdenServicio> OrdenServicio { get; set; } = new List<OrdenServicio>();
}
