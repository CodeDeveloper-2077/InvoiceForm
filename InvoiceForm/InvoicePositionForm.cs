using InvoiceForm.DAL;
using InvoiceForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceForm
{
    public partial class InvoicePositionForm : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public InvoicePositionForm(UnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            dataGridView1.DataSource = _unitOfWork.InvoicePositionRepository.GetAll();
            dataGridView1.Columns["Invoice"].Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextbox.Text) || string.IsNullOrEmpty(invoiceIdTextbox.Text))
            {
                MessageBox.Show("Check all your inputs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var invoicePosition = new InvoicePosition()
            {
                Name = nameTextbox.Text,
                Value = decimal.Parse(valueTextbox.Text),
                InvoiceId = decimal.Parse(invoiceIdTextbox.Text)
            };

            _unitOfWork.InvoicePositionRepository.Add(invoicePosition);
            _unitOfWork.Save();
            dataGridView1.DataSource = _unitOfWork.InvoicePositionRepository.GetAll();

            RefreshControls();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextbox.Text) || string.IsNullOrEmpty(invoiceIdTextbox.Text))
            {
                MessageBox.Show("Check all your inputs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var invoice = _unitOfWork.InvoicePositionRepository.GetById(int.Parse(idLabel.Text));
            invoice.Name = nameTextbox.Text;
            invoice.Value = decimal.Parse(valueTextbox.Text);
            invoice.InvoiceId = decimal.Parse(invoiceIdTextbox.Text);

            _unitOfWork.InvoicePositionRepository.Update(invoice);
            _unitOfWork.Save();
            dataGridView1.DataSource = _unitOfWork.InvoicePositionRepository.GetAll();

            RefreshControls();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextbox.Text) || string.IsNullOrEmpty(invoiceIdTextbox.Text))
            {
                MessageBox.Show("Choose an entry to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _unitOfWork.InvoicePositionRepository.Delete(decimal.Parse(idLabel.Text));
            _unitOfWork.Save();
            dataGridView1.DataSource = _unitOfWork.InvoicePositionRepository.GetAll();

            RefreshControls();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                InvoicePosition? invoicePosition = dataGridView1.Rows[e.RowIndex].DataBoundItem as InvoicePosition;

                if (invoicePosition is not null)
                {
                    idLabel.Text = invoicePosition.InvoicePositionId.ToString();
                    nameTextbox.Text = invoicePosition.Name;
                    valueTextbox.Text = invoicePosition.Value.ToString();
                    invoiceIdTextbox.Text = invoicePosition.InvoiceId.ToString();
                }
            }
        }

        private void RefreshControls()
        {
            idLabel.Text = "0";
            nameTextbox.Text = string.Empty;
            valueTextbox.Text = string.Empty;
            invoiceIdTextbox.Text = string.Empty;
        }
    }
}
