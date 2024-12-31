using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Medicina
{
    public string MeCodigo { get; set; } = null!;

    public string MeNombre { get; set; } = null!;

    public short MeTipo { get; set; }

    public string MeIngles { get; set; } = null!;

    public decimal MeNumero { get; set; }

    public string MeTexto { get; set; } = null!;

    public string MeMedida { get; set; } = null!;

    public string MeDescrip { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<MedEntr> MedEntrs { get; set; } = new List<MedEntr>();
}
