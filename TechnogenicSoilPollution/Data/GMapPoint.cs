using System;
using System.Drawing;
using GMap.NET;
using GMap.NET.WindowsForms;

namespace TechnogenicSoilPollution.Data
{
    public class GMapPoint : GMapMarker
    {
        private PointLatLng point_;
        private float size_ = 2;
        private Brush brush;
        public PointLatLng Point
        {
            get
            {
                return point_;
            }
            set
            {
                point_ = value;
            }
        }

        public GMapPoint(PointLatLng p, double qt)
            : base(p)
        {
            point_ = p;
            if (qt > 10)
            {
                brush = new SolidBrush(Color.FromArgb(140, 255, 0, 0));
            }
            else if (qt > 1)
            {
                brush = new SolidBrush(Color.FromArgb(140, 255, 128, 0));
            }
            else if (qt > 0.06)
            {
                brush = new SolidBrush(Color.FromArgb(140, 255, 255, 0));
            }
            else if (qt > 0.01)
            {
                brush = new SolidBrush(Color.FromArgb(140, 21, 144, 100));
            }
            else
            {
                brush = new SolidBrush(Color.FromArgb(140, 0, 255, 0));
            }
        }

        public override void OnRender(Graphics g)
        {
            g.FillRectangle(brush, LocalPosition.X, LocalPosition.Y, size_, size_);
        }
    }
}
