using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Perfil
{
    public string PuCodigo { get; set; } = null!;

    public string? PfDescrip { get; set; }

    public string? PfObjetiv { get; set; }

    public string? PfPosting { get; set; }

    public short PfEstudio { get; set; }

    public DateTime PfFecha { get; set; }

    public short PfExpPto { get; set; }

    public string PfContrl1 { get; set; } = null!;

    public string PfContrl2 { get; set; } = null!;

    public decimal PfNumero1 { get; set; }

    public string PfTexto1 { get; set; } = null!;

    public decimal PfNumero2 { get; set; }

    public short PfEdadmin { get; set; }

    public short PfEdadmax { get; set; }

    public string PfTexto2 { get; set; } = null!;

    public string PfSexo { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<DescPto> DescPtos { get; set; } = new List<DescPto>();

    public virtual Puesto PuCodigoNavigation { get; set; } = null!;
}
