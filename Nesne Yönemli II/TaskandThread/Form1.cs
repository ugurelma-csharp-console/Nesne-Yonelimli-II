using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskandThread
{
    public partial class Form1 : Form
    {
        Task tskLacivert, tskMor;
        public Form1() => InitializeComponent();
        private void Lacivert()
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Invoke(new Action(() => progressBar1.Value = i));
                Thread.Sleep(50);
            }
        }

        private void Mor()
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBar2.Invoke(new Action(() => progressBar2.Value = i));
                Thread.Sleep(50);
            }
        }

        private void VeriYaz()
        {
            Thread.Sleep(5000);
            MessageBox.Show("Veriler yazıldı!");
        }

        private void VeriAl()
        {
            Thread.Sleep(5000);
            MessageBox.Show("Veriler alındı!");
        }
        private void Veri1()
        {
            Thread.Sleep(5000);
            MessageBox.Show("Veriler 1!");
        }
        private void Veri2()
        {
            Thread.Sleep(5000);
            MessageBox.Show("Veriler 2!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tskLacivert = Task.Factory.StartNew(() => { Lacivert(); });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task tskYaz = Task.Factory.StartNew(() => VeriYaz());
            Task tskAl = Task.Factory.StartNew(()=> VeriAl());
            Task tsk1 = Task.Factory.StartNew(() => Veri1());
            Task tsk2 = Task.Factory.StartNew(() => Veri2());
            tsk2.Wait();
            tsk2.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            tskMor = Task.Factory.StartNew(() => { tskLacivert?.Wait(); Mor(); });
        }
    }
}