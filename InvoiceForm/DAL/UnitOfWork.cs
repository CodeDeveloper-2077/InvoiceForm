using InvoiceForm.Data;
using InvoiceForm.Models;

namespace InvoiceForm.DAL
{
    public class UnitOfWork
    {
        private readonly InvoiceDb _context;
        private GenericRepository<Invoice> _invoiceRepository;
        private GenericRepository<InvoicePosition> _invoicePositionRepository;

        public UnitOfWork(InvoiceDb context)
        {
            _context = context;
        }

        public GenericRepository<Invoice> InvoiceRepository
        {
            get
            {

                if (_invoiceRepository == null)
                {
                    _invoiceRepository = new GenericRepository<Invoice>(_context);
                }
                return _invoiceRepository;
            }
        }

        public GenericRepository<InvoicePosition> InvoicePositionRepository
        {
            get
            {
                if (_invoicePositionRepository == null)
                {
                    _invoicePositionRepository = new GenericRepository<InvoicePosition>(_context);
                }
                return _invoicePositionRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }


        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}