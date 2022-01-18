using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Apresentacao
{
    public class LimpaControles
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

                    ((TextBox)c).Clear();
                    continue;
                }

                if (c is MaskedTextBox)
                {

                    ((MaskedTextBox)c).Clear();
                    continue;
                }

                if (c is ComboBox)
                {

                    ((ComboBox)c).SelectedIndex = -1;
                    continue;
                }

                if (c is ListBox)
                {

                    ((ListBox)c).Items.Clear();
                    continue;
                }

                if (c is ListView)
                {

                    ((ListView)c).Items.Clear();
                    continue;
                }

                if (c is RichTextBox)
                {

                    ((RichTextBox)c).Clear();
                    continue;
                }

                //if (c is DateTimePicker)
                //{

                //    ((DateTimePicker)c).Format = DateTimePickerFormat.Custom;
                //    ((DateTimePicker)c).CustomFormat = "" ;
                //    continue;
                //}

                //if (c is DataGridView)
                //{

                //    ((DataGridView)c).Rows.Clear();
                //    continue;
                //}

                if (c is PictureBox)
                {

                    ((PictureBox)c).Image = null;
                    continue;
                }

                if (c is RadioButton)
                {

                    ((RadioButton)c).Checked = false;
                    continue;
                }
            }

        }
    }
        
}
