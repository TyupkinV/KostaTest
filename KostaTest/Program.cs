using System;
using System.Windows.Forms;

namespace KostaTest {
    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindowV windowV = new MainWindowV();
            Application.Run(windowV);
        }
    }
}
