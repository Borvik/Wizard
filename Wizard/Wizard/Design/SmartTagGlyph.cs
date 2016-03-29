using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;

namespace Treorisoft.Wizard.Design
{
    internal class SmartTagGlyph : Glyph
    {
        private Bitmap _glyphOpen, _glyphClosed;

        private Image GlyphOpen
        {
            get
            {
                if(_glyphOpen == null)
                {
                    _glyphOpen = (Bitmap)Properties.Resources.Open_left.Clone();
                    _glyphOpen.MakeTransparent(Color.Magenta);
                }
                return _glyphOpen;
            }
        }

        private Image GlyphClosed
        {
            get
            {
                if(_glyphClosed == null)
                {
                    _glyphClosed = (Bitmap)Properties.Resources.Close_left.Clone();
                    _glyphClosed.MakeTransparent(Color.Magenta);
                }
                return _glyphClosed;
            }
        }

        public override Cursor GetHitTest(Point p)
        {
            throw new NotImplementedException();
        }

        public override void Paint(PaintEventArgs pe)
        {
            throw new NotImplementedException();
        }

    }
}
