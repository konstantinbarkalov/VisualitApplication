using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace VisualitApplication {

    public class Visualit {

        public BitmapPanel panel = new BitmapPanel();
        protected SolidColorBrush colorBrush = Brushes.Blue;
        protected Pen pen;

        public Visualit() {
            SetColor(0, 0, 255);
            
        }

        public void DrawPixel(int x, int y) {
            panel.ctx.DrawLine(pen, new Point(x, y), new Point(x, y));
            panel.Render();
        }
        public void DrawLine(int xFrom, int yFrom, int xTo, int yTo) {
            panel.ctx.DrawLine(pen, new Point(xFrom, yFrom), new Point(xTo, yTo));
            panel.Render();
        }
        public void DrawCircle(int x, int y, int radius) {
            panel.ctx.DrawEllipse(null, pen, new Point(x, y), x, y);
            panel.Render();
        }
        public void SetColor(byte r, byte g, byte b) {
            Color color = new Color { R = r, G = g, B = b, A = 255};            
            colorBrush = new SolidColorBrush(color);
            pen = new Pen(this.colorBrush, 2);
        }
        public void FillRect(int xFrom, int yFrom, int xTo, int yTo) {
            Rect rect = new Rect(new Point(xFrom, yFrom), new Point(xTo, yTo));
            panel.ctx.DrawRectangle(colorBrush, null, rect);
            panel.Render();

        }
    }
    
}
