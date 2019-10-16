using System.Drawing;
using System.Windows.Forms;

namespace CleverBoard.Controls
{
    public class MyToolStripColorTable : ProfessionalColorTable
    {
        public override Color MenuBorder
        {
            get
            {
                return SystemColors.ButtonShadow;
            }
        }

        public override Color ToolStripDropDownBackground
        {
            get
            {
                return SystemColors.MenuBar;
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return SystemColors.Control;
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return SystemColors.Control;
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return SystemColors.Control;
            }
        }
    }
}
