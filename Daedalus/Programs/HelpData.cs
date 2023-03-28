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
                "Manual/",
                "Daedalus"
            },
            {
                "Manual/Tabs/",
                "Located at the top of the window are three tabs:\n\n-Tower\n-Settings\n-Help\n\n"
            },
        };

        private static Dictionary<TreeNode, string> HelpTree = new Dictionary<TreeNode, string>();
        private static RichTextBox HelpTextBox = new RichTextBox();

        public static void PopulateManual(TreeView Tree, RichTextBox Text)
        {
            TreeNodeCollection Node = Tree.Nodes;
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
            Tree.SelectedNode = Tree.Nodes[0];
        }

        private static void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (HelpTree.ContainsKey(e.Node))
            {
                HelpTextBox.Text = HelpTree[e.Node];
            }
        }

        private static TreeNode GetNode(TreeNodeCollection Node, string Key)
        {
            string Item = Key.Split('/')[0];
            string NewKey = Key.Substring(Item.Length + 1);
            foreach (TreeNode item in Node)
            {
                if (item.Name.Equals(Item))
                {
                    if (string.IsNullOrEmpty(NewKey))
                        return item;
                    return GetNode(item.Nodes, NewKey);
                }
            }
            TreeNode NewNode = new TreeNode();
            NewNode.Name = Item;
            NewNode.Text = Item;
            Node.Add(NewNode);

            if (string.IsNullOrEmpty(NewKey))
                return NewNode;
            return GetNode(NewNode.Nodes, NewKey);
        }
    }
}
