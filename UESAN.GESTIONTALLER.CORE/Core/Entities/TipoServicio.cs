using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UESAN.GESTIONTALLER.CORE.Core.Entities;

public partial class TipoServicio
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PrecioBase { get; set; }

    [InverseProperty("TipoServicio")]
    public virtual ICollection<OrdenServicio> OrdenServicio { get; set; } = new List<OrdenServicio>();
}
