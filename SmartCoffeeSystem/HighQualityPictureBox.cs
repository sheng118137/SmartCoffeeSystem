using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SmartCoffeeSystem
{
    public class HighQualityPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            // 畫圖前，將所有繪圖品質參數調到最高等級
            pe.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic; // 最高品質雙三次內插法
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;                  // 消除邊緣鋸齒
            pe.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;            // 高精度像素偏移
            pe.Graphics.CompositingQuality = CompositingQuality.HighQuality;      // 高品質合成

            // 設定完最高畫質後，再放行給原生的 PictureBox 進行繪製
            base.OnPaint(pe);
        }
    }
}