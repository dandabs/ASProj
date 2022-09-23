using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASProj.Utils;

namespace ASProj.Controls
{
    public partial class MenuListIconButton : UserControl
    {
        private bool selected;
        private Color selectedcolor;
        private char ico;
        public bool Selected
        {
            get { return selected; }
            set { selected = value; onSelectionChanged(); }
        }
        public Color SelectedColor
        {
            get { return selectedcolor; }
            set { selectedcolor = value; onSelectionChanged(); }
        }
        public char Icon
        {
            get { return ico; }
            set { ico = value; onSelectionChanged(); }
        }
        public MenuListIconButton()
        {
            InitializeComponent();
            this.Controls.Add(new Label()
            {
                Name = "icon",
                Font = new Font("Font Awesome 6 Free Solid", 12),
                Text = ico.ToString()
            });
            Region = Region.FromHrgn(GenericUtils.CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
            Cursor = Cursors.Hand;
            centerText();
            onSelectionChanged();

            ((Label)Controls.Find("icon", true)[0]).Click += new EventHandler(Control_Click);
        }
        private void Control_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void centerText()
        {
            try
            {
                // place the label in the middle of the textbox
                /*height*/
                ((Label)Controls.Find("icon", true)[0]).Top = (Height / 2) - (Controls.Find("icon", true)[0].PreferredSize.Height / 2);
                /*width*/
                ((Label)Controls.Find("icon", true)[0]).Left = (Width / 2) - (Controls.Find("icon", true)[0].PreferredSize.Width / 2);
            } catch (Exception _) { }
            }
        private void onSelectionChanged()
        {
            ((Label)Controls.Find("icon", true)[0]).Text = ico.ToString();
            if (Selected)
            {
                Color parentBackColor = this.Parent.BackColor;
                int alpha = (int)Math.Floor(255 * 0.30); // set transparency / alpha channel value to 50% of 255 (full value)
                Color dcWithAlpha = Color.FromArgb(alpha, SelectedColor.R, SelectedColor.G, SelectedColor.B);

                BackColor = GenericUtils.AlphaComposite(parentBackColor, dcWithAlpha); // combine the two colors as if they were transparent
                ((Label)Controls.Find("icon", true)[0]).ForeColor = SelectedColor;
            } else
            {
                BackColor = Color.Transparent;
                ((Label)Controls.Find("icon", true)[0]).ForeColor = ForeColor;
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Region = Region.FromHrgn(GenericUtils.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            centerText();
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            ((Label)Controls.Find("icon", true)[0]).Font = Font;
        }

        private void MenuListIconButton_Load(object sender, EventArgs e)
        {

        }
    }
}
