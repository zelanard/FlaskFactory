using FlaskFactory.Controllers;
using System;
using System.Windows.Forms;

namespace FlaskFactory
{
    public partial class Form1 : Form
    {
        private Factory Factory = null;
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (!Form1.Instance.IsHandleCreated)
            {
                // Force handle creation
                Form1.Instance.CreateHandle();
            }

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

        public void SetSoldSoda(ListViewItem[] items)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                this.listViewSoldSoda.Items.Clear();
                this.listViewSoldSoda.Items.AddRange(items);
                this.listViewSoldSoda.Refresh();
            }));
        }

        public void SetSoldBeer(ListViewItem[] items)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                this.listViewSoldBeer.Items.Clear();
                this.listViewSoldBeer.Items.AddRange(items);
            }));
        }
    }
}
