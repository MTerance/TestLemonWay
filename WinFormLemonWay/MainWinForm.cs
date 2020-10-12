using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLemonWay.FibonacciServiceReference;



namespace WinFormLemonWay
{
    public partial class MainWinForm : Form
    {
        private bool _runningOperation;
        public MainWinForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (_runningOperation)
            {
                await Task.Run(() =>
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                });
                return;
            }
            await Task.Run(() =>
            {
                _runningOperation = true;
                BusyForm busyForm = new BusyForm();
                busyForm.Show();
                FibonacciServiceSoapClient service = new FibonacciServiceSoapClient();
                int result = service.Fibonacci(10);
                busyForm.Close();
                MessageBox.Show(result.ToString(), "result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _runningOperation = false;
            });


        }
    }
}
