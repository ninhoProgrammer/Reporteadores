using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Periodo
{
    public short PeYear { get; set; }

    public short PeTipo { get; set; }

    public short PeNumero { get; set; }

    public string PeDescrip { get; set; } = null!;

    public short PeUso { get; set; }

    public short PeStatus { get; set; }

    public string PeIncBaj { get; set; } = null!;

    public string PeSoloEx { get; set; } = null!;

    public DateTime PeFecIni { get; set; }

    public DateTime PeFecFin { get; set; }

    public DateTime PeFecPag { get; set; }

    public short PeMes { get; set; }

    public short PeDias { get; set; }

    public short PeDiasAc { get; set; }

    public short PeDiaMes { get; set; }

    public short PePosMes { get; set; }

    public short PePerMes { get; set; }

    public short PePerTot { get; set; }

    public DateTime PeFecMod { get; set; }

    public string PeAhorro { get; set; } = null!;

    public string PePrestam { get; set; } = null!;

    public int PeNumEmp { get; set; }

    public decimal PeTotPer { get; set; }

    public decimal PeTotNet { get; set; }

    public decimal PeTotDed { get; set; }

    public short UsCodigo { get; set; }

    public short PeCandado { get; set; }

    public string PeLog { get; set; } = null!;

    public DateTime PeAsiIni { get; set; }

    public DateTime PeAsiFin { get; set; }

    public string PeCal { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<MovGral> MovGrals { get; set; } = new List<MovGral>();

    public virtual ICollection<Nomina> Nominas { get; set; } = new List<Nomina>();

    public virtual ICollection<PolHead> PolHeads { get; set; } = new List<PolHead>();
}
