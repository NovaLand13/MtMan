using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MtMan
{
    public partial class JobForm : Form
    {
        BindingSource jobBindingSource = new BindingSource();
        BindingSource clientBindingSource = new BindingSource();

        public JobForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
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

        private void ClientBtn_Click(object sender, EventArgs e)
        {
            ClientsDAO clientsDAO = new ClientsDAO();

            //connect the list and th egrid view
            clientBindingSource.DataSource = clientsDAO.getAllClients();
            dataGridView2.DataSource = clientBindingSource;
        }
    }
}
