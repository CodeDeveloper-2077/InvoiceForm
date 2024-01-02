using InvoiceForm.DAL;
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
        }
    }
}
