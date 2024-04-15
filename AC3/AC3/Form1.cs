using CsvHelper;
using System.Diagnostics;
using System.Globalization;
using System.Xml;

namespace AC3
{
    public partial class Form1 : Form
    {
        const string csvPath = @".\..\..\..\Files\consumo_agua.csv";
        const string xmlPath = @".\..\..\..\Files\consumo_agua.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anySelector.Text = string.Empty;
            comarcaSelector.Text = string.Empty;
            poblacioSelector.Text = "0";
            domesticXarxaSelector.Text = string.Empty;
            actEconomiquesSelector.Text = string.Empty;
            consumDomesticSelector.Text = string.Empty;
            totalSelector.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Region> regions = ConvertCsvToList(csvPath);
            foreach(Region region in regions)
            {
                DataGridViewRow row = (DataGridViewRow)dataGrid.Rows[0].Clone();
                row.Cells[0].Value = region.Any;
                row.Cells[1].Value = region.CodiComarca;
                row.Cells[2].Value = region.Comarca;
                row.Cells[3].Value = region.Poblacio;
                row.Cells[4].Value = region.DomesticXarxa;
                row.Cells[5].Value = region.ActivitatsEconomiques;
                row.Cells[6].Value = region.Total;
                row.Cells[7].Value = region.ConsumDomesticCapita;
                dataGrid.Rows.Add(row);
            }

            anySelector.Items.Clear();

            for (int i = 2050; i >= regions.Min(r => r.Any); i--)
            {
                anySelector.Items.Add(i);
            }
        }

        private List<Region> ConvertCsvToList(string path)
        {
            using (var reader = new StreamReader(path))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var regions = csv.GetRecords<Region>().ToList();
                    return regions;
                }
            }
        }

        private void ConvertCsvToXml(string savePath, string csvPath)
        {
            using (StreamReader reader = new StreamReader(savePath))
            {
                
            }
        }
    }
}
