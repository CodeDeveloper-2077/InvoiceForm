using InvoiceForm.DAL;
using InvoiceForm.Data;
using InvoiceForm.Models;
using System.Windows.Forms;

namespace InvoiceForm
{
    public partial class InvoiceForm : Form
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly BindingSource _bindingSource;
        private Invoice? _invoice;

        public InvoiceForm(UnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _bindingSource = new BindingSource();

            dataGridView1.DataSource = _unitOfWork.InvoiceRepository.GetAll();
            dataGridView1.Columns["InvoicePositions"].Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numberTextbox.Text))
            {
                MessageBox.Show("Number cannot be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var invoice = new Invoice()
            {
                Number = numberTextbox.Text,
                Value = decimal.Parse(valueTextbox.Text)
            };

            _unitOfWork.InvoiceRepository.Add(invoice);
            _unitOfWork.Save();
            dataGridView1.DataSource = _unitOfWork.InvoiceRepository.GetAll();

            RefreshControls();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numberTextbox.Text))
            {
                MessageBox.Show("Number cannot be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var invoice = _unitOfWork.InvoiceRepository.GetById(int.Parse(idLabel.Text));
            invoice.Number = numberTextbox.Text;
            invoice.Value = decimal.Parse(valueTextbox.Text);

            _unitOfWork.InvoiceRepository.Update(invoice);
            _unitOfWork.Save();
            dataGridView1.DataSource = _unitOfWork.InvoiceRepository.GetAll();

            RefreshControls();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (idLabel.Text == "0")
            {
                MessageBox.Show("Choose an entry to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _unitOfWork.InvoiceRepository.Delete(decimal.Parse(idLabel.Text));
            _unitOfWork.Save();
            dataGridView1.DataSource = _unitOfWork.InvoiceRepository.GetAll();

            RefreshControls();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                _invoice = dataGridView1.Rows[e.RowIndex].DataBoundItem as Invoice;

                if (_invoice is not null)
                {
                    idLabel.Text = _invoice.InvoiceId.ToString();
                    numberTextbox.Text = _invoice.Number;
                    valueTextbox.Text = _invoice.Value.ToString();
                    dataGridView2.DataSource = _invoice.InvoicePositions;
                    dataGridView2.Columns["Invoice"].Visible = false;
                }
            }
        }

        private void RefreshControls()
        {
            idLabel.Text = "0";
            numberTextbox.Text = string.Empty;
            valueTextbox.Text = string.Empty;
        }

        private void addInvoicePositionButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextbox.Text) || string.IsNullOrEmpty(invoicePositionValueTextbox.Text))
            {
                MessageBox.Show("Check all your inputs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var invoicePosition = new InvoicePosition()
            {
                Name = nameTextbox.Text,
                Value = decimal.Parse(invoicePositionValueTextbox.Text),
                InvoiceId = _invoice.InvoiceId
            };

            _unitOfWork.InvoicePositionRepository.Add(invoicePosition);
            _unitOfWork.Save();

            RefreshInvoicePositionControls();
        }

        private void updateInvoicePositionButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextbox.Text) || string.IsNullOrEmpty(invoicePositionValueTextbox.Text))
            {
                MessageBox.Show("Check all your inputs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var invoice = _unitOfWork.InvoicePositionRepository.GetById(int.Parse(invoicePositionIdLabel.Text));
            invoice.Name = nameTextbox.Text;
            invoice.Value = decimal.Parse(invoicePositionValueTextbox.Text);
            invoice.InvoiceId = _invoice.InvoiceId;

            _unitOfWork.InvoicePositionRepository.Update(invoice);
            _unitOfWork.Save();

            RefreshInvoicePositionControls();
        }

        private void removeInvoicePositionButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextbox.Text) || string.IsNullOrEmpty(invoicePositionValueTextbox.Text))
            {
                MessageBox.Show("Choose an entry to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _unitOfWork.InvoicePositionRepository.Delete(decimal.Parse(invoicePositionIdLabel.Text));
            _unitOfWork.Save();

            RefreshInvoicePositionControls();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                InvoicePosition? invoicePosition = dataGridView2.Rows[e.RowIndex].DataBoundItem as InvoicePosition;

                if (invoicePosition is not null)
                {
                    invoicePositionIdLabel.Text = invoicePosition.InvoicePositionId.ToString();
                    nameTextbox.Text = invoicePosition.Name;
                    invoicePositionValueTextbox.Text = invoicePosition.Value.ToString();
                }
            }
        }

        private void RefreshInvoicePositionControls()
        {
            invoicePositionIdLabel.Text = "0";
            nameTextbox.Text = string.Empty;
            invoicePositionValueTextbox.Text = string.Empty;

            _bindingSource.DataSource = _invoice.InvoicePositions;
            dataGridView2.DataSource = _bindingSource;
            _bindingSource.ResetBindings(false);
        }
    }
}
