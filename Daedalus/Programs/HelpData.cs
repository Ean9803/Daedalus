using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Daedalus.Daedalus.Programs
{
    internal class HelpData
    {
        private static Dictionary<string, string> HelpText = new Dictionary<string, string>()
        {
            {
                "Manual",
                "Daedalus"
            },
        };

        private static Dictionary<TreeNode, string> HelpTree = new Dictionary<TreeNode, string>();
        private static RichTextBox HelpTextBox = new RichTextBox();

        public static void PopulateManual(TreeView Tree, RichTextBox Text)
        {
            TreeNode Node = Tree.Nodes[0];
            HelpTextBox = Text;
            foreach (KeyValuePair<string, string> item in HelpText)
            {
                TreeNode ItemNode = GetNode(Node, item.Key);
                if (HelpTree.ContainsKey(ItemNode))
                {
                    HelpTree[ItemNode] += item.Value;
                }
                else
                {
                    HelpTree.Add(ItemNode, item.Value);
                }
            }
            Tree.AfterSelect += Tree_AfterSelect;
            Tree.SelectedNode = Node;
        }

        private static void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (HelpTree.ContainsKey(e.Node))
            {
                HelpTextBox.Text = HelpTree[e.Node];
            }
        }

        private static TreeNode GetNode(TreeNode Node, string Key)
        {
            if (string.IsNullOrEmpty(Key))
            {
                return Node;
            }
            else
            {
                string Item = Key.Split('/')[0];
                TreeNode NewNode;
                if (Node.Name.Equals(Item))
                {
                    NewNode = Node;
                }
                else
                {
                    NewNode = new TreeNode();
                    Node.Parent.Nodes.Add(NewNode);
                    NewNode.Name = Item;
                    NewNode.Text = Item;
                }
                return GetNode(NewNode, Key.Substring(Item.Length));
            }
        }
    }
}
