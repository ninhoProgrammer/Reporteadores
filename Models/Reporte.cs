using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Reporte
{
    public short ReCodigo { get; set; }

    public string ReNombre { get; set; } = null!;

    public short ReTipo { get; set; }

    public string ReTitulo { get; set; } = null!;

    public short ReEntidad { get; set; }

    public string ReSolot { get; set; } = null!;

    public DateTime ReFecha { get; set; }

    public string ReGeneral { get; set; } = null!;

    public string ReReporte { get; set; } = null!;

    public string ReCfecha { get; set; } = null!;

    public short ReIfecha { get; set; }

    public short ReHoja { get; set; }

    public decimal ReAlto { get; set; }

    public decimal ReAncho { get; set; }

    public string RePrinter { get; set; } = null!;

    public short ReCopias { get; set; }

    public short RePfile { get; set; }

    public string ReArchivo { get; set; } = null!;

    public string ReVertica { get; set; } = null!;

    public short UsCodigo { get; set; }

    public string ReFiltro { get; set; } = null!;

    public short ReColnum { get; set; }

    public decimal ReColespa { get; set; }

    public decimal ReRenespa { get; set; }

    public decimal ReMarSup { get; set; }

    public decimal ReMarIzq { get; set; }

    public decimal ReMarDer { get; set; }

    public decimal ReMarInf { get; set; }

    public short ReNivel { get; set; }

    public string ReFontnam { get; set; } = null!;

    public short ReFontsiz { get; set; }

    public string QuCodigo { get; set; } = null!;

    public short ReClasifi { get; set; }

    public short ReCandado { get; set; }

    public int Llave { get; set; }

    public virtual ICollection<Camporep> Camporeps { get; set; } = new List<Camporep>();

    public virtual ICollection<Misrepor> Misrepors { get; set; } = new List<Misrepor>();

    public virtual RClasifi ReClasifiNavigation { get; set; } = null!;

    public virtual ICollection<Suscrip> Suscrips { get; set; } = new List<Suscrip>();
}
