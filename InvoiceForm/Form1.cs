using InvoiceForm.DAL;
using InvoiceForm.Data;

namespace InvoiceForm
{
    public partial class Form1 : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public Form1()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork(this.ContextFactory());
            dataGridView1.DataSource = _unitOfWork.InvoiceRepository.GetAll();
        }

        private InvoiceDb ContextFactory()
        {
            return new InvoiceDb(new Microsoft.EntityFrameworkCore.DbContextOptions<InvoiceDb>());
        }
    }
}