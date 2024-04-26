using System.Windows;
using System.Windows.Controls;

namespace APAM.Views{
    public partial class APAM_DBEntitiesView : UserControl {
        public APAM_DBEntitiesView() {
            InitializeComponent();
        }

        private void BarShowStatisticReport(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            (new BusinnesChart()).Show();
        }
    }
}
