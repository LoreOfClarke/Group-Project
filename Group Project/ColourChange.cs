using System.Drawing;
using System.Windows.Forms;

namespace Group_Project
{
    static class ColourChange
    {
         //setting the default colours
            private static Color BackgroundColour
            {
                get
                {
                    if (Properties.Settings.Default.ColourSetting == 0)
                    {
                        return SystemColors.Control;
                    }
                    else if (Properties.Settings.Default.ColourSetting == 1)
                    {
                        return Color.Black;
                    }
                    else
                    {
                        return Color.WhiteSmoke;
                    }
                }
            }
            private static Color TextColour
            {
                get
                {
                    if (Properties.Settings.Default.ColourSetting == 0)
                    {
                        return Color.Black;
                    }
                    else if (Properties.Settings.Default.ColourSetting == 1)
                    {
                        return Color.WhiteSmoke;
                    }
                    else
                    {
                        return Color.Black;
                    }
                }
            }
            private static Color TextboxBackColour
            {
                get
                {
                    if (Properties.Settings.Default.ColourSetting == 0)
                    {
                        return Color.WhiteSmoke;
                    }
                    else if (Properties.Settings.Default.ColourSetting == 1)
                    {
                        return SystemColors.ControlDark;
                    }
                    else
                    {
                        return SystemColors.Control;
                    }
                }
            }
            private static Color HighlightColour
            {
                get
                {
                    if (Properties.Settings.Default.ColourSetting == 0)
                    {
                        return Color.Goldenrod;
                    }
                    else if (Properties.Settings.Default.ColourSetting == 1)
                    {
                        return Color.DarkGoldenrod;
                    }
                    else
                    {
                        return SystemColors.ControlDark;
                    }
                }
            }
            private static Color HighlightTextColour
            {
                get
                {
                    if (Properties.Settings.Default.ColourSetting == 0)
                    {
                        return Color.BlueViolet;
                    }
                    else if (Properties.Settings.Default.ColourSetting == 1)
                    {
                        return Color.AliceBlue;
                    }
                    else
                    {
                        return SystemColors.ControlLightLight;
                    }
                }
            }

            //applying the colours to controls
            public static void ColourLabel(Label lbl)
            {
                lbl.BackColor = BackgroundColour;
                lbl.ForeColor = TextColour;
            }
            public static void ColourTextbox(TextBox txt)
            {
                txt.BackColor = TextboxBackColour;
                txt.ForeColor = TextColour;
            }
            public static void ColourNumericUD(NumericUpDown nud)
            {
                nud.BackColor = BackgroundColour;
                nud.ForeColor = TextColour;
            }
            public static void ColourPanel(Panel pnl)
            {
                pnl.BackColor = BackgroundColour;
            }
            public static void ColourForm(Form frm)
            {
                frm.BackColor = BackgroundColour;
            }
            public static void ColourDGV(DataGridView dgv)
            {
                dgv.DefaultCellStyle.BackColor = TextboxBackColour;
                dgv.DefaultCellStyle.ForeColor = TextColour;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = HighlightColour;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = HighlightTextColour;
                dgv.RowHeadersDefaultCellStyle.BackColor = HighlightColour;
                dgv.RowHeadersDefaultCellStyle.ForeColor = HighlightTextColour;
            }
        
    }
}
