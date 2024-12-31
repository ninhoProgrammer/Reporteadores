using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Reserva
{
    public int RvFolio { get; set; }

    public string AlCodigo { get; set; } = null!;

    public int SeFolio { get; set; }

    public string MaCodigo { get; set; } = null!;

    public DateTime RvFecIni { get; set; }

    public string RvHorIni { get; set; } = null!;

    public DateTime RvFecFin { get; set; }

    public string RvHorFin { get; set; } = null!;

    public decimal RvDuracio { get; set; }

    public string RvResumen { get; set; } = null!;

    public string? RvDetalle { get; set; }

    public short UsCodigo { get; set; }

    public DateTime RvFecRes { get; set; }

    public string RvHorRes { get; set; } = null!;

    public short RvTipo { get; set; }

    public string RvLista { get; set; } = null!;

    public string RvOrden { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<CurAsi> CurAsis { get; set; } = new List<CurAsi>();
}
