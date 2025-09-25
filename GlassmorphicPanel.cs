using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace weather_app_winforms
{
    [DesignerCategory("Code")]
    public class GlassmorphicPanel : Panel // I love you baby no worries I understand Mwa
    {
        #region Fields
        private int _cornerRadius = 20;
        private int _borderThickness = 1;
        private Color _borderColor = Color.FromArgb(150, 255, 255, 255);
        private Color _glassColor = Color.FromArgb(100, 255, 255, 255);
        private int _blurOpacity = 30;
        #endregion

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // WS_CLIPCHILDREN
                return cp;
            }
        }


        #region Constructor
        public GlassmorphicPanel()
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.UserPaint |
                    ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            BackColor = Color.Transparent;
            UpdateStyles(); ;



            DoubleBuffered = true;
            BackColor = Color.Transparent;
            ForeColor = Color.White;
        }
        #endregion

        #region Properties
        [Category("Appearance")]
        [Description("Radius of the rounded corners")]
        [DefaultValue(20)]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = Math.Max(0, value); UpdateRegions(); Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Border thickness (0 = no border)")]
        [DefaultValue(1)]
        public int BorderThickness
        {
            get => _borderThickness;
            set { _borderThickness = Math.Max(0, value); UpdateRegions(); Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Color of the border with transparency")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Glass effect base color")]
        public Color GlassColor
        {
            get => _glassColor;
            set { _glassColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Blur overlay intensity (0-100)")]
        [DefaultValue(30)]
        public int BlurOpacity
        {
            get => _blurOpacity;
            set
            {
                _blurOpacity = Math.Max(0, Math.Min(100, value));
                Invalidate();
            }
        }
        #endregion

        #region Painting
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            Rectangle mainRect = new Rectangle(0, 0, Width, Height);
            Rectangle glassRect = new Rectangle(0, 0, Width - 1, Height - 1);

            // Create base glass effect
            using (GraphicsPath path = CreateRoundedRectanglePath(glassRect, _cornerRadius))
            using (var glassBrush = new SolidBrush(Color.FromArgb(_glassColor.A, _glassColor)))
            {
                e.Graphics.FillPath(glassBrush, path);
            }

            // Create blur overlay
            using (GraphicsPath path = CreateRoundedRectanglePath(glassRect, _cornerRadius))
            using (var blurBrush = new SolidBrush(Color.FromArgb((int)(_blurOpacity * 2.55f), Color.White)))
            {
                e.Graphics.FillPath(blurBrush, path);
            }

            // Draw border
            if (_borderThickness > 0)
            {
                using (GraphicsPath path = CreateRoundedRectanglePath(mainRect, _cornerRadius))
                using (Pen borderPen = new Pen(_borderColor, _borderThickness))
                {
                    e.Graphics.DrawPath(borderPen, path);
                }
            }

            // Draw inner highlight
            using (GraphicsPath path = CreateRoundedRectanglePath(
                new Rectangle(1, 1, Width - 3, Height - 3),
                Math.Max(0, _cornerRadius - 2)))
            using (Pen highlightPen = new Pen(Color.FromArgb(50, Color.White), 1))
            {
                e.Graphics.DrawPath(highlightPen, path);
            }
        }
        #endregion

        #region Region Handling
        // Modify the UpdateRegions method
        private void UpdateRegions()
        {
            if (this.IsDisposed || !this.IsHandleCreated)
                return;

            using (GraphicsPath path = CreateRoundedRectanglePath(ClientRectangle, _cornerRadius))
            {
                Region = new Region(path);
            }
            // Remove the Parent?.Invalidate() call
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegions();
        }
        #endregion

        #region Path Creation
        private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            if (radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rect.Location, size);

            // Top left
            path.AddArc(arc, 180, 90);

            // Top right
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom right
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom left
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
        #endregion

        #region Transparency Handling
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            if (e.Control is ScrollableControl scrollable) // Handle all scrollable controls
            {
                scrollable.Scroll += (s, ev) => Invalidate();
            }
            SetupTransparentControl(e.Control);
        }
        #endregion
        #region Transparency Handling
        // In GlassmorphicPanel class

        private void SetupTransparentControl(Control control)
        {
            control.PreviewKeyDown += (s, e) => { if (e.KeyCode == Keys.Tab) Parent.SelectNextControl(this, true, true, true, true); };

            if (control is TextBoxBase || control is ComboBox)
            {
                control.BackColor = Color.FromArgb(100, Color.White);
                control.ForeColor = Color.White;
            }
        }
        #endregion
    }
}