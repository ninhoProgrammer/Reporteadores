using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Kardex
{
    public int CbCodigo { get; set; }

    public DateTime CbFecha { get; set; }

    public string CbTipo { get; set; } = null!;

    public string CbAutosal { get; set; } = null!;

    public string CbClasifi { get; set; } = null!;

    public string CbComenta { get; set; } = null!;

    public string CbContrat { get; set; } = null!;

    public decimal CbFacInt { get; set; }

    public DateTime CbFecCap { get; set; }

    public DateTime CbFecCon { get; set; }

    public DateTime CbFecInt { get; set; }

    public DateTime CbFecRev { get; set; }

    public DateTime CbFecha2 { get; set; }

    public string CbGlobal { get; set; } = null!;

    public string CbTurno { get; set; } = null!;

    public decimal CbMonto { get; set; }

    public string CbMotBaj { get; set; } = null!;

    public short CbNivel { get; set; }

    public decimal CbOldInt { get; set; }

    public decimal CbOldSal { get; set; }

    public decimal CbOtrasP { get; set; }

    public string CbPatron { get; set; } = null!;

    public decimal CbPerVar { get; set; }

    public decimal CbPreInt { get; set; }

    public string CbPuesto { get; set; } = null!;

    public decimal CbRangoS { get; set; }

    public decimal CbSalInt { get; set; }

    public decimal CbSalTot { get; set; }

    public decimal CbSalario { get; set; }

    public short CbStatus { get; set; }

    public string CbTablass { get; set; } = null!;

    public decimal CbTotGra { get; set; }

    public short UsCodigo { get; set; }

    public string CbZonaGe { get; set; } = null!;

    public string CbNivel1 { get; set; } = null!;

    public string CbNivel2 { get; set; } = null!;

    public string CbNivel3 { get; set; } = null!;

    public string CbNivel4 { get; set; } = null!;

    public string CbNivel5 { get; set; } = null!;

    public string CbNivel6 { get; set; } = null!;

    public string CbNivel7 { get; set; } = null!;

    public string CbNivel8 { get; set; } = null!;

    public string CbNivel9 { get; set; } = null!;

    public string CbModNv1 { get; set; } = null!;

    public string CbModNv2 { get; set; } = null!;

    public string CbModNv3 { get; set; } = null!;

    public string CbModNv4 { get; set; } = null!;

    public string CbModNv5 { get; set; } = null!;

    public string CbModNv6 { get; set; } = null!;

    public string CbModNv7 { get; set; } = null!;

    public string CbModNv8 { get; set; } = null!;

    public string CbModNv9 { get; set; } = null!;

    public short CbNomtipo { get; set; }

    public short CbNomyear { get; set; }

    public short CbNomnume { get; set; }

    public string CbReingre { get; set; } = null!;

    public string? CbNota { get; set; }

    public DateTime CbFecIng { get; set; }

    public DateTime CbFecAnt { get; set; }

    public int CbPlaza { get; set; }

    public short CbNomina { get; set; }

    public string CbRecontr { get; set; } = null!;

    public string CbTipRev { get; set; } = null!;

    public DateTime CbFecSal { get; set; }

    public int Llave { get; set; }

    public DateTime? CbFecCov { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;

    public virtual Tkardex CbTipoNavigation { get; set; } = null!;

    public virtual ICollection<KarFija> KarFijas { get; set; } = new List<KarFija>();

    public virtual ICollection<Tmppromvar> Tmppromvars { get; set; } = new List<Tmppromvar>();
}
