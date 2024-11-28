namespace MtMan
{
    partial class JobForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formBtn = new Button();
            groupBox1 = new GroupBox();
            addClientBtn = new Button();
            addressTB = new TextBox();
            emailTB = new TextBox();
            PhoneTB = new TextBox();
            nameTB = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // formBtn
            // 
            formBtn.Location = new Point(899, 576);
            formBtn.Name = "formBtn";
            formBtn.Size = new Size(116, 23);
            formBtn.TabIndex = 0;
            formBtn.Text = "Jobs Form";
            formBtn.UseVisualStyleBackColor = true;
            formBtn.Click += formBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addClientBtn);
            groupBox1.Controls.Add(addressTB);
            groupBox1.Controls.Add(emailTB);
            groupBox1.Controls.Add(PhoneTB);
            groupBox1.Controls.Add(nameTB);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 257);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Client";
            // 
            // addClientBtn
            // 
            addClientBtn.Location = new Point(204, 18);
            addClientBtn.Name = "addClientBtn";
            addClientBtn.Size = new Size(75, 23);
            addClientBtn.TabIndex = 8;
            addClientBtn.Text = "Add Client";
            addClientBtn.UseVisualStyleBackColor = true;
            addClientBtn.Click += addClientBtn_Click;
            // 
            // addressTB
            // 
            addressTB.Location = new Point(6, 105);
            addressTB.Name = "addressTB";
            addressTB.Size = new Size(163, 23);
            addressTB.TabIndex = 7;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(6, 221);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(163, 23);
            emailTB.TabIndex = 6;
            // 
            // PhoneTB
            // 
            PhoneTB.Location = new Point(6, 163);
            PhoneTB.Name = "PhoneTB";
            PhoneTB.Size = new Size(163, 23);
            PhoneTB.TabIndex = 5;
            // 
            // nameTB
            // 
            nameTB.Location = new Point(6, 47);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(163, 23);
            nameTB.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 196);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 138);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 80);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Client Name";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(389, 72);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(554, 211);
            dataGridView2.TabIndex = 8;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // JobForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1027, 611);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox1);
            Controls.Add(formBtn);
            Name = "JobForm";
            Text = "Client Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button formBtn;
        private GroupBox groupBox1;
        private Button addClientBtn;
        private TextBox addressTB;
        private TextBox emailTB;
        private TextBox PhoneTB;
        private TextBox nameTB;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView2;
    }
}