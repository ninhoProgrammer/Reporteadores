using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Concepto
{
    public string CoAPtu { get; set; } = null!;

    public string CoActivo { get; set; } = null!;

    public string CoCalcula { get; set; } = null!;

    public string CoDescrip { get; set; } = null!;

    public string CoFormula { get; set; } = null!;

    public string CoGImss { get; set; } = null!;

    public string CoGIspt { get; set; } = null!;

    public string CoImpCal { get; set; } = null!;

    public string CoImprime { get; set; } = null!;

    public string CoListado { get; set; } = null!;

    public string CoMensual { get; set; } = null!;

    public short CoNumero { get; set; }

    public string CoQuery { get; set; } = null!;

    public string CoRecibo { get; set; } = null!;

    public short CoTipo { get; set; }

    public string CoXIspt { get; set; } = null!;

    public string CoSubCta { get; set; } = null!;

    public string CoCambia { get; set; } = null!;

    public string CoDExt { get; set; } = null!;

    public string CoDNom { get; set; } = null!;

    public byte[]? CoDBlob { get; set; }

    public string? CoNota { get; set; }

    public int Llave { get; set; }

    public decimal? CoLimSup { get; set; }

    public decimal? CoLimInf { get; set; }

    public string? CoVerInf { get; set; }

    public string? CoVerSup { get; set; }

    public string? CoVerAcc { get; set; }

    public string? CoGpoAcc { get; set; }

    public string? CoSql { get; set; }

    public short? CoOrden { get; set; }

    public string? CoSqlIspt { get; set; }

    public string? CoSqlImpc { get; set; }

    public virtual ICollection<Acumula> Acumulas { get; set; } = new List<Acumula>();

    public virtual ICollection<MovGral> MovGrals { get; set; } = new List<MovGral>();

    public virtual ICollection<Movimien> Movimiens { get; set; } = new List<Movimien>();
}
