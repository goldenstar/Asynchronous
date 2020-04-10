using System;
using System.Threading.Tasks;

namespace Demo7.Deadlock
{
    public partial class UserControl: System.Windows.Forms.UserControl
    {
        public UserControl()
        {
            InitializeComponent();
        }

        private async void button_Click(object sender, EventArgs e)
        {
            StartWorkAsync().GetAwaiter().GetResult();

            button.Text = "Thank you";
        }

        private async Task StartWorkAsync()
        {
            await Task.Delay(3000);
        }
    }
}
