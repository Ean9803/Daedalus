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
                "Daedalus\n\n" +
                "Made by:\n" +
                "Ian R. Poll\n" +
                "Fillip L. Cannard\n" +
                "Alexus A. Fry\n" +
                "James P. Clark\n" +
                "Sophia A. Rodrigue\n" +
                "Mohammed Hani Shaik\n" +
                "Veerain Arya Manchikanti\n\n" +
                "OBJECTIVE:\n" +
                "The objective of this project is to develop a program capable of pathfinding though an unknown environment\n\n" +
                "INSPERATION:\n" +
                "Named after the architect of the labyrinth, Daedalus is a pathfinding system made to navigate a \"labyrinth\" made by you, the user. " +
                "The system works in a similar way a person might navigate a maze. The subject navigating the labyrinth is the Minotaur, but we will call him Mino for short. " +
                "Mino works in two parts: one part scans the nearby environment and the other records and navigates though what Mino has seen. The main insperation for this project was " +
                "from the Project Lead, Ian Poll, who wanted to design a system that would be capable of quickly mapping an area similar to a scene in the movie \"Promethius\", where drones " +
                "would project light in a spherical shape and from the information gathered, was able to produce a mapped-out interior. The idea further developed into a pathfinding system which would use the data recorded " +
                "and the idea of Daedalus came to be.\n\n" +
                "MANUAL:\n" +
                "This is the help section of the application. On the left hand side of the application is an expandable hierarchy, which contains information on how to operatate this program. " +
                "When an element is clicked in the hierarchy, information pretaining to said element will be displayed here."
            },
            {
                "Manual/Tabs/",
                "Located at the top of the window are three tabs:\n\n-Tower\n-Settings\n-Help\n\nYou are currently on the "
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
