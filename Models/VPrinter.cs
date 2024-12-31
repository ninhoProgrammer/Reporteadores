using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VPrinter
{
    public string PiNombre { get; set; } = null!;

    public string PiEject { get; set; } = null!;

    public string PiChar10 { get; set; } = null!;

    public string PiChar12 { get; set; } = null!;

    public string PiChar17 { get; set; } = null!;

    public string PiExtra1 { get; set; } = null!;

    public string PiExtra2 { get; set; } = null!;

    public string PiReset { get; set; } = null!;

    public string PiUndeOn { get; set; } = null!;

    public string PiUndeOf { get; set; } = null!;

    public string PiBoldOn { get; set; } = null!;

    public string PiBoldOf { get; set; } = null!;

    public string Pi6Lines { get; set; } = null!;

    public string Pi8Lines { get; set; } = null!;

    public string PiItalOn { get; set; } = null!;

    public string PiItalOf { get; set; } = null!;

    public string PiLandsca { get; set; } = null!;
}
