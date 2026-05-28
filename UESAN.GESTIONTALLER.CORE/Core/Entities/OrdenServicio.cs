using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UESAN.GESTIONTALLER.CORE.Core.Entities;

public partial class OrdenServicio
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaIngreso { get; set; }

    [Unicode(false)]
    public string DescripcionProblema { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CostoEstimado { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Estado { get; set; } = null!;

    public int VehiculoId { get; set; }

    public int TipoServicioId { get; set; }

    [ForeignKey("TipoServicioId")]
    [InverseProperty("OrdenServicio")]
    public virtual TipoServicio TipoServicio { get; set; } = null!;

    [ForeignKey("VehiculoId")]
    [InverseProperty("OrdenServicio")]
    public virtual Vehiculo Vehiculo { get; set; } = null!;
}
