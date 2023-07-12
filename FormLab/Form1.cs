using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormLab
{
    
    public partial class Form1 : Form
    {
        static int counter = 0;
        Size defaultSize = new Size(500, 300);
        DialogResult dialogResult;
        List<FormWithId> CreatedForms = new List<FormWithId>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateForm_MouseClick(object sender, MouseEventArgs e)
        {
          if (rbUsal.Checked)
            {
                FormWithId UsalForm = new FormWithId();
                counter++;
                UsalForm.id = counter;
                UsalForm.Size = defaultSize;
                UsalForm.Text = $"Обычная форма # {counter}";
                UsalForm.Show();
                CreatedForms.Add(UsalForm);
                listBox_forms.Items.Add(UsalForm.id);
            }
            else
            {
                if (rbModal.Checked)
                {
                    FormWithId ModalForm = new FormWithId();
                    ModalForm.Owner = this;
                    counter++;
                    ModalForm.Size = defaultSize;
                    ModalForm.Text = $"Модальная форма # {counter}";
                    Button button001 = new Button();
                    button001.Text = "001";
                    button001.Location = new Point(10,10);
                    Button button002 = new Button();
                    button002.Text = "002";
                    button002.Location = new Point(10, 50);
                    ModalForm.Controls.Add(button001);
                    ModalForm.Controls.Add(button002);
                    button001.DialogResult = DialogResult.OK;
                    button002.DialogResult = DialogResult.Cancel;
                    button001.MouseClick += Button00x_MouseClick;
                    button002.MouseClick += Button00x_MouseClick;
                    ModalForm.ShowDialog();
                    listBox_forms.Items.Add(ModalForm.id);
                }
                else
                {
                    if (rbMDI.Checked)
                    {
                        this.IsMdiContainer = true;
                        FormWithId MDIForm = new FormWithId();
                        MDIForm.MdiParent = this;
                        counter++;
                        MDIForm.Size = defaultSize;
                        MDIForm.Text = $"MDI форма # {counter}";
                        MDIForm.Show();
                        listBox_forms.Items.Add(MDIForm.id);
                    }
                }
            }
        }

        private void Button00x_MouseClick(object sender, MouseEventArgs e)
        {
            dialogResult = ((Button)sender).DialogResult;
            lbDialogResult.Text = dialogResult.ToString();
        }
        
        private void textBox_forms_TextChanged(object sender, EventArgs e)
        {
            int a = 0;
            try
            {                
                a = int.Parse(textBox_forms.Text);
                MessageBox.Show(a.ToString());
                CreatedForms.RemoveAt(a);
                 
            }
            catch (Exception )
            {                
                MessageBox.Show("Не пишите текст!!!");
                                
            }
        }

        private void listBox_forms_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (var item in CreatedForms)
            {
                if (item.id == Convert.ToInt32(((ListBox)sender).SelectedItem))
                {
                    item.Close();
                    listBox_forms.Items.RemoveAt(item.id - 1);
                }
            }
        }
    }
}
