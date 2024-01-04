namespace InvoiceForm
{
    partial class InvoiceForm
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
            numberTextbox = new TextBox();
            valueTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            addButton = new Button();
            updateButton = new Button();
            removeButton = new Button();
            label3 = new Label();
            idLabel = new Label();
            invoicePositionIdLabel = new Label();
            label6 = new Label();
            removeInvoicePositionButton = new Button();
            updateInvoicePositionButton = new Button();
            addInvoicePositionButton = new Button();
            label7 = new Label();
            label8 = new Label();
            invoicePositionValueTextbox = new TextBox();
            nameTextbox = new TextBox();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(404, 328);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // numberTextbox
            // 
            numberTextbox.Location = new Point(72, 36);
            numberTextbox.Name = "numberTextbox";
            numberTextbox.Size = new Size(145, 23);
            numberTextbox.TabIndex = 1;
            // 
            // valueTextbox
            // 
            valueTextbox.Location = new Point(56, 65);
            valueTextbox.Name = "valueTextbox";
            valueTextbox.Size = new Size(161, 23);
            valueTextbox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "Value:";
            // 
            // addButton
            // 
            addButton.Location = new Point(271, 5);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 34);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(271, 45);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(112, 34);
            updateButton.TabIndex = 6;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(271, 85);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(112, 34);
            removeButton.TabIndex = 7;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 11);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 9;
            label3.Text = "Id:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(38, 11);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(13, 15);
            idLabel.TabIndex = 10;
            idLabel.Text = "0";
            // 
            // invoicePositionIdLabel
            // 
            invoicePositionIdLabel.AutoSize = true;
            invoicePositionIdLabel.Location = new Point(448, 11);
            invoicePositionIdLabel.Name = "invoicePositionIdLabel";
            invoicePositionIdLabel.Size = new Size(13, 15);
            invoicePositionIdLabel.TabIndex = 32;
            invoicePositionIdLabel.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(422, 11);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 31;
            label6.Text = "Id:";
            // 
            // removeInvoicePositionButton
            // 
            removeInvoicePositionButton.Location = new Point(762, 88);
            removeInvoicePositionButton.Name = "removeInvoicePositionButton";
            removeInvoicePositionButton.Size = new Size(112, 34);
            removeInvoicePositionButton.TabIndex = 30;
            removeInvoicePositionButton.Text = "Remove";
            removeInvoicePositionButton.UseVisualStyleBackColor = true;
            removeInvoicePositionButton.Click += removeInvoicePositionButton_Click;
            // 
            // updateInvoicePositionButton
            // 
            updateInvoicePositionButton.Location = new Point(762, 48);
            updateInvoicePositionButton.Name = "updateInvoicePositionButton";
            updateInvoicePositionButton.Size = new Size(112, 34);
            updateInvoicePositionButton.TabIndex = 29;
            updateInvoicePositionButton.Text = "Update";
            updateInvoicePositionButton.UseVisualStyleBackColor = true;
            updateInvoicePositionButton.Click += updateInvoicePositionButton_Click;
            // 
            // addInvoicePositionButton
            // 
            addInvoicePositionButton.Location = new Point(762, 8);
            addInvoicePositionButton.Name = "addInvoicePositionButton";
            addInvoicePositionButton.Size = new Size(112, 34);
            addInvoicePositionButton.TabIndex = 28;
            addInvoicePositionButton.Text = "Add";
            addInvoicePositionButton.UseVisualStyleBackColor = true;
            addInvoicePositionButton.Click += addInvoicePositionButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(422, 68);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 27;
            label7.Text = "Value:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(422, 40);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 26;
            label8.Text = "Name:";
            // 
            // invoicePositionValueTextbox
            // 
            invoicePositionValueTextbox.Location = new Point(466, 65);
            invoicePositionValueTextbox.Name = "invoicePositionValueTextbox";
            invoicePositionValueTextbox.Size = new Size(218, 23);
            invoicePositionValueTextbox.TabIndex = 25;
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(482, 36);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(202, 23);
            nameTextbox.TabIndex = 24;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(426, 136);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(468, 328);
            dataGridView2.TabIndex = 23;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 579);
            Controls.Add(invoicePositionIdLabel);
            Controls.Add(label6);
            Controls.Add(removeInvoicePositionButton);
            Controls.Add(updateInvoicePositionButton);
            Controls.Add(addInvoicePositionButton);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(invoicePositionValueTextbox);
            Controls.Add(nameTextbox);
            Controls.Add(dataGridView2);
            Controls.Add(idLabel);
            Controls.Add(label3);
            Controls.Add(removeButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(valueTextbox);
            Controls.Add(numberTextbox);
            Controls.Add(dataGridView1);
            Name = "InvoiceForm";
            Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox numberTextbox;
        private TextBox valueTextbox;
        private Label label1;
        private Label label2;
        private Button addButton;
        private Button updateButton;
        private Button removeButton;
        private Label label3;
        private Label idLabel;
        private Label invoicePositionIdLabel;
        private Label label6;
        private Button removeInvoicePositionButton;
        private Button updateInvoicePositionButton;
        private Button addInvoicePositionButton;
        private Label label7;
        private Label label8;
        private TextBox invoicePositionValueTextbox;
        private TextBox nameTextbox;
        private DataGridView dataGridView2;
    }
}