using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VUsuario
{
    public short UsCodigo { get; set; }

    public string UsCorto { get; set; } = null!;

    public short GrCodigo { get; set; }

    public short UsNivel { get; set; }

    public string UsNombre { get; set; } = null!;

    public string UsBloquea { get; set; } = null!;

    public string UsCambia { get; set; } = null!;

    public DateTime UsFecIn { get; set; }

    public DateTime UsFecOut { get; set; }

    public string UsDentro { get; set; } = null!;

    public string UsArbol { get; set; } = null!;

    public short UsForma { get; set; }

    public string UsBitLst { get; set; } = null!;

    public string UsBioId { get; set; } = null!;

    public DateTime UsFecSus { get; set; }

    public short UsFallas { get; set; }

    public string UsMaquina { get; set; } = null!;

    public DateTime UsFecPwd { get; set; }

    public string UsEmail { get; set; } = null!;

    public short UsFormato { get; set; }

    public string UsLugar { get; set; } = null!;

    public short UsPaginas { get; set; }

    public string CmCodigo { get; set; } = null!;

    public int CbCodigo { get; set; }

    public int UsAnfitri { get; set; }

    public string? UsPortal { get; set; }

    public string? UsActivo { get; set; }

    public string? UsDomain { get; set; }

    public short? UsJefe { get; set; }
}
