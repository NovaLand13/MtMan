namespace MtMan
{
    public partial class Form1 : Form
    {
        BindingSource jobBindingSource = new BindingSource();
        BindingSource clientBindingSource = new BindingSource();

        List<Client> clients = new List<Client>();

        public Form1()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            ClientsDAO clientsDAO = new ClientsDAO();

            //connect the list and th egrid view
            clientBindingSource.DataSource = clientsDAO.searchClients(searchTB.Text);
            dataGridView2.DataSource = clientBindingSource;
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           // DataGridView dataGridView = (DataGridView)sender;
/*
            //get the row number clicked
            int rowClicked = clientCB.SelectedIndex;//dataGridView.CurrentRow.Index;

            //connect the list and th egrid view
            jobBindingSource.DataSource = clients[rowClicked].Job;
            dataGridView1.DataSource = jobBindingSource;
            */
        }

        private void ClientBtn_Click(object sender, EventArgs e)
        {
            ClientsDAO clientsDAO = new ClientsDAO();

            //connect the list and th egrid view
            clients = clientsDAO.getAllClients();
            clientBindingSource.DataSource = clients;
            clientCB.DataSource = clientBindingSource;
            clientCB.DisplayMember = "Name";
            clientCB.ValueMember = "ID";
            dataGridView2.DataSource = clientBindingSource;
        }

        private void groupBox1_Enter(object sender, EventArgs e) 
        {
        }


        private void addClientBtn_Click(object sender, EventArgs e) 
        { 
        }

        private void JobFormBtn_Click(object sender, EventArgs e)
        {
            JobForm form = new JobForm();
            form.Show();
        }

        private void addJobBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate and parse input
                int amount = int.Parse(amountTB.Text);
                string paymentType = paymentTB.Text;
                DateTime dateBilled = DateTime.Parse(dateBilledTB.Text);
                DateTime datePaid = DateTime.Parse(datePdTB.Text);
                DateTime serviceDate = DateTime.Parse(serviceDateTB.Text);
                string description = descriptionTB.Text;
                int client_ID = 5;

                // Create a new Job object
                Job job = new Job
                {
                    Amount = amount,
                    PaymentType = paymentType,
                    DateBilled = dateBilled,
                    DatePaid = datePaid,
                    ServiceDate = serviceDate,
                    Description = description,
                    client_ID = client_ID
                };

                JobsDAO jobsDAO = new JobsDAO();
                int result = jobsDAO.addJob(job);

                MessageBox.Show("Job added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid input: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // DataGridView dataGridView = (DataGridView)sender;

            //get the row number clicked
            int rowClicked = clientCB.SelectedIndex;//dataGridView.CurrentRow.Index;

            //connect the list and th egrid view
            jobBindingSource.DataSource = clients[rowClicked].Job;
            dataGridView1.DataSource = jobBindingSource;
        }
    }
}
