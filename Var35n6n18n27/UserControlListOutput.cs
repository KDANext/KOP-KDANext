using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Var35n6n18n27
{
    public partial class UserControlListOutput : UserControl
    {
        private List<ITreeView> List { get; set; }
        private List<int> Order { get; set; }
        public UserControlListOutput()
        {
            InitializeComponent();
        }

        public void Add(ITreeView Element)
        {
            List.Add(Element);
            UpdateTree();
        }

        public void UpdateTree()
        {
            treeView.BeginUpdate();
            treeView.Nodes.Add("Start");
            var StartNode = treeView.Nodes[0];
            foreach(int i in Order)
            {
                foreach(var item in List)
                {
                    foreach(var tree in StartNode.Nodes)
                    {
                    }
                }
            }
        }
    }
}
