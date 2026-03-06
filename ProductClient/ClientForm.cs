using ProductClient.Services;
namespace ProductClient
{

    public partial class ClientForm : Form
    {
        private ClientService clientService = new ClientService();
        public ClientForm()
        {
            InitializeComponent();
        }
        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnSendRequest_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtServerAddress.Text))
                {
                    MessageBox.Show("Введіть адресу сервера.");
                    return;
                }

                if (!int.TryParse(txtPort.Text, out int port))
                {
                    MessageBox.Show("Введіть коректний порт.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtProducts.Text))
                {
                    MessageBox.Show("Введіть найменування товарів.");
                    return;
                }

                string request = txtProducts.Text
                    .Replace(Environment.NewLine, ",")
                    .Trim();

                string response = await clientService.SendRequestAsync(
                    txtServerAddress.Text.Trim(),
                    port,
                    request);

                rtbResult.Text = response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка підключення або запиту: " + ex.Message);
            }
        }
    }
}
