using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using APAM;

namespace APAM.ViewModels
{
    public class BusinessChartViewModel
    {
        public ObservableCollection<DataPoint> OrdersData { get; private set; }
        public ObservableCollection<DataPoint> AdministratorSalaryData { get; private set; }
        public ObservableCollection<DataPoint> BookkeeperSalaryData { get; private set; }
        public ObservableCollection<DataPoint> SellerSalaryData { get; private set; }
        public ObservableCollection<DataPoint> OverallSalaryData { get; private set; }

        public BusinessChartViewModel()
        {
            try
            {
                var context = new APAM_DBEntities();
                var orders = context.Orders.ToList();
                var autoParts = context.AutoParts.ToList();
                var administratorSalaries = context.AdministratorSalaries.ToList();
                var bookkeeperSalaries = context.BookkeeperSalaries.ToList();
                var sellerSalaries = context.SellerSalaries.ToList();


                var od = orders.Where(x => x.OrderFinishedDateTime != null).ToList()
                    .Select(o => new DataPoint
                    (
                        (DateTime)o.OrderFinishedDateTime,
                        Convert.ToDouble(autoParts.Where(ap => ap.AutoPartId == o.AutoPartId).First().Cost)
                    )).ToList();

                OrdersData = new ObservableCollection<DataPoint>(od);

                var asd = administratorSalaries.Select(o => new DataPoint
                    (
                        (DateTime)o.IssueDate,
                        Convert.ToDouble(o.Salary)
                    )).ToList();
                AdministratorSalaryData = new ObservableCollection<DataPoint>(asd);

                var bsd = bookkeeperSalaries.Select(o => new DataPoint
                   (
                       (DateTime)o.IssueDate,
                       Convert.ToDouble(o.Salary)
                   )).ToList();
                BookkeeperSalaryData = new ObservableCollection<DataPoint>(bsd);

                var ssd = sellerSalaries.Select(o => new DataPoint
                  (
                      (DateTime)o.IssueDate,
                      Convert.ToDouble(o.Salary)
                  )).ToList();
                SellerSalaryData = new ObservableCollection<DataPoint>(ssd);

                var osd = new List<DataPoint>();
                osd.AddRange(asd);
                osd.AddRange(osd);
                osd.AddRange(ssd);

                OverallSalaryData = new ObservableCollection<DataPoint>(osd);
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Data problem. Unable to build chart!");
            }
        }
    }

    public class DataPoint
    {
        public DateTime Time { get; set; }
        public double Value { get; set; }
        public DataPoint(DateTime time, double value)
        {
            this.Time = time;
            this.Value = value;
        }
    }
}
