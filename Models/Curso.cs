using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Curso
{
    public string CuCodigo { get; set; } = null!;

    public string CuActivo { get; set; } = null!;

    public string CuClasifi { get; set; } = null!;

    public decimal CuCosto1 { get; set; }

    public decimal CuCosto2 { get; set; }

    public decimal CuCosto3 { get; set; }

    public decimal CuHoras { get; set; }

    public string CuIngles { get; set; } = null!;

    public string CuNombre { get; set; } = null!;

    public string CuTexto { get; set; } = null!;

    public string? CuTexto1 { get; set; }

    public string? CuTexto2 { get; set; }

    public decimal CuNumero { get; set; }

    public string MaCodigo { get; set; } = null!;

    public string CuClase { get; set; } = null!;

    public string CuRevisio { get; set; } = null!;

    public DateTime CuFecRev { get; set; }

    public string CuStps { get; set; } = null!;

    public string CuFolio { get; set; } = null!;

    public string CuDocum { get; set; } = null!;

    public int Llave { get; set; }

    public string AtCodigo { get; set; } = null!;

    public short CuObjetiv { get; set; }

    public short CuModalid { get; set; }

    public virtual ICollection<Accion> Accions { get; set; } = new List<Accion>();

    public virtual ICollection<Calcurso> Calcursos { get; set; } = new List<Calcurso>();

    public virtual ICollection<CurRev> CurRevs { get; set; } = new List<CurRev>();

    public virtual ICollection<Cursopre> Cursopres { get; set; } = new List<Cursopre>();

    public virtual ICollection<EmpProg> EmpProgs { get; set; } = new List<EmpProg>();

    public virtual ICollection<Entrena> Entrenas { get; set; } = new List<Entrena>();
}
