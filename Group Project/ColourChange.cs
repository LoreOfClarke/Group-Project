using System.Drawing;
using System.Windows.Forms;

namespace Group_Project
{
    /// <summary>
    /// A class Dealing with changing the colours of form objects
    /// </summary>
    static class ColourChange
    {
        /// <summary>
        /// Check the properties and get the appropriate colour for backgrounds
        /// </summary>
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
                    else if (Properties.Settings.Default.ColourSetting == 2)
                    {
                        return Color.LightCoral;
                    }
                    else
                    {
                        return Color.WhiteSmoke;
                    }
                }
        }
        /// <summary>
        /// Check the properties and get the appropriate colour for text
        /// </summary>
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
                else if (Properties.Settings.Default.ColourSetting == 2)
                {
                    return Color.Black;
                }
                else
                    {
                        return Color.Black;
                    }
                }
            }
        /// <summary>
        /// Check the properties and get the appropriate colour for the backgrounds of textboxes
        /// </summary>
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
                else if (Properties.Settings.Default.ColourSetting == 2)
                {
                    return Color.WhiteSmoke;
                }
                else
                    {
                        return SystemColors.Control;
                    }
                }
            }
        /// <summary>
        /// Check the properties and get the appropriate colour for the highlighted backgrounds
        /// </summary>
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
                else if (Properties.Settings.Default.ColourSetting == 2)
                {
                    return Color.LawnGreen;
                }
                else
                    {
                        return SystemColors.ControlDark;
                    }
                }
            }
        /// <summary>
        /// Check the properties and get the appropriate colour for the highlighted text
        /// </summary>
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
                else if (Properties.Settings.Default.ColourSetting == 2)
                {
                    return Color.ForestGreen;
                }
                else
                    {
                        return SystemColors.ControlLightLight;
                    }
                }
            }

        /// <summary>
       /// Colour the label
       /// </summary>
       /// <param name="lbl">Label to colour</param>
        public static void ColourLabel(Label lbl)
            {
                lbl.BackColor = BackgroundColour;
                lbl.ForeColor = TextColour;
            }
        /// <summary>
        /// Colour the textcox
        /// </summary>
        /// <param name="txt">Textbox to colour</param>
        public static void ColourTextbox(TextBox txt)
            {
                txt.BackColor = TextboxBackColour;
                txt.ForeColor = TextColour;
            }
        /// <summary>
        /// Colour the Numeric Up and Down box
        /// </summary>
        /// <param name="nud">The numeric up and down object</param>
        public static void ColourNumericUD(NumericUpDown nud)
            {
                nud.BackColor = BackgroundColour;
                nud.ForeColor = TextColour;
            }
        /// <summary>
        /// Colour the panel
        /// </summary>
        /// <param name="pnl">The panel to colour</param>
        public static void ColourPanel(Panel pnl)
        {
            pnl.BackColor = BackgroundColour;
        }
        /// <summary>
        /// Colour the Split Panel
        /// </summary>
        /// <param name="spnl">Split Panel to Colour</param>
        public static void ColourSplitPanel(SplitContainer spnl)
        {
            spnl.BackColor = BackgroundColour;
        }
        /// <summary>
        /// Colour the form (and not the objects on it)
        /// </summary>
        /// <param name="frm">The form to colour</param>
        public static void ColourForm(Form frm)
            {
                frm.BackColor = BackgroundColour;
            }
        /// <summary>
        /// Colour the datagridview
        /// </summary>
        /// <param name="dgv">The DataGridView to colour</param>
        public static void ColourDGV(DataGridView dgv)
            {
                dgv.DefaultCellStyle.BackColor = TextboxBackColour;
                dgv.DefaultCellStyle.ForeColor = TextColour;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = HighlightColour;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = HighlightTextColour;
                dgv.RowHeadersDefaultCellStyle.BackColor = HighlightColour;
                dgv.RowHeadersDefaultCellStyle.ForeColor = HighlightTextColour;
            }
        /// <summary>
        /// Colour the Date-Time Picker (Currently not working)
        /// </summary>
        /// <param name="dtp">The DateTimePicker To Colour</param>
        public static void ColourDTP(DateTimePicker dtp)
        {
            dtp.CalendarMonthBackground = TextboxBackColour;
            dtp.CalendarForeColor = TextColour;
            dtp.CalendarTitleBackColor = TextboxBackColour;
            dtp.CalendarTitleForeColor = TextColour;
            dtp.CalendarTrailingForeColor = HighlightTextColour;
        }
        /// <summary>
        /// Colour the Menu Strip
        /// </summary>
        /// <param name="mnu">The Menu Strip to colour</param>
        public static void ColourMenuStrip(MenuStrip mnu)
        {
            mnu.BackColor = BackgroundColour;
            mnu.ForeColor = TextColour;
            ToolStripComboBox tbx = new ToolStripComboBox();
            foreach (object mnuitem in mnu.Items)
            {
                if (mnuitem.GetType() == tbx.GetType())
                {
                    tbx = (ToolStripComboBox)mnuitem;
                    tbx.BackColor = TextboxBackColour;
                    tbx.ForeColor = TextColour;
                }
            }
        }
        /// <summary>
        /// Colour the Button
        /// </summary>
        /// <param name="cmd">The Button to colour</param>
        public static void ColourButton(Button cmd)
        {
            cmd.BackColor = BackgroundColour;
            cmd.ForeColor = TextColour;
        }
        /// <summary>
        /// Colour The ComboBox
        /// </summary>
        /// <param name="cbo">The combobox to colour</param>
        public static void ColourCombobox(ComboBox cbo)
        {
            cbo.BackColor = TextboxBackColour;
            cbo.ForeColor = TextColour;
        }
        /// <summary>
        /// Colour the Checkbox
        /// </summary>
        /// <param name="chk">The cehckbox to colour</param>
        public static void ColourCheckbox(CheckBox chk)
        {
            chk.ForeColor = TextColour;
        }

        }
}
