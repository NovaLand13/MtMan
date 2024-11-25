
namespace MtMan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            searchBtn = new Button();
            searchTB = new TextBox();
            ClientBtn = new Button();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            JobFormBtn = new Button();
            jobGB = new GroupBox();
            addJobBTN = new Button();
            descriptionTB = new RichTextBox();
            serviceDateTB = new TextBox();
            datePdTB = new TextBox();
            dateBilledTB = new TextBox();
            paymentTB = new TextBox();
            amountTB = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            clientCB = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            jobGB.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(426, 303);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(647, 334);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(620, 16);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // searchTB
            // 
            searchTB.Location = new Point(701, 16);
            searchTB.Name = "searchTB";
            searchTB.Size = new Size(191, 23);
            searchTB.TabIndex = 3;
            searchTB.TextChanged += searchTB_TextChanged;
            // 
            // ClientBtn
            // 
            ClientBtn.Location = new Point(426, 16);
            ClientBtn.Name = "ClientBtn";
            ClientBtn.Size = new Size(75, 23);
            ClientBtn.TabIndex = 4;
            ClientBtn.Text = "Clients";
            ClientBtn.UseVisualStyleBackColor = true;
            ClientBtn.Click += ClientBtn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(620, 121);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(350, 174);
            dataGridView2.TabIndex = 5;
            dataGridView2.Visible = false;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 280);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 7;
            label5.Text = "Jobs";
            // 
            // JobFormBtn
            // 
            JobFormBtn.Location = new Point(12, 614);
            JobFormBtn.Name = "JobFormBtn";
            JobFormBtn.Size = new Size(136, 23);
            JobFormBtn.TabIndex = 8;
            JobFormBtn.Text = "Add New Client";
            JobFormBtn.UseVisualStyleBackColor = true;
            JobFormBtn.Click += JobFormBtn_Click;
            // 
            // jobGB
            // 
            jobGB.Controls.Add(addJobBTN);
            jobGB.Controls.Add(descriptionTB);
            jobGB.Controls.Add(serviceDateTB);
            jobGB.Controls.Add(datePdTB);
            jobGB.Controls.Add(dateBilledTB);
            jobGB.Controls.Add(paymentTB);
            jobGB.Controls.Add(amountTB);
            jobGB.Controls.Add(label7);
            jobGB.Controls.Add(label6);
            jobGB.Controls.Add(label4);
            jobGB.Controls.Add(label3);
            jobGB.Controls.Add(label2);
            jobGB.Controls.Add(label1);
            jobGB.Location = new Point(15, 14);
            jobGB.Name = "jobGB";
            jobGB.Size = new Size(309, 315);
            jobGB.TabIndex = 9;
            jobGB.TabStop = false;
            jobGB.Text = "Job Information";
            // 
            // addJobBTN
            // 
            addJobBTN.Location = new Point(18, 278);
            addJobBTN.Name = "addJobBTN";
            addJobBTN.Size = new Size(75, 23);
            addJobBTN.TabIndex = 12;
            addJobBTN.Text = "Add Job";
            addJobBTN.UseVisualStyleBackColor = true;
            addJobBTN.Click += addJobBTN_Click;
            // 
            // descriptionTB
            // 
            descriptionTB.Location = new Point(108, 217);
            descriptionTB.Name = "descriptionTB";
            descriptionTB.Size = new Size(174, 96);
            descriptionTB.TabIndex = 11;
            descriptionTB.Text = "";
            // 
            // serviceDateTB
            // 
            serviceDateTB.Location = new Point(108, 179);
            serviceDateTB.Name = "serviceDateTB";
            serviceDateTB.Size = new Size(174, 23);
            serviceDateTB.TabIndex = 10;
            // 
            // datePdTB
            // 
            datePdTB.Location = new Point(108, 141);
            datePdTB.Name = "datePdTB";
            datePdTB.Size = new Size(174, 23);
            datePdTB.TabIndex = 9;
            // 
            // dateBilledTB
            // 
            dateBilledTB.Location = new Point(108, 103);
            dateBilledTB.Name = "dateBilledTB";
            dateBilledTB.Size = new Size(174, 23);
            dateBilledTB.TabIndex = 8;
            // 
            // paymentTB
            // 
            paymentTB.Location = new Point(108, 65);
            paymentTB.Name = "paymentTB";
            paymentTB.Size = new Size(174, 23);
            paymentTB.TabIndex = 7;
            // 
            // amountTB
            // 
            amountTB.Location = new Point(108, 27);
            amountTB.Name = "amountTB";
            amountTB.Size = new Size(174, 23);
            amountTB.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 221);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 5;
            label7.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 183);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 4;
            label6.Text = "Service Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 145);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Date Paid";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 107);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Date Billed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 69);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Payment Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 31);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Amount";
            // 
            // clientCB
            // 
            clientCB.FormattingEnabled = true;
            clientCB.Location = new Point(428, 54);
            clientCB.Name = "clientCB";
            clientCB.Size = new Size(179, 23);
            clientCB.TabIndex = 10;
            clientCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 649);
            Controls.Add(clientCB);
            Controls.Add(jobGB);
            Controls.Add(JobFormBtn);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(ClientBtn);
            Controls.Add(searchTB);
            Controls.Add(searchBtn);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            jobGB.ResumeLayout(false);
            jobGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button searchBtn;
        private TextBox searchTB;
        private Button ClientBtn;
        private DataGridView dataGridView2;
        private Label label5;
        private Button JobFormBtn;
        private GroupBox jobGB;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private RichTextBox descriptionTB;
        private TextBox serviceDateTB;
        private TextBox datePdTB;
        private TextBox dateBilledTB;
        private TextBox paymentTB;
        private TextBox amountTB;
        private Button addJobBTN;
        private ComboBox clientCB;
    }
}
