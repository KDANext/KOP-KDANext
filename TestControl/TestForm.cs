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
         List<number> numbers = new List<number>();

        public TestForm()
        {
            ArrayList.Add("Значение");
            ArrayList.Add("Значение2");
            ArrayList.Add("Значение3");
            ArrayList.Add("Значение4");
            ArrayList.Add("Значение5");
            numbers.Add(new number(1, 2, 3, 4, 5));
            numbers.Add(new number(1, 3, 3, 4, 5));
            numbers.Add(new number(1, 4, 3, 4, 5));
            numbers.Add(new number(1, 4, 2, 4, 5));
            numbers.Add(new number(1, 5, 1, 4, 5));
            InitializeComponent();
            controlComboBoxSelected.LoadEnumeration(typeof(TestEnum));
            userControlSelect.List = ArrayList.ToArray();
            treeView1.Nodes.Add("Start");
            var node = treeView1.Nodes;
            foreach(var temp in numbers)
            {
                foreach(var num in temp.getArr())
                {
                    node = wft(node, num.ToString());
                }
                node = treeView1.Nodes;
            }
        }

        public TreeNodeCollection wft(TreeNodeCollection node, String text)
        {
            if (node.Count == 0)
            {
                node.Add(text);
                return node[0].Nodes;
            } 
            else
            {
                bool needNewNode = true;
                for(int i = 0; i < node.Count; i++)
                {
                    if (node[i].Text == text)
                    {
                        needNewNode = false;
                        break;
                    }
                }
                if (needNewNode)
                {
                    node.Add(text);
                    return node[node.Count-1].Nodes;
                }
            }

            return null;
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
