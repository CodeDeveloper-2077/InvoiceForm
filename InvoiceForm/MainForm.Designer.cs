namespace InvoiceForm
{
    partial class MainForm
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
            openInvoice = new Button();
            openInvoicePosition = new Button();
            SuspendLayout();
            // 
            // openInvoice
            // 
            openInvoice.Location = new Point(12, 12);
            openInvoice.Name = "openInvoice";
            openInvoice.Size = new Size(238, 65);
            openInvoice.TabIndex = 0;
            openInvoice.Text = "Open InvoiceForm";
            openInvoice.UseVisualStyleBackColor = true;
            openInvoice.Click += openInvoice_Click;
            // 
            // openInvoicePosition
            // 
            openInvoicePosition.Location = new Point(12, 83);
            openInvoicePosition.Name = "openInvoicePosition";
            openInvoicePosition.Size = new Size(238, 65);
            openInvoicePosition.TabIndex = 1;
            openInvoicePosition.Text = "Open InvoicePositionForm";
            openInvoicePosition.UseVisualStyleBackColor = true;
            openInvoicePosition.Click += openInvoicePosition_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 175);
            Controls.Add(openInvoicePosition);
            Controls.Add(openInvoice);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button openInvoice;
        private Button openInvoicePosition;
    }
}