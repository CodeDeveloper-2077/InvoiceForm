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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(404, 199);
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
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 355);
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
    }
}