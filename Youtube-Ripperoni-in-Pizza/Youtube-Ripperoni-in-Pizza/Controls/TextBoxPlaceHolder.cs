using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Youtube_Ripperoni_in_Pizza.Controls
{
    public class TextBoxPlaceHolder : TextBox
    {
        #region Properties

        private string placeHolder = string.Empty;

        [Category("Placeholder")]
        [Description("Sets the text of the placeholder")]
        public string Placeholder
        {
            get { return this.placeHolder; }
            set
            {
                this.placeHolder = value;
                DrawPlaceHolder();
            }
        }

        #endregion Properties

        public TextBoxPlaceHolder()
        {
            this.Enter += ThisOnEnter;
            this.Leave += ThisOnLeave;
            DrawPlaceHolder();
        }

        private void DrawPlaceHolder()
        {
            this.Text = Placeholder;
            this.ForeColor = SystemColors.GrayText;
            this.Invalidate();
        }

        private void RemovePlaceHolder()
        {
            this.Text = string.Empty;
            this.ForeColor = SystemColors.WindowText;
            this.Invalidate();
        }

        private void ThisOnEnter(object sender, EventArgs e)
        {
            if(this.Text.Equals(Placeholder)) {
                RemovePlaceHolder();
            }
        }

        private void ThisOnLeave(object sender, EventArgs e)
        {
            if(this.Text.Length == 0) {
                DrawPlaceHolder();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawPlaceHolder();
        }
    }
}