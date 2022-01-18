using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Apresentacao
{
    class DesabilitaControles
    {
        public void ClearControls(Control control)
        {
            if (control == null)
                return;
            foreach (Control c in control.Controls)
            {

                if (c.HasChildren)
                    ClearControls(c);

                if (c is TextBox)
                {

                    ((TextBox)c).Enabled = false;
                    continue;
                }

                if (c is MaskedTextBox)
                {

                    ((MaskedTextBox)c).Enabled = false;
                    continue;
                }

                if (c is ComboBox)
                {

                    ((ComboBox)c).Enabled = false;
                    continue;
                }

                if (c is ListBox)
                {

                    ((ListBox)c).Enabled = false;
                    continue;
                }

                if (c is ListView)
                {

                    ((ListView)c).Enabled = false;
                    continue;
                }

                if (c is RichTextBox)
                {

                    ((RichTextBox)c).Enabled = false;
                    continue;
                }

                if (c is DateTimePicker)
                {

                    ((DateTimePicker)c).Enabled = false;
                    continue;
                }

                if (c is DataGridView)
                {

                    ((DataGridView)c).Enabled = false;
                    continue;
                }

                if (c is PictureBox)
                {

                    ((PictureBox)c).Enabled = false;
                    continue;
                }

                if (c is RadioButton)
                {

                    ((RadioButton)c).Enabled = false;
                    continue;
                }

                if (c is Button)
                {

                    ((Button)c).Enabled = false;
                    continue;
                }
            }

        }
    }
}
