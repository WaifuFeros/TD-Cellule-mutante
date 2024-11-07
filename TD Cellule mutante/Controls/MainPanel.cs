using System;
using System.Windows.Forms;
using System.Drawing;
namespace GraphiqueFromCode.Controls
{
    public class MainPanel : Panel
    {
        public MainPanel()
        {
            Name = "pnl_main";
            BackColor = Color.LightGray;
            Anchor = AnchorStyles.None;
            Size = new Size(300, 300);
            Dock = DockStyle.None;
        }
    }
}
