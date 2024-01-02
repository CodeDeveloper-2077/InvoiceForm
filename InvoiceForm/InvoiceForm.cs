using InvoiceForm.DAL;
using InvoiceForm.Data;
using InvoiceForm.Models;
using System.Windows.Forms;

namespace InvoiceForm
{
    public partial class InvoiceForm : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public InvoiceForm(UnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            dataGridView1.DataSource = _unitOfWork.InvoiceRepository.GetAll();
            dataGridView1.Columns["InvoicePosition"].Visible = false;
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
                Invoice? invoice = dataGridView1.Rows[e.RowIndex].DataBoundItem as Invoice;

                if (invoice is not null)
                {
                    idLabel.Text = invoice.InvoiceId.ToString();
                    numberTextbox.Text = invoice.Number;
                    valueTextbox.Text = invoice.Value.ToString();
                }
            }
        }

        private void RefreshControls()
        {
            idLabel.Text = "0";
            numberTextbox.Text = string.Empty;
            valueTextbox.Text = string.Empty;
        }
    }
}
