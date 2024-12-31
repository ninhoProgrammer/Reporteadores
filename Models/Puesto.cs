using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Puesto
{
    public string PuCodigo { get; set; } = null!;

    public string PuDescrip { get; set; } = null!;

    public string PuIngles { get; set; } = null!;

    public string PuClasifi { get; set; } = null!;

    public decimal PuNumero { get; set; }

    public string PuTexto { get; set; } = null!;

    public string PuDetalle { get; set; } = null!;

    public string PuReporta { get; set; } = null!;

    public int PuPlazas { get; set; }

    public string PuNivel0 { get; set; } = null!;

    public string PuNivel1 { get; set; } = null!;

    public string PuNivel2 { get; set; } = null!;

    public string PuNivel3 { get; set; } = null!;

    public string PuNivel4 { get; set; } = null!;

    public string PuNivel5 { get; set; } = null!;

    public string PuNivel6 { get; set; } = null!;

    public string PuNivel7 { get; set; } = null!;

    public string PuNivel8 { get; set; } = null!;

    public string PuNivel9 { get; set; } = null!;

    public string PuTurno { get; set; } = null!;

    public string PuAutosal { get; set; } = null!;

    public string PuContrat { get; set; } = null!;

    public string PuTablass { get; set; } = null!;

    public string PuPatron { get; set; } = null!;

    public string PuArea { get; set; } = null!;

    public string PuZonaGe { get; set; } = null!;

    public string PuCheca { get; set; } = null!;

    public decimal PuSalario { get; set; }

    public decimal PuPerVar { get; set; }

    public short PuTipo { get; set; }

    public string PuActivo { get; set; } = null!;

    public decimal PuCosto1 { get; set; }

    public decimal PuCosto2 { get; set; }

    public decimal PuCosto3 { get; set; }

    public short PuLevel { get; set; }

    public decimal PuSalMin { get; set; }

    public decimal PuSalMax { get; set; }

    public decimal PuSalMed { get; set; }

    public decimal PuSalEn1 { get; set; }

    public decimal PuSalEn2 { get; set; }

    public string FpCodigo { get; set; } = null!;

    public string NpCodigo { get; set; } = null!;

    public string PuSubCta { get; set; } = null!;

    public int Llave { get; set; }

    public string PuClave { get; set; } = null!;

    public virtual ICollection<CompPto> CompPtos { get; set; } = new List<CompPto>();

    public virtual ICollection<Entrena> Entrenas { get; set; } = new List<Entrena>();

    public virtual Perfil? Perfil { get; set; }

    public virtual ICollection<Plaza> Plazas { get; set; } = new List<Plaza>();

    public virtual ICollection<PtoCert> PtoCerts { get; set; } = new List<PtoCert>();

    public virtual ICollection<PtoDime> PtoDimes { get; set; } = new List<PtoDime>();

    public virtual ICollection<Ptofija> Ptofijas { get; set; } = new List<Ptofija>();

    public virtual ICollection<Ptotool> Ptotools { get; set; } = new List<Ptotool>();

    public virtual ICollection<ValPto> ValPtos { get; set; } = new List<ValPto>();
}
