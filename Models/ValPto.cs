using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class ValPto
{
    public int VpFolio { get; set; }

    public short VlCodigo { get; set; }

    public string PuCodigo { get; set; } = null!;

    public DateTime VpFecha { get; set; }

    public string? VpComenta { get; set; }

    public decimal VpGrado { get; set; }

    public string VpPtCode { get; set; } = null!;

    public string VpPtNom { get; set; } = null!;

    public decimal VpPtGrad { get; set; }

    public DateTime VpFecIni { get; set; }

    public DateTime VpFecFin { get; set; }

    public short UsCodigo { get; set; }

    public short VpStatus { get; set; }

    public virtual Puesto PuCodigoNavigation { get; set; } = null!;

    public virtual Valplant VlCodigoNavigation { get; set; } = null!;

    public virtual ICollection<Vpunto> Vpuntos { get; set; } = new List<Vpunto>();
}
