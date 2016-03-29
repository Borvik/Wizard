using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;
using Treorisoft.Wizard.Editors;

namespace Treorisoft.Wizard.Design
{
    internal class SmartTagBehavior : Behavior
    {
        private SmartTagDropDown _dropDown;

        private void ShowUI()
        {
            if(_dropDown == null)
            {
                _dropDown = new SmartTagDropDown()
                {
                    AutoClose = true,
                    DropShadowEnabled = true
                };
            }
        }
    }
}
