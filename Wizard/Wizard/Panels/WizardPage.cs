using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treorisoft.Wizard.Panels
{
    public class WizardPage : Panel
    {
        private Guid id;
        private Guid parentId;

        public WizardPage()
        {
            id = Guid.NewGuid();
        }

        public Guid ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
