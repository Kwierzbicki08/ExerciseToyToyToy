using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseToyToyToy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listToys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listToys.SelectedItem == null)
            {
                return;
            }
            if (listToys.SelectedItem is ISpeed)
            {
                groupSpeed.Enabled = true;
                ISpeed handle = (ISpeed)listToys.SelectedItem;
                textSpeed.Text = handle.GetCurrentSpeed().ToString();
            }
            else
            {
                groupSpeed.Enabled = false;
            }

            if (listToys.SelectedItem is IAltitute)
            {
                groupAltitute.Enabled = true;
                IAltitute handle = (IAltitute)listToys.SelectedItem;
                textAltitute.Text = handle.GetCurrentAltitute().ToString();
            }
            else
            {
                groupAltitute.Enabled = false;
            }

            if (listToys.SelectedItem is IDepth)
            {
                groupDepth.Enabled = true;
                IDepth handle = (IDepth)listToys.SelectedItem;
                textDepth.Text = handle.GetCurrentDepth().ToString();
            }
            else
            {
                groupDepth.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listAvailableToys.SelectedItem == null)
            {
                MessageBox.Show("Nie wskazano obiektu do stworzenia!", "Error", MessageBoxButtons.OK);
            }
            else if (listAvailableToys.SelectedItem.ToString() == "Car")
            {
                listToys.Items.Add(new Car());
            }
            else if (listAvailableToys.SelectedItem.ToString() == "Plane")
            {
                listToys.Items.Add(new Plane());
            }
            else if (listAvailableToys.SelectedItem.ToString() == "Submarine")
            {
                listToys.Items.Add(new Submarine());
            }
            else if (listAvailableToys.SelectedItem.ToString() == "Computer")
            {
                listToys.Items.Add(new Computer());
            }
        }

        private void textSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //&& (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            /*// only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }

        private void textAltitute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //&& (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            /*// only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }

        private void textDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& e.KeyChar != '.'*/ && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            /*// only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listToys.SelectedItem != null)
            {
                listToys.Items.Remove(listToys.SelectedItem);
            }
            else
                MessageBox.Show("Nie wskazano obiektu do usunięcia!", "Error", MessageBoxButtons.OK);
        }

        private void buttonUpSpeed_Click(object sender, EventArgs e)
        {
            if (listToys.SelectedItem is ISpeed) //!=null
            {
                ISpeed handle = (ISpeed)listToys.SelectedItem;
                handle.IncSpeed();
                textSpeed.Text = handle.GetCurrentSpeed().ToString();
                //textSpeed.Text = (int.Parse(textSpeed.Text) + 1).ToString();
            }
            if (listToys.SelectedItem == null)
            {
                MessageBox.Show("Wybierz obiekt do modyfikacji prędkości", "Error", MessageBoxButtons.OK);
            }
        }

        private void buttonDownSpeed_Click(object sender, EventArgs e)
        {
            if(listToys.SelectedItem is ISpeed) //!=null
            {
                ISpeed handle = (ISpeed)listToys.SelectedItem;
                handle.DecSpeed();
                textSpeed.Text = handle.GetCurrentSpeed().ToString();
                //textSpeed.Text = (int.Parse(textSpeed.Text) - 1).ToString();
            }
            if (listToys.SelectedItem == null)
            {
                MessageBox.Show("Wybierz obiekt do modyfikacji prędkości", "Error", MessageBoxButtons.OK);
            }
        }

        private void buttonUpAltitute_Click(object sender, EventArgs e)
        {
            if (listToys.SelectedItem is IAltitute) //!=null
            {
                IAltitute handle = (IAltitute)listToys.SelectedItem;
                handle.IncAltitute();
                textAltitute.Text = handle.GetCurrentAltitute().ToString();
                //textAltitute.Text = (int.Parse(textAltitute.Text) + 1).ToString();
            }
            if(listToys.SelectedItem == null)
            {
                MessageBox.Show("Wybierz obiekt do modyfikacji wysokości", "Error", MessageBoxButtons.OK);
            }

        }

        private void buttonDownAltitute_Click(object sender, EventArgs e)
        {
            if (listToys.SelectedItem is IAltitute) //!=null
            {
                IAltitute handle = (IAltitute)listToys.SelectedItem;
                handle.DecAltitute();
                textAltitute.Text = handle.GetCurrentAltitute().ToString();
                //textAltitute.Text = (int.Parse(textAltitute.Text) - 1).ToString();
            }
            if (listToys.SelectedItem == null)
            {
                MessageBox.Show("Wybierz obiekt do modyfikacji wysokości", "Error", MessageBoxButtons.OK);
            }

        }

        private void buttonUpDepth_Click(object sender, EventArgs e)
        {
            if (listToys.SelectedItem is IDepth) //!=null
            {
                IDepth handle = (IDepth)listToys.SelectedItem;
                handle.IncDepth();
                textDepth.Text = handle.GetCurrentDepth().ToString();
                //textDepth.Text = (int.Parse(textDepth.Text) + 1).ToString();
            }
            if (listToys.SelectedItem == null)
            {
                MessageBox.Show("Wybierz obiekt do modyfikacji głębokości", "Error", MessageBoxButtons.OK);
            }

        }

        private void buttonDownDepth_Click(object sender, EventArgs e)
        {
            if (listToys.SelectedItem is IDepth) //!=null
            {
                IDepth handle = (IDepth)listToys.SelectedItem;
                handle.DecDepth();
                textDepth.Text = handle.GetCurrentDepth().ToString();
                //textDepth.Text = (int.Parse(textDepth.Text) - 1).ToString();
            }
            if (listToys.SelectedItem == null)
            {
                MessageBox.Show("Wybierz obiekt do modyfikacji głębokości", "Error", MessageBoxButtons.OK);
            }

        }

        private void upgradeButton_Click(object sender, EventArgs e)
        {
            if (listToys.SelectedItem is ISpeed)
            {
                ((ISpeed)listToys.SelectedItem).ChangeSpeed(Int32.Parse(textSpeed.Text));
            }
            if (listToys.SelectedItem is IDepth)
            {
                ((IDepth)listToys.SelectedItem).ChangeDepth(Int32.Parse(textDepth.Text));
            }
            if (listToys.SelectedItem is IAltitute)
            {
                ((IAltitute)listToys.SelectedItem).ChangeAltitute(Int32.Parse(textAltitute.Text));
            }
            if(listToys.SelectedItem == null)
            {
                MessageBox.Show("Wybierz obiekt do manualnej modyfikacji", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
