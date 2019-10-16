using System.Drawing;
using System.Windows.Forms;

namespace CleverBoard.Controls
{
    public class MyToolStripRenderer : ToolStripProfessionalRenderer
    {
        private int _imageMarginRight;
        private readonly Color _imageMarginColor;
        private readonly Color _selectionBorderColor;
        private readonly Color _selectionFillColor;

        public MyToolStripRenderer()
          : base(new MyToolStripColorTable())
        {
            _imageMarginColor = Color.FromArgb(sbyte.MaxValue, SystemColors.ControlDark);
            _selectionBorderColor = Color.FromArgb(200, SystemColors.Highlight);
            _selectionFillColor = Color.FromArgb(50, SystemColors.Highlight);
        }

        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            base.OnRenderImageMargin(e);
            _imageMarginRight = e.AffectedBounds.Right + 4;
            e.Graphics.DrawLine(new Pen(_imageMarginColor), e.AffectedBounds.Right + 5, e.AffectedBounds.Y + 2, e.AffectedBounds.Right + 5, e.AffectedBounds.Bottom - 4);
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (!e.Item.Selected)
                return;
            Rectangle rectangle = new Rectangle(Point.Empty, e.Item.Bounds.Size);
            e.Graphics.FillRectangle(new SolidBrush(_selectionFillColor), rectangle.X + 3, rectangle.Y, rectangle.Width - 6, rectangle.Height - 2);
            e.Graphics.DrawRectangle(new Pen(_selectionBorderColor), rectangle.X + 3, rectangle.Y, rectangle.Width - 6, rectangle.Height - 2);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(_imageMarginColor), _imageMarginRight, 2, 200, 2);
        }
    }
}
