using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestControl
{
    public partial class TestForm : Form
    {
        
        public enum TestEnum
        {
            Значение1,
            Значение2,
            Значение3,
            Значение4,
            Значение5
        }

        public ArrayList ArrayList = new ArrayList();

        public TestForm()
        {
            ArrayList.Add("Значение");
            ArrayList.Add("Значение2");
            ArrayList.Add("Значение3");
            ArrayList.Add("Значение4");
            ArrayList.Add("Значение5");
            InitializeComponent();
            controlComboBoxSelected.LoadEnumeration(typeof(TestEnum));
            userControlSelect.List = ArrayList.ToArray();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            controlComboBoxSelected.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getCheckIndex();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControlSelect.CheckIndexs = new List<int> { 1, 3, 4 };
        }

        public void getCheckIndex()
        {
            string str = "";
            foreach (var item in userControlSelect.CheckIndexs)
            {
                str += item.ToString() + " ";
            }

            MessageBox.Show(str);
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            userControlInput.Max = Convert.ToInt32(textBoxInpunSize.Text);
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            userControlInput.Min = Convert.ToInt32(textBoxInpunSize.Text);
        }
    }
}
