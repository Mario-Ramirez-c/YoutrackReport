using YoutrackReport.Pages;

namespace YoutrackReport.DTOs
{
    public class MetricasKPI
    {
        public int CantidadEnCurso { get; set; }
        public int CantidadTerminado { get; set; }

        public List<KPI_Lista_JP> kPI_Lista_JPs { get; set; }
    }

    public class KPI_Lista_JP 
    {
        public string NomJP { get; set; }
        public int CantidadTerminadoJP { get; set; }
        public int CantidadDesarrolloJP { get; set; }
        public int CantidadDetenidoJP { get; set; }
        public int CantidadPorIniciarJP { get; set; }
    }

}
