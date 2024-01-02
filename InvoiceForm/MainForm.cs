using InvoiceForm.DAL;
using InvoiceForm.Data;

namespace InvoiceForm
{
    public partial class MainForm : Form
    {
        private readonly InvoiceForm _invoiceForm;
        private readonly InvoicePositionForm _invoicePositionForm;

        public MainForm()
        {
            InitializeComponent();
            var unitOfWork = this.UnitOfWorkFactory();
            _invoiceForm = new InvoiceForm(unitOfWork);
            _invoicePositionForm = new InvoicePositionForm(unitOfWork);
        }

        private void openInvoice_Click(object sender, EventArgs e)
        {
            _invoiceForm.ShowDialog(this);
        }

        private void openInvoicePosition_Click(object sender, EventArgs e)
        {
            _invoicePositionForm.ShowDialog(this);
        }

        private UnitOfWork UnitOfWorkFactory()
        {
            return new UnitOfWork(this.ContextFactory());
        }

        private InvoiceDb ContextFactory()
        {
            return new InvoiceDb(new Microsoft.EntityFrameworkCore.DbContextOptions<InvoiceDb>());
        }
    }
}