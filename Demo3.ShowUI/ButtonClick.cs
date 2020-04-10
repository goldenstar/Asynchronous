using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3.ShowUI
{
    public partial class ButtonClick: UserControl
    {
        public ButtonClick()
        {
            InitializeComponent();
        }

        private async void button_Click(object sender, EventArgs e)
        {
            int idBeforeDelay = Thread.CurrentThread.ManagedThreadId;

            await Task.Delay(500);

            int idAfterDelay = Thread.CurrentThread.ManagedThreadId;

            if (idAfterDelay == idBeforeDelay)
            {
                // Захватили тот же контекст, который является однопоточным, продолжение выполняем в этом же контексте.
                // Поток тот же!
                label.Text = "The same context! The same thread!";
            }
        }
    }
}
