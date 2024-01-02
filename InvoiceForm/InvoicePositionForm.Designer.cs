namespace InvoiceForm
{
    partial class InvoicePositionForm
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
            idLabel = new Label();
            label3 = new Label();
            removeButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            label2 = new Label();
            label1 = new Label();
            valueTextbox = new TextBox();
            nameTextbox = new TextBox();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            invoiceIdTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(34, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(13, 15);
            idLabel.TabIndex = 20;
            idLabel.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 15);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 19;
            label3.Text = "Id:";
            // 
            // removeButton
            // 
            removeButton.Location = new Point(348, 92);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(112, 34);
            removeButton.TabIndex = 18;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(348, 52);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(112, 34);
            updateButton.TabIndex = 17;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(348, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 34);
            addButton.TabIndex = 16;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 72);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 15;
            label2.Text = "Value:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 44);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 14;
            label1.Text = "Name:";
            // 
            // valueTextbox
            // 
            valueTextbox.Location = new Point(52, 69);
            valueTextbox.Name = "valueTextbox";
            valueTextbox.Size = new Size(218, 23);
            valueTextbox.TabIndex = 13;
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(68, 40);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(202, 23);
            nameTextbox.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(468, 199);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 103);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 22;
            label4.Text = "InvoiceId:";
            // 
            // invoiceIdTextbox
            // 
            invoiceIdTextbox.Location = new Point(72, 98);
            invoiceIdTextbox.Name = "invoiceIdTextbox";
            invoiceIdTextbox.Size = new Size(198, 23);
            invoiceIdTextbox.TabIndex = 21;
            // 
            // InvoicePositionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 410);
            Controls.Add(label4);
            Controls.Add(invoiceIdTextbox);
            Controls.Add(idLabel);
            Controls.Add(label3);
            Controls.Add(removeButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(valueTextbox);
            Controls.Add(nameTextbox);
            Controls.Add(dataGridView1);
            Name = "InvoicePositionForm";
            Text = "InvoicePositionForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private Label label3;
        private Button removeButton;
        private Button updateButton;
        private Button addButton;
        private Label label2;
        private Label label1;
        private TextBox valueTextbox;
        private TextBox nameTextbox;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox invoiceIdTextbox;
    }
}