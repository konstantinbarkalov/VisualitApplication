using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace VisualitApplication {

    public class BitmapPanel : FrameworkElement {
        protected readonly int w = 1920;
        protected readonly int h = 1080;
        protected RenderTargetBitmap renderTargetBitmap;
        protected System.Windows.Threading.DispatcherTimer Timer;
        protected DrawingVisual vis = new DrawingVisual();
        public DrawingContext ctx;      

        protected override void OnRender(DrawingContext drawingContext) {
            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this)) {
                drawingContext.DrawImage(renderTargetBitmap, new Rect(0, 0, w, h));
            }
            base.OnRender(drawingContext);
        }

        public BitmapPanel() : base() {
            renderTargetBitmap = new RenderTargetBitmap(w, h, 96, 96, System.Windows.Media.PixelFormats.Pbgra32);
            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 0, 0, 50);
            Timer.Tick += Timer_Tick;
            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this)) {
                Timer.Start();
            }
            CreateNewCtx();
        }
        protected void CreateNewCtx() {
            ctx = vis.RenderOpen();
        }
        protected void CloseCtx() {
            ctx.Close();
        }
        public void Render() {            
            CloseCtx();
            renderTargetBitmap.Render(vis);
            CreateNewCtx();

        }
        private void Timer_Tick(object sender, EventArgs e) {            
        }
    }

}
