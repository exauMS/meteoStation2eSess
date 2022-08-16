using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testAlarm.Controls
{
    public partial class Login : UserControl
    {

        private static Login instance = null;
        private static readonly object padlock = new object();
        public Login()
        {
            InitializeComponent();
        }

        public static Login GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new Login();
                    return instance;
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Oeoe");
        }
    }
}
