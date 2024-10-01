using System.Collections.ObjectModel;

namespace ON_TAP_WINFORM
{
    public partial class Form1 : Form
    {
        public static readonly CustomColor[] CustomForgeColorList =
        {
            new ("Đỏ", Color.Red),
            new ("Xanh", Color.Blue),
            new ("Tím", Color.Violet),
        };
        public static readonly CustomFontStyle[] CustomFontStyleList =
{
            new ("Nghiêng", FontStyle.Italic),
            new ("Đậm", FontStyle.Bold),
            new ("Gạch dưới", FontStyle.Underline)
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void InputMaXe_GotFocus(object sender, EventArgs e)
        {
            Button[] btns = [button1, button5, button6, button8, button9];
            foreach (Button btn in btns)
            {
                HandleChangeButtonEnable(btn, false);
            }
        }
        private void InputMaXe_LostFocus(object sender, EventArgs e)
        {
            Button[] btns = [button1, button5, button6, button8, button9];
            foreach (Button btn in btns)
            {
                HandleChangeButtonEnable(btn, true);
            }
        }
        private static void HandleChangeButtonEnable(Button btn, bool enable)
        {
            btn.Enabled = enable;
        }
    }
    public interface IFontStyle
    {
        public string Text { get; set; }
        public FontStyle FontStyle { get; set; }
    };
    public class CustomFontStyle(string inp_text, FontStyle inp_fontstyle) : IFontStyle
    {
        public string Text { get; set; } = inp_text;
        public FontStyle FontStyle { get; set; } = inp_fontstyle;
    }
    public interface IColor {
        public string Text { get; set; }
        public Color Color { get; set; }
    };
    public class CustomColor: IColor
    {
        public string Text { get; set; }
        public Color Color { get; set; }

        public CustomColor(string inp_text, Color inp_color) { 
            Text = inp_text;
            Color = inp_color;
        }
        public CustomColor(string inp_text, (int, int, int) inp_color)
        {
            Text = inp_text;
            Color = Color.FromArgb(inp_color.Item1, inp_color.Item2, inp_color.Item3);
        }
    }
    public class CustomLayout(Label[] Labels, RadioButton[] ColorRadioButtons, CheckedListBox FontStyleCheckedListBox)
    {
        private readonly RadioButton[] RadioButtons = ColorRadioButtons;
        private readonly CheckedListBox FontStyleCheckedListBox = FontStyleCheckedListBox;
        private readonly Label[] ImportantLabels = Labels;
        public CustomFontStyle[]? FontStyles { get; set; } = null;
        public CustomColor? Color { get; set; } = null;

        private void HandleUpdateUILabels()
        {
            foreach (Label _label in ImportantLabels)
            {
                //FontStyleCheckedListBox.CheckedItems.;
                //_label.Font = new Font(_label.Font, );
            }
        }
    }
}
