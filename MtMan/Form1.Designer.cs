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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            dataGridView2.Location = new Point(426, 45);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(554, 211);
            dataGridView2.TabIndex = 5;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 649);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button searchBtn;
        private TextBox searchTB;
        private Button ClientBtn;
        private DataGridView dataGridView2;
        private Label label5;
        private Button JobFormBtn;
    }
}
