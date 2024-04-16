using CsvHelper;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Xml;
using System.Xml.Linq;
using CsvHelper.Configuration.Attributes;
using System.Windows.Forms;

namespace AC3
{
    public partial class Form1 : Form
    {
        const string csvPath = @".\..\..\..\Files\consumo_agua.csv";
        const string xmlPath = @".\..\..\..\Files\consumo_agua.xml";

        const int YearLimit = 2050, PoblationLimit = 20000;

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
            InsertComarca(csvPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Region> regions = ConvertCsvToList(csvPath);
            ConvertCsvToXml(xmlPath, csvPath);
            LoadDataGrid(regions);
            LoadYears(regions);
            LoadComarcas();
        }

        private void LoadDataGrid(List<Region> regions)
        {
            dataGrid.Rows.Clear();

            foreach (Region region in regions)
            {
                DataGridViewRow row = (DataGridViewRow)dataGrid.Rows[0].Clone();
                row.Cells[0].Value = region.Any;
                row.Cells[1].Value = region.CodiComarca;
                row.Cells[2].Value = region.NomComarca;
                row.Cells[3].Value = region.Poblacio;
                row.Cells[4].Value = region.DomesticXarxa;
                row.Cells[5].Value = region.ActivitatsEconomiques;
                row.Cells[6].Value = region.Total;
                row.Cells[7].Value = region.ConsumDomesticCapita;
                dataGrid.Rows.Add(row);
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
            List<Region> regions = ConvertCsvToList(csvPath);

            var xmlDoc = new XmlDocument();
            var root = xmlDoc.CreateElement("Comarcas");

            foreach (var region in regions)
            {
                var comarcaElement = xmlDoc.CreateElement("Comarca");

                var properties = typeof(Region).GetProperties();

                foreach (var prop in properties)
                {
                    var element = xmlDoc.CreateElement(prop.Name);

                    var value = prop.GetValue(region)?.ToString() ?? "";
                    element.InnerText = value;

                    comarcaElement.AppendChild(element);
                }

                root.AppendChild(comarcaElement);
            }

            xmlDoc.AppendChild(root);

            xmlDoc.Save(savePath);
        }

        private void LoadYears(List<Region> regions)
        {
            anySelector.Items.Clear();

            for (int i = regions.Min(r => r.Any); i <= YearLimit; i++)
            {
                anySelector.Items.Add(i);
            }
        }

        private List<string> ComarcaNames(string path)
        {
            List<string> names = new List<string>();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);

            XmlNodeList xmlNodeList = xmlDocument.SelectNodes("//NomComarca");

            foreach (XmlElement xmlN in xmlNodeList)
            {
                names.Add(xmlN.InnerText);
            }

            return names.Distinct().ToList();
        }

        private void LoadComarcas()
        {
            comarcaSelector.Items.Clear();

            List<string> comarcaNames = ComarcaNames(xmlPath);

            foreach (string name in comarcaNames)
            {
                comarcaSelector.Items.Add(name);
            }
        }

        private void InsertComarca(string csvPath)
        {
            string nomComarca;
            int anyComarca, codiComarca, poblacio, domesticXarxa, actEconomiques, total;
            double consumDomestic;

            try
            {
                nomComarca = comarcaSelector.Text;
                if (nomComarca == string.Empty)
                {
                    throw new Exception("Debe elegir una comarca");
                }
                error.SetError(comarcaSelector, null);
            }
            catch (Exception ex)
            {
                error.SetError(comarcaSelector, ex.Message);
                return;
            }

            try
            {
                if (anySelector.Text == string.Empty)
                {
                    throw new Exception("Debe elegir un año");
                }
                anyComarca = Convert.ToInt32(anySelector.Text);
                
                error.SetError(anySelector, null);
            }
            catch (Exception ex)
            {
                error.SetError(anySelector, ex.Message);
                return;
            }

            using (StreamReader reader = new StreamReader(csvPath))
            {
                using (CsvReader csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csvReader.GetRecords<Region>().ToList();

                    var record = records.FirstOrDefault(r => r.NomComarca == nomComarca);

                    if (record != null) codiComarca = record.CodiComarca;
                    else return;
                }
            }

            try
            {
                poblacio = Convert.ToInt32(poblacioSelector.Text);
                error.SetError(poblacioSelector, null);
            }
            catch (Exception ex)
            {
                error.SetError(poblacioSelector, ex.Message);
                return;
            }
            try
            {
                domesticXarxa = Convert.ToInt32(domesticXarxaSelector.Text);
                error.SetError(domesticXarxaSelector, null);
            }
            catch (Exception ex)
            {
                error.SetError(domesticXarxaSelector, ex.Message);
                return;
            }
            try
            {
                actEconomiques = Convert.ToInt32(actEconomiquesSelector.Text);
                error.SetError(actEconomiquesSelector, null);
            }
            catch (Exception ex)
            {
                error.SetError(actEconomiquesSelector, ex.Message);
                return;
            }
            try
            {
                total = Convert.ToInt32(totalSelector.Text);
                error.SetError(totalSelector, null);
            }
            catch (Exception ex)
            {
                error.SetError(totalSelector, ex.Message);
                return;
            }
            try
            {
                consumDomestic = Convert.ToDouble(consumDomesticSelector.Text);
                error.SetError(consumDomesticSelector, null);
            }
            catch (Exception ex)
            {
                error.SetError(consumDomesticSelector, ex.Message);
                return;
            }

            Region comarca = new Region()
            {
                Any = anyComarca,
                CodiComarca = codiComarca,
                NomComarca = nomComarca,
                Poblacio = poblacio,
                DomesticXarxa = domesticXarxa,
                ActivitatsEconomiques = actEconomiques,
                Total = total,
                ConsumDomesticCapita = consumDomestic
            };

            using (StreamWriter writer = new StreamWriter(csvPath, append: true))
            {
                using (CsvWriter csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecord(comarca);
                    writer.WriteLine();
                    DataGridViewRow row = (DataGridViewRow)dataGrid.Rows[0].Clone();
                    row.Cells[0].Value = comarca.Any;
                    row.Cells[1].Value = comarca.CodiComarca;
                    row.Cells[2].Value = comarca.NomComarca;
                    row.Cells[3].Value = comarca.Poblacio;
                    row.Cells[4].Value = comarca.DomesticXarxa;
                    row.Cells[5].Value = comarca.ActivitatsEconomiques;
                    row.Cells[6].Value = comarca.Total;
                    row.Cells[7].Value = comarca.ConsumDomesticCapita;
                    dataGrid.Rows.Add(row);
                }
            }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid.SelectedRows[0];

                List<Region> regions = ConvertCsvToList(csvPath);

                poblacioMayor20000.Text = Convert.ToInt32(selectedRow.Cells["Poblacio"].Value.ToString()) > PoblationLimit ? "Sí" : "No";
                domesticMedio.Text = Convert.ToString(Convert.ToInt32(selectedRow.Cells["DomesticXarxa"].Value.ToString()) / Convert.ToInt32(selectedRow.Cells["Poblacio"].Value.ToString()));
                double consumDomestic = Convert.ToDouble(selectedRow.Cells["ConsumDomestic"].Value.ToString());
                domesticMesAlt.Text = consumDomestic >= regions.Max(r => r.ConsumDomesticCapita) ? "Sí" : "No";
                domesticMexBaix.Text = consumDomestic <= regions.Min(r => r.ConsumDomesticCapita) ? "Sí" : "No";
            }
        }
    }
}
