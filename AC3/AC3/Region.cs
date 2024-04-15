using CsvHelper.Configuration.Attributes;

namespace AC3
{
    public class Region
    {
        public int Any { get; set; }

        [Name("Codi comarca")]
        public int CodiComarca { get; set; }
        public string Comarca { get; set; }

        [Name("Població")]
        public int Poblacio { get; set; }

        [Name("Domèstic xarxa")]
        public int DomesticXarxa { get; set; }

        [Name("Activitats econòmiques i fonts pròpies")]
        public int ActivitatsEconomiques { get; set; }
        public int Total { get; set; }

        [Name("Consum domèstic per càpita")]
        public double ConsumDomesticCapita { get; set; }
    }
}
