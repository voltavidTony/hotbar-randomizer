using InputTracking;
using System.ComponentModel;
using System.Windows.Forms;

namespace Hotbar_Randomizer {
    public class RichTextBoxTransparent : RichTextBox {
        [Category("Behavior"), DefaultValue(false),
            Description("Sets whether the control captures mouse events.")]
        public bool TransparentToMouse { get; set; } = false;

        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }

        protected override void WndProc(ref Message m) {
            if (m.Msg == (int)WM.NCHITTEST && !DesignMode && TransparentToMouse)
                m.Result = (System.IntPtr)(-1);
            else base.WndProc(ref m);
        }
    }
}
