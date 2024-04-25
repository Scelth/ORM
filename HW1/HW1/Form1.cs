using Microsoft.Data.SqlClient;
using System.Data;

namespace HW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new("Data Source=localhost;Database=Academy;Trusted_Connection=True;TrustServerCertificate=True;");
            conn.Open();

            var query = "SELECT * FROM Teacher";

            var adapter = new SqlDataAdapter(query, conn);
            var data = new DataSet();
            adapter.Fill(data);

            dataGridView.DataSource = data.Tables[0];
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new("Data Source=localhost;Database=Academy;Trusted_Connection=True;TrustServerCertificate=True;");
            conn.Open();

            var query = "SELECT MAX(Salary) FROM Teacher";

            var adapter = new SqlDataAdapter(query, conn);
            var data = new DataSet();
            adapter.Fill(data);

            dataGridView.DataSource = data.Tables[0];
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new("Data Source=localhost;Database=Academy;Trusted_Connection=True;TrustServerCertificate=True;");
            conn.Open();

            var query = "SELECT MIN(Salary) FROM Teacher";

            var adapter = new SqlDataAdapter(query, conn);
            var data = new DataSet();
            adapter.Fill(data);

            dataGridView.DataSource = data.Tables[0];
        }

        private void youtButton_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new("Data Source=localhost;Database=Academy;Trusted_Connection=True;TrustServerCertificate=True;");
            conn.Open();

            var query = yourTextBox.Text;

            var adapter = new SqlDataAdapter(query, conn);
            var data = new DataSet();
            adapter.Fill(data);

            dataGridView.DataSource = data.Tables[0];
        }
    }
}