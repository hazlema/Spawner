using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Spawner {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            numericUpDown1.Value = new Random(DateTime.Now.Second * DateTime.Now.Millisecond).Next(1, 5);
        }

        private void button2_Click(object sender, EventArgs e) {
            for (int counter = 0; counter < numericUpDown1.Value; counter++) {
                Process.Start(Application.ExecutablePath);
            }
        }

    }
}
