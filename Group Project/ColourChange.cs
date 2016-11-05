using System.Drawing;
using System.Windows.Forms;

namespace Group_Project
{
    class ColourChange
    {
         //setting the default colours
            private Color BackgroundColour
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
            private Color TextColour
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
            private Color TextboxBackColour
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
            private Color HighlightColour
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
            private Color HighlightTextColour
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
            public void ColourLabel(Label lbl)
            {
                lbl.BackColor = BackgroundColour;
                lbl.ForeColor = TextColour;
            }
            public void ColourTextbox(TextBox txt)
            {
                txt.BackColor = TextboxBackColour;
                txt.ForeColor = TextColour;
            }
            public void ColourNumericUD(NumericUpDown nud)
            {
                nud.BackColor = BackgroundColour;
                nud.ForeColor = TextColour;
            }
            public void ColourPanel(Panel pnl)
            {
                pnl.BackColor = BackgroundColour;
            }
            public void ColourForm(Form frm)
            {
                frm.BackColor = BackgroundColour;
            }
            public void ColourDGV(DataGridView dgv)
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
