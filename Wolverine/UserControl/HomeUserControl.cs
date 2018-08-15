using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wolverine
{
    public partial class HomeUserControl : UserControl
    {
        private static HomeUserControl instance;

        public static HomeUserControl Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new HomeUserControl();
                }
                return instance;

            }
        }

        public HomeUserControl()
        {
            InitializeComponent();
        }
    }
}
