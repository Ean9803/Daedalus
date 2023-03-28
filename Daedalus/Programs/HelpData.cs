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
                "Veerain Arya Manchikanti\n" +
                "Mohammed Hani Shaik\n" +
                "Sophia A. Rodrigue\n" +
                "James P. Clark\n" +
                "Alexus A. Fry\n\n" +

                "OBJECTIVE:\n" +
                "The objective of this project is to develop a program capable of pathfinding though an unknown environment\n\n" +
                "INSPIRATION:\n" +
                "Named after the architect of the labyrinth, Daedalus is a pathfinding system made to navigate a \"labyrinth\" made by you, the user. " +
                "The system works in a similar way a person might navigate a maze. The subject navigating the labyrinth is the Minotaur, but we will call him Mino for short. " +
                "Mino works in two parts: one part scans the nearby environment and the other records and navigates though what Mino has seen. The main inspiration for this project was " +
                "from the Project Lead, Ian Poll, who wanted to design a system that would be capable of quickly mapping an area similar to a scene in the movie \"Promethius\", where drones " +
                "would project light in a spherical shape and from the information gathered, was able to produce a mapped-out interior. The idea further developed into a pathfinding system which would use the data recorded " +
                "and the idea of Daedalus came to be.\n\n" +
                "MANUAL:\n" +
                "This is the help section of the application. On the left hand side of the application is an expandable hierarchy, which contains information on how to operate this program. " +
                "When an element is clicked in the hierarchy, information pretaining to said element will be displayed here."
            },
            {
                "Manual/Tabs/",
                "Located at the top of the window are three tabs:\n\n" +
                "-Tower\n" +
                "-Settings\n" +
                "-Help\n\n" +
                "You are currently on the Help Tab. Tower and Settings control different aspects of how Mino can move and how information is processed."
            },
            {
                "Manual/Tabs/Tower/",
                "This is the main tab. In here the user is able to create/save blueprints. Each blueprint contains data about the user made labyrinth and map made from Mino."
            },
            {
                "Manual/Tabs/Tower/Tool_Box/",
                "Located at the top of the Tower tab, the Tool Box contains the various actions a user can make in this program. The Tool Box is split in two sections. The left hand side contains actions which can be performed in the " +
                "Labyrinth area and the right side contains the controls for the Mino and data displayed in the Map area.\n" +
                "-Labyrinth Tools:\n" +
                "(Left to Right) MinoPos, Draw, Erase, Save, Load, Clear\n\n" +
                "--MinoPos:\n" +
                "Sets the Mino (represented by a circle) to the current mouse position when left mouse button is pressed and continues to set the position until the left mouse button is released.\n\n" +
                "--Draw:\n" +
                "Creates a new wall in the Labyrinth starting at the position the mouse is at in the Labyrinth when the left mouse is pressed. As the button is held down, the user will be able to mose the cursor to " +
                "change where the end point is located. Wall creation ends when the left mouse is released and the new wall is added for observation by the Mino. The Mino cannot see a wall being made.\n\n" +
                "-Erase:\n" +
                "Will highlight a wall when the current mouse position is in the labyrinth and the mouse position is located within the bounds of said wall. When a wall is highlighted and the user uses the left mouse, " +
                "the highlighted wall will be removed from the Labyrinth. NOTE: Information about the deleted wall will remain in the Mino's memory until the Mino sees that the wall is missing.\n\n" +
                "--Save:\n" +
                "Will prompt the user to enter a file name and navigate to a directory where the blueprint file will be saved at.\n\n" +
                "--Load:\n" +
                "Will prompt the user to select a file with the blueprint extension and when a valid file is selected, will clear the exising Labyrinth and Map data and replace it with the file's contents.\n\n" +
                "--Clear:\n" +
                "Erases all Labyrith walls, works the same way as erase, so the Mino will retain the wall information until it sees that the wall no longer exists."
            },
            {
                "Manual/Tabs/Tower/Labyrinth/",
                "In Progress"
            },
            {
                "Manual/Tabs/Tower/Map/",
                "In Progress"
            },
            {
                "Manual/Tabs/Tower/Zoom/",
                "In Progress"
            },
            {
                "Manual/Tabs/Settings/",
                "In this tab properites can be chaged which effect color, Mino, what data will be displayed on the map, and extra settings for people with color blindness."
            },
            {
                "Manual/Tabs/Settings/Visual/",
                "In Progress"
            },
            {
                "Manual/Tabs/Settings/Display/",
                "In Progress"
            },
            {
                "Manual/Tabs/Settings/Internal/",
                "In Progress"
            },
            {
                "Manual/Tabs/Settings/Reset/",
                "Resets settings to default values."
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
