using ProductServer.Models;
using ProductServer.Services;
namespace ProductServer
{
    public partial class ServerForm : Form
    {
        private List<Product> products = new List<Product>();
        private ExcelService excelService = new ExcelService();
        private ProductSearchService searchService = new ProductSearchService();
        private ServerService serverService = new ServerService();
        public ServerForm()
        {
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {

        }
        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Excel files (*.xlsx)|*.xlsx";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = dialog.FileName;
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFilePath.Text))
                {
                    MessageBox.Show("Спочатку оберіть Excel-файл.");
                    return;
                }

                products = excelService.LoadProducts(txtFilePath.Text);

                rtbLogs.AppendText($"Завантажено товарів: {products.Count}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні Excel: " + ex.Message);
            }
        }

        private void AddLog(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddLog), message);
                return;
            }

            rtbLogs.AppendText(message + Environment.NewLine);
        }
        private string HandleRequest(string request)
        {
            if (string.IsNullOrWhiteSpace(request))
            {
                return "Порожній запит";
            }

            string[] names = request.Split(',', StringSplitOptions.RemoveEmptyEntries);
            List<string> results = new List<string>();

            foreach (string item in names)
            {
                string productName = item.Trim();                                                   //Розділяє по комі, шукає кожен товар і формує відповідь по кожному
                var product = searchService.FindProduct(products, productName);

                if (product != null)
                {
                    decimal total = product.Price * product.Quantity;
                    results.Add($"{product.Name} | Ціна: {product.Price} | Кількість: {product.Quantity} | Сума: {total}");
                }
                else
                {
                    results.Add($"{productName} | не знайдено");
                }
            }

            return string.Join(Environment.NewLine, results);
        }

        private async void btnStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (products.Count == 0)
                {
                    MessageBox.Show("Спочатку завантажте товари з Excel.");
                    return;
                }

                if (!int.TryParse(txtPort.Text, out int port))
                {
                    MessageBox.Show("Введіть коректний порт.");
                    return;
                }

                await serverService.StartAsync(port, HandleRequest, AddLog);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка запуску сервера: " + ex.Message);
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            serverService.Stop(AddLog);
        }
    }

}
