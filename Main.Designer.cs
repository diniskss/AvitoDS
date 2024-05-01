namespace WinFormsApp1
{
    partial class Main
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
            dataGridView1 = new DataGridView();
            Adv_Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Image = new DataGridViewTextBoxColumn();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            db_check = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Adv_Name, Price, Type, Image });
            dataGridView1.Location = new Point(172, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(445, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Adv_Name
            // 
            Adv_Name.Frozen = true;
            Adv_Name.HeaderText = "Имя";
            Adv_Name.Name = "Adv_Name";
            Adv_Name.ReadOnly = true;
            // 
            // Price
            // 
            Price.Frozen = true;
            Price.HeaderText = "Цена";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Type
            // 
            Type.Frozen = true;
            Type.HeaderText = "Тип";
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // Image
            // 
            Image.Frozen = true;
            Image.HeaderText = "Изображение";
            Image.Name = "Image";
            Image.ReadOnly = true;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // db_check
            // 
            db_check.AutoSize = true;
            db_check.Location = new Point(226, 273);
            db_check.Name = "db_check";
            db_check.Size = new Size(38, 15);
            db_check.TabIndex = 1;
            db_check.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(386, 276);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Подключиться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(db_check);
            Controls.Add(dataGridView1);
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Adv_Name;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Image;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private Label db_check;
        private Button button1;
    }
}