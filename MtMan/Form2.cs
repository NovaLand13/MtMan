using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;

namespace MtMan
{
    public partial class JobForm : Form
    {
        BindingSource jobBindingSource = new BindingSource();
        BindingSource clientBindingSource = new BindingSource();

        public JobForm()
        {
            InitializeComponent();

            ClientsDAO clientsDAO = new ClientsDAO();

            //connect the list and th egrid view
            clientBindingSource.DataSource = clientsDAO.getAllClients();
            dataGridView2.DataSource = clientBindingSource;
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.Columns["ID"].Visible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSize = true;
            dataGridView2.AllowUserToOrderColumns = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            //Add new client to database
            Client client = new Client
            {
                Name = nameTB.Text,
                Address = addressTB.Text,
                Phone_Number = PhoneTB.Text,
                Email = emailTB.Text
            };

            ClientsDAO clientsDAO = new ClientsDAO();
            int result = clientsDAO.addClient(client);
            MessageBox.Show(result + " new row(s) added");
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //fill in client update groupbox
                nameUpdateTB.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                addressUpdateTB.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                phoneUpdateTB.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                emailUpdateTB.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                clientIDupdateTB.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void updateClientBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clientIDupdateTB.Text))
            {
                MessageBox.Show("Please select a valid client to update.");
                return;
            }
            // Validate ID
            if (!int.TryParse(clientIDupdateTB.Text, out int clientId))
            {
                MessageBox.Show("Invalid Client ID. Please select a valid client.");
                return;
            }
            
            //Update client in database
            Client client = new Client
            {
                ID = clientId,
                Name = nameUpdateTB.Text,
                Address = addressUpdateTB.Text,
                Phone_Number = phoneUpdateTB.Text,
                Email = emailUpdateTB.Text
            };

            ClientsDAO clientsDAO = new ClientsDAO();
            int result = clientsDAO.updateClient(client);
            if (result > 0)
            {
                MessageBox.Show("Client updated successfully!");
                clientBindingSource.DataSource = clientsDAO.getAllClients();
                dataGridView2.DataSource = clientBindingSource;
            }
            else
            {
                MessageBox.Show("No changes were made. Please check the client details.");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
