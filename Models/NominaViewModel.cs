namespace Reporteadores.Models
{
    public class NominaViewModel
    {
        public int PeYear { get; set; }
        public int PeTipo { get; set; }
        public int PeNumero { get; set; }
        public decimal Salario { get; set; }
        public string PeriodoInicio { get; set; }
        public string PeriodoFin { get; set; }
        public string AsistenciaInicio { get; set; }
        public string AsistenciaFin { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
        public decimal Percepcion { get; set; }
        public decimal Deduccion { get; set; }
        public decimal Neto { get; set; }
        public int Empleados { get; set; }
        public DateTime Fecha { get; set; }
    }
}
