using FlaskFactory.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaskFactory
{
    public partial class Form1 : Form
    {
        private Factory Factory;
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Factory = new Factory();
            Factory.InitiateFactory();
        }

        private static Form1 instance;
        public static Form1 Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Form1();
                }
                return instance;
            }
        }
        public static void SetSoldSoda(ListViewItem[] items)
        {
            if (Instance.IsHandleCreated)
            {
                Instance.Invoke((MethodInvoker)(() =>
                {
                    Instance.listViewSoldSoda.Items.Clear();
                    Instance.listViewSoldSoda.Items.AddRange(items);
                }));
            }
        }

        public static void SetSoldBeer(ListViewItem[] items)
        {
            if (Instance.IsHandleCreated)
            {
                Instance.Invoke((MethodInvoker)(() =>
                {
                    Instance.listViewSoldBeer.Items.Clear();
                    Instance.listViewSoldBeer.Items.AddRange(items);
                }));
            }
        }
    }
}
