using System;
using System.Threading.Tasks;
using System.Windows;


namespace VisualitApplication {

    public partial class MainWindow : Window {
        public Visualit visualit = new Visualit();
        public MainWindow() {
            InitializeComponent();
            MasterCanvas.Children.Add(visualit.panel);

            visualit.DrawLine(200, 200, 400, 200);
            visualit.DrawLine(300, 200, 300, 300);
            visualit.DrawLine(200, 300, 400, 300);
            visualit.DrawLine(200, 300, 200, 400);
            visualit.DrawLine(400, 300, 400, 400);
            visualit.DrawLine(200, 400, 400, 400);
        }

    }
}
