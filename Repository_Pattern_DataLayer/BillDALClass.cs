using Repository_Pattern_DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern_DataLayer
{
    public class BillDALClass
    {
        private string _billID;

        public string BillID
        {
            get { return _billID; }
            set { _billID = value; }
        }
        private string _billFor;

        public string BillFor
        {
            get { return _billFor; }
            set { _billFor = value; }
        }
        private double _amount;

        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        private string _paidBy;

        public string PaidBy
        {
            get { return _paidBy; }
            set { _paidBy = value; }
        }
    }
}
