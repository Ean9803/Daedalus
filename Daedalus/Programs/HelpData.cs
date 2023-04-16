using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

                "[TITLE]\n" +
                "[ROTATE]\n" +
                "Made by:\n" +
                "Ian R. Poll\n" +
                "Fillip L. Cannard\n" +
                "Veerain Arya Manchikanti\n" +
                "Mohammed Hani Shaik\n" +
                "Sophia A. Rodrigue\n" +
                "James P. Clark\n\n" +

                "OBJECTIVE:\n" +
                "The objective of this project is to develop a program capable of pathfinding though an unknown environment\n\n" +
                "INSPIRATION:\n" +
                "Named after the architect of the labyrinth, Daedalus is a pathfinding system made to navigate a \"labyrinth\" made by you, the user. " +
                "The system works in a similar way a person might navigate a maze. The subject navigating the labyrinth is the Minotaur, but we will call him Mino for short. " +
                "Mino works in two parts: one part scans the nearby environment and the other records and navigates though what Mino has seen. The main inspiration for this project was " +
                "from the Project Lead, Ian Poll, who wanted to design a system that would be capable of quickly mapping an area similar to a scene in the movie \"Prometheus\", where drones " +
                "would project light in a spherical shape and from the information gathered, was able to produce a mapped-out interior. The idea further developed into a pathfinding system which would use the data recorded " +
                "and the idea of Daedalus came to be.\n\n" +
                "MANUAL:\n" +
                "This is the help section of the application. On the left hand side of the application is an expandable hierarchy, which contains information on how to operate this program. " +
                "When an element is clicked in the hierarchy, information pertaining to said element will be displayed here."
            },
            {
                "Manual/Tabs/",

                "Located at the top of the window are three tabs:\n\n" +
                "\r\n  _____                     _   ___      _   _   _                _   _  _     _      \r\n |_   _|____ __ _____ _ _  | | / __| ___| |_| |_(_)_ _  __ _ ___ | | | || |___| |_ __ \r\n   | |/ _ \\ V  V / -_) '_| | | \\__ \\/ -_)  _|  _| | ' \\/ _` (_-< | | | __ / -_) | '_ \\\r\n   |_|\\___/\\_/\\_/\\___|_|   | | |___/\\___|\\__|\\__|_|_||_\\__, /__/ | | |_||_\\___|_| .__/\r\n                           |_|                         |___/     |_|            |_|   \r\n\n\n" +
                "You are currently on the Help Tab. Tower and Settings control different aspects of how Mino can move and how information is processed."
            },
            {
                "Manual/Tabs/Tower/",
                "\n[TOWER]\n\n" +
                "This is the main tab. In here the user is able to create/save blueprints. Each blueprint contains data about the user made labyrinth and map made from Mino."
            },
            {
                "Manual/Tabs/Tower/Tool_Box/",
                "\n{TOOLS}\n\n" +
                "Located at the top of the Tower tab, the Tool Box contains the various actions a user can make in this program. The Tool Box is split in two sections. The left hand side contains actions which can be performed in the " +
                "Labyrinth area and the right side contains the controls for the Mino and data displayed in the Map area.\n" +
                "-Labyrinth Tools:\n" +
                "(Left to Right) MinoPos, Draw, Erase, Save, Load, Clear\n" +
                "Located on the far right of the Labyrinth's tool bar is text which changes based on the active tool selected.\n\n" +
                "--MinoPos:\n" +
                "Sets the Mino (represented by a circle) to the current mouse position when left mouse button is pressed and continues to set the position until the left mouse button is released.\n\n" +
                "--Draw:\n" +
                "Creates a new wall in the Labyrinth starting at the position the mouse is at in the Labyrinth when the left mouse is pressed. As the button is held down, the user will be able to move the cursor to " +
                "change where the end point is located. Wall creation ends when the left mouse is released and the new wall is added for observation by the Mino. The Mino cannot see a wall being made.\n\n" +
                "-Erase:\n" +
                "Will highlight a wall when the current mouse position is in the labyrinth and the mouse position is located within the bounds of said wall. When a wall is highlighted and the user uses the left mouse, " +
                "the highlighted wall will be removed from the Labyrinth. NOTE: Information about the deleted wall will remain in the Mino's memory until the Mino sees that the wall is missing.\n\n" +
                "--Save:\n" +
                "Will prompt the user to enter a file name and navigate to a directory where the blueprint file will be saved at.\n\n" +
                "--Load:\n" +
                "Will prompt the user to select a file with the blueprint extension and when a valid file is selected, will clear the existing Labyrinth and Map data and replace it with the file's contents.\n\n" +
                "--Clear:\n" +
                "Erases all Labyrinth walls, works the same way as erase, so the Mino will retain the wall information until it sees that the wall no longer exists.\n\n\n" +
                "-Map Tools:\n" +
                "(Left to Right) Play/Stop, Clear Memory, Roam, Target\n" +
                "Located on the far right of the Map's tool bar is text which changes based on the active mode the Mino is in, Roam or Target.\n\n" +
                "-Play/Stop:\n" +
                "Activates or deactivates the Mino. When the Mino is active, the Mino will scan the nearby environment and will add or delete data from the Map.\n\n" +
                "-Clear Memory:\n" +
                "Clears the Mino's memory of the environment and clears objects displayed in the Map area.\n\n" +
                "-Roam:\n" +
                "Sets the Mino to the Roam state. In Roam state, the Mino will navigate to areas which are undiscovered.\n\n" +
                "-Target:\n" +
                "Sets the Mino to the Target state. In Target state, the Mino will navigate to a selected point by the user or to a point closest to it.\n\n\n" +
                "The size of the Tool Box can also be changed vertically. A divider is located between the Tool Box area and the Labyrinth and Map area. When the mouse cursor is over the divider, " +
                "the mouse cursor sprite will change. When the Left Mouse is held and dragged, the divider will follow the mouse and change the size of the Tool Box."
            },
            {
                "Manual/Tabs/Tower/Labyrinth/",
                "\n{MAZE}\n\n" +
                "The Labyrinth is the area of the application which displays the environment from a top down view. In this area the user is able to create/erase walls and move the Mino position with the use of the Tool Box. " +
                "While the mouse cursor is in the Labyrinth area, the user is able to pan the current view by holding down Right Mouse and dragging the cursor. Pan also works the same way in the Map. NOTE: Both views, Labyrinth and Map, " +
                "will be moved when panned so the Labyrinth view and Map view match.\n" +
                "A divider is located between the Labyrinth and Map area. When the mouse cursor is over the divider, " +
                "the mouse cursor sprite will change. When the Left Mouse is held and dragged, the divider will follow the mouse and change the size of the Labyrinth and Map areas."
            },
            {
                "Manual/Tabs/Tower/Map/",
                "\n[MAZE]\n\n" +
                "The Map is the area of the application which displays the Mino's view of the environment from a top down view. In this area the user is able to set the Mino's Target destination with the use of the Tool Box. " +
                "While the mouse cursor is in the Map area, the user is able to pan the current view by holding down Right Mouse and dragging the cursor. Pan also works the same way in the Labyrinth. NOTE: Both views, Labyrinth and Map, " +
                "will be moved when panned so the Labyrinth view and Map view match.\n" +
                "A divider is located between the Labyrinth and Map area. When the mouse cursor is over the divider, " +
                "the mouse cursor sprite will change. When the Left Mouse is held and dragged, the divider will follow the mouse and change the size of the Labyrinth and Map areas."
            },
            {
                "Manual/Tabs/Tower/Zoom/",
                "\n[ZOOM]\n\n" +
                "The Zoom control is located at the bottom of the application. The control is a slider which can be dragged left and right. " +
                "Dragging the control left will increase the view area shown. Dragging it right will decrease the area shown. " +
                "A divider is located between the Zoom area and the Labyrinth and Map area. When the mouse cursor is over the divider, " +
                "the mouse cursor sprite will change. When the Left Mouse is held and dragged, the divider will follow the mouse and change the size of the Zoom control."
            },
            {
                "Manual/Tabs/Settings/",
                "\n[GEAR]\n\n" +
                "In Settings tab, properties can be changed which effect color, Mino, what data will be displayed on the map, and extra settings for people with color blindness.\n" +
                "In the Settings section of the application, located on the left hand side of the application is an expandable hierarchy, which contains settings which can be customized by the user. " +
                "When an element is clicked in the hierarchy, information pertaining to said element will be displayed.\n" +
                "The main settings are:\n" +
                "-Visual => Contains settings related to colors shown, this can be expanded to show three profiles that can be applied for people with color blindness\n" +
                "-Display => Contains settings related to what information is displayed in the Map area\n" +
                "-Internal => Contains settings to change how data is collected and processed to generate a path from Mino to Target\n"
            },
            {
                "Manual/Tabs/Settings/Visual/",
                "\n{EYE}\n\n" +
                "This section contains settings for the color that is displayed. Each color is labeled with a name which describes what item will be set to the color and a change button which, when pressed, will open a color prompt to change the color.\n" +
                "Settings that can be changed:\n" +
                "-Labyrinth Map Color:\n" +
                "Sets the color of the walls displayed in the Labyrinth area.\n\n" +
                "-Labyrinth Highlight Color:\n" +
                "Is the color a wall in the process of being set is colored to and when a wall is selected to be erased.\n\n" +
                "-Mino Color:\n" +
                "The color of the Mino in both the Labyrinth and Map area. This is also the color of non-explored chunks the Mino is in that are displayed in the Map area.\n\n" +
                "-Non-Hit Point Color:\n" +
                "The color of end points and the rays that do not collide with the Labyrinth walls which are displayed in the Map area.\n\n" +
                "-Ray Line Color:\n" +
                "The color of the rays that do collide with the Labyrinth walls which are displayed in the Map area. NOTE: The color of collided points are set to rainbow and cannot be changed because it looks too cool.\n\n" +
                "-Map Object Color:\n" +
                "The color of objects the Mino recognizes from detecting the Labyrinth.\n\n" +
                "-Map Chunk Color:\n" +
                "The color of the grid of chunks which divide the map into squares for optimized performance.\n\n" +
                "-Map Wall Color:\n" +
                "The color of the raw data the Mino is collecting from detections with the Labyrinth.\n\n" +
                "\n\n" +
                "Within the Visual section are profiles which, when selected, will present a prompt to apply the assigned color profile."
            },
            {
                "Manual/Tabs/Settings/Display/",
                "\n{DISPLAY}\n\n" +
                "This section contains settings for what data is displayed. Each setting is labeled with a name which describes what item will be set to display.\n" +
                "Settings that can be changed:\n" +
                "-Collided Points:\n" +
                "Sets if the points that collide with the Labyrinth are displayed.\n\n" +
                "-UnCollided Points:\n" +
                "Sets if the points that do not collide with the Labyrinth are displayed.\n\n" +
                "-Current Target:\n" +
                "Sets if the point that the Mino will navigate to is displayed.\n\n" +
                "-Roam Target:\n" +
                "Sets if the points that the Mino need to explore when in Roam mode are displayed.\n\n" +
                "-User Target:\n" +
                "Sets if the point that is set by the user that the Mino will navigate to when in Target mode is displayed.\n\n" +
                "-Target Path:\n" +
                "Sets if the path the Mino is taking to its target point is displayed.\n\n" +
                "-Map Object Radius:\n" +
                "Sets the maximum range that Objects the Mino knows exist are displayed.\n\n" +
                "-Map Chunk Radius:\n" +
                "Sets the how much extra range is needed for Chunks the Mino knows exist are displayed. NOTE: The range that chunks are displayed is the Object radius PLUS this setting value. \n\n" +
                "-Non-Hit Rays:\n" +
                "Sets if the line connecting the Mino to a point that did not collide with the Labyrinth is displayed.\n\n" +
                "-Hit Rays:\n" +
                "Sets if the line connecting the Mino to a point that did collide with the Labyrinth is displayed.\n\n" +
                "-Wall Data:\n" +
                "Sets if the raw data the Mino has collected from detections is displayed.\n\n" +
                "\n\n"
            },
            {
                "Manual/Tabs/Settings/Internal/",
                "\n{ENGINE}\n\n" +
                "This section contains settings for how data is processed in Daedalus. Each setting is labeled with a name which describes what variable will be set.\n" +
                "Settings that can be changed:\n\n" +
                "-Mino Radius:\n" +
                "Sets the radius of the Mino and the minimum distance the Mino can be near a wall it detects.\n\n" +
                "-A* Iterations:\n" +
                "Maximum amount of iterations made to find a path from the Mino to the target point.\n\n" +
                "-Wall Simplification:\n" +
                "The maximum distance between vertices where they would merge together. Distance = [1 / (50 / value)]\n\n" +
                "-Object Expansion Bias:\n" +
                "Sets an additional value to the radius of the Mino when doing calculations, this does not affect the Mino size, but it does affect the minimum distance the Mino can be near a wall.\n\n" +
                "-Grid Radius:\n" +
                "Sets the Chunk radius. This radius controls how much is displayed to the screen and how detailed the path the Mino will take to is destination.\n\n" +
                "-Mino Ray Count:\n" +
                "Sets the amount of rays emitted from the Mino position. Each ray contributes to how detailed the Mino will see its surroundings.\n\n" +
                "-Mino Speed:\n" +
                "Sets how fast the Mino will travel along its calculated path.\n\n" +
                "-Mino View Distance:\n" +
                "Sets how far the Mino can see its surroundings.\n\n" +
                "\n\n"
            },
            {
                "Manual/Tabs/Settings/Environment/",

                "This contains the setting which controls the width a newly created wall will have. This does not affect previous walls made.\n\n" +
                "[WALLDEMO]"
            },
            {
                "Manual/Tabs/Settings/Reset/",

                "Resets settings to default values."
            },
        };

        private static Dictionary<TreeNode, string> HelpTree = new Dictionary<TreeNode, string>();
        private static RichTextBox HelpTextBox = new RichTextBox();
        private static string DisplayText = "\n\n";
        private static float Frame = 0;
        private const int Rate = 10;
        private static float TimeFrame;
        private static int MaxFrames = 100;
        private static int Clock = 0;
        private static bool UpdateFrame = true;
        private static string BUFFER = "BUFFER=";

        private static Dictionary<string, string> Images = new Dictionary<string, string>()
        {
            {
                "MAZE",
                "___________________________________  \r\n" +
                "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                "| | | |_________|__ |______ |___|_| |\r\n" +
                "| |_|   | _______ |______ |   | ____|\r\n" +
                "| ___ | |____ | |______ | |_| |____ |\r\n" +
                "|___|_|____ | |   ___ | |________ | |\r\n" +
                "|   ________| | |__ | |______ | | | |\r\n" +
                "| | | ________| | __|____ | | | __| |\r\n" +
                "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                "| |_______|_______|___|___|___|_____|"
            },
            {
                "EYE",
                "                                         @@@@@@@@@@@@@@@@@@&                                        \r\n" +
                "                                   @@@@@@@@@@@@@(,.,#@@@@@@@@@@@@#                                  \r\n" +
                "                               @@@@@@@@                      .@@@@@@@&                              \r\n" +
                "                            @@@@@@@          (@@@@@@@@@@          @@@@@@@                           \r\n" +
                "                         @@@@@@                @@@@@@@@@@@            @@@@@@                        \r\n" +
                "                       @@@@@*             @  #@@@@@@@@@@@@@             &@@@@@                      \r\n" +
                "                       @@@@@.             @@@@@@@@@@@@@@@@@             (@@@@@                      \r\n" +
                "                         @@@@@@            @@@@@@@@@@@@@@@            @@@@@@                        \r\n" +
                "                            @@@@@@%          @@@@@@@@@@@          @@@@@@@                           \r\n" +
                "                               @@@@@@@@                       @@@@@@@@                              \r\n" +
                "                                   @@@@@@@@@@@@%,   ,%@@@@@@@@@@@@                                  \r\n" +
                "                                         @@@@@@@@@@@@@@@@@@@                                        "
            },
            {
                "TOOLS",
                "                                        .#%%%%%%%%%%%%%%%#                                          \r\n" +
                "                                  #%%%%%%%%%%%%%#*.                                                 \r\n" +
                "                               #%%%%%%%%%%%%#                          .,*,.                        \r\n" +
                "                            .%%%%%%%%%%%%%#                        #%%%%%%.                         \r\n" +
                "                          #%%%%%%%%%%%%%%%*                      %%%%%%(                            \r\n" +
                "                          (%%%%%%%%%%%%%%%%%.                   %%%%%%,                             \r\n" +
                "                     .   ,%%%%%%%%%%%%%%%%%(                   ,%%%%%%%%         %%#                \r\n" +
                "                  ,%%%%%%%%%%%%%%%%%%%%%%.   .%.                %%%%%%%%%%/   *%%%%*                \r\n" +
                "                 %%%%%%%%%%%%#    %%%%(    #%%%%%%            ,%%%%%%%%%%%%%%%%%%%/                 \r\n" +
                "                  /%%%%%%%%%%(          .%%%%%%%%%%%/       #%%%%%%%%%%%%%%%%%%%/                   \r\n" +
                "                     %%%%%%%%.           #%%%%%%%%%%%*   ,%%%%%%%%%%%%/*(#(/.                       \r\n" +
                "                       /%%(                /%%%%%%%    #%%%%%%%%%%%*                                \r\n" +
                "                                             .%%*   ,%%%%%%%%%%%%                                   \r\n" +
                "                                                  #%%%%%%%%%%%*                                     \r\n" +
                "                                               ,%%%%%%%%%%%%    ##                                  \r\n" +
                "                                             #%%%%%%%%%%%/   ,%%%%%%*                               \r\n" +
                "                                          *%%%%%%%%%%%%    #%%%%%%%%%%%                             \r\n" +
                "                                #%%%%%%%%%%%%%%%%%%%*    ,%%%%%%%%%%%%%%%(                          \r\n" +
                "                              %%%%%%%%%%%%%%%%%%%#          %%%%%%%%%%%%%%%%,                       \r\n" +
                "                             %%%%%.  %%%%%%%%%%%.             (%%%%%%%%%%%%%%%%                     \r\n" +
                "                            (%%(        %%%%%%%%(               ,%%%%%%%%%%%%%%%%(                  \r\n" +
                "                            .            .%%%%%%.                  %%%%%%%%%%%%%%%%*                \r\n" +
                "                                         %%%%%%,                     /%%%%%%%%%%%%%(                \r\n" +
                "                                      /%%%%%%/                         .%%%%%%%%%%,                 \r\n" +
                "                                    %%%%#,                                (%%%%#                    "
            },
            {
                "DISPLAY",
                "                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@(               \r\n" +
                "                @@%                                                               @@(               \r\n" +
                "                @@%                                                               @@(               \r\n" +
                "                @@%                                                               @@(               \r\n" +
                "                @@%                                                               @@(               \r\n" +
                "                @@%                                                               @@(               \r\n" +
                "                @@%                                                               @@(               \r\n" +
                "                @@%                                                               @@(               \r\n" +
                "                @@%                                                               @@(               \r\n" +
                "                @@%                                                               @@(               \r\n" +
                "                @@%                                                               @@(               \r\n" +
                "                @@%                                                               @@(               \r\n" +
                "                @@%                                                               @@(               \r\n" +
                "                @@%                                                               @@(               \r\n" +
                "                @@%                                                               @@(               \r\n" +
                "                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@(               \r\n" +
                "                ********************************************************************,               \r\n" +
                "                ********************************************************************,               \r\n" +
                "                                           /(((((((((((((*                                          \r\n" +
                "                                         .(((((((((((((((((                                         \r\n" +
                "                                 *#################################                                 "
            },
            {
                "ENGINE",
                "                           ************************************                                     \r\n" +
                "                                      ***************                                               \r\n" +
                "                          ............***************...........                                    \r\n" +
                "                        ,*****************************************                                  \r\n" +
                "                        ,*******,***************,*****************                                  \r\n" +
                "               ,*************,                              .***********        ,**********         \r\n" +
                "       .*****  ,*************                                ************      ,***********,        \r\n" +
                "       .*****  ,****,                                               ,*****    .*****  .*****        \r\n" +
                "       .*****  ,****,                                                *****.   *****    *****        \r\n" +
                "       .*****  ,****,                                                .************.    *****,       \r\n" +
                "       .*****  ,****,                                                 ,**********,     ,*****       \r\n" +
                "       .************,                                                                   *****       \r\n" +
                "       .************,                                                                   *****       \r\n" +
                "       .*****  ,****,                                                                   *****       \r\n" +
                "       .*****  ,****,                                                                   *****       \r\n" +
                "       .*****  ,****,                                                                   *****       \r\n" +
                "       .*****  ,****,                                                                   *****       \r\n" +
                "       .*****  ,*************,                                        ,***********     .*****       \r\n" +
                "                ***************,                                      ************,    *****,       \r\n" +
                "                           ******.                                   *****.   *****.   *****.       \r\n" +
                "                             ******                                 ,*****    .*****   *****        \r\n" +
                "                              .******************************************      ,***********,        \r\n" +
                "                                .***************************************.       ,**********         "
            }
        };

        private static Dictionary<string, List<string>> Animations = new Dictionary<string, List<string>>()
        {
            {
                "ROTATE",
                new List<string>
                {
                    "-",
                    "\\",
                    "|",
                    "/"
                }
            },
            {
                "MAZE",
                new List<string>
                {
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "           X                         \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "|@|                                  ",
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "           X                         \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    " _                                   \r\n" +
                    "|@                                   \r\n" +
                    "| |                                  ",
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "           X                         \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    " _|                                  \r\n" +
                    "| @                                  \r\n" +
                    "| |                                  ",
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "           X                         \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    " _|                                  \r\n" +
                    "|  @_                                \r\n" +
                    "| |                                  ",
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "           X                         \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    " _|@|                                \r\n" +
                    "|   _                                \r\n" +
                    "| |                                  ",
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "           X                         \r\n" +
                    "                                     \r\n" +
                    "  |@|                                \r\n" +
                    " _| |                                \r\n" +
                    "|   _                                \r\n" +
                    "| |                                  ",
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "   _       X                         \r\n" +
                    "   @_                                \r\n" +
                    "  | |                                \r\n" +
                    " _| |                                \r\n" +
                    "|   _                                \r\n" +
                    "| |                                  ",
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "   __      X                         \r\n" +
                    "    @_                               \r\n" +
                    "  | |                                \r\n" +
                    " _| |                                \r\n" +
                    "|   _                                \r\n" +
                    "| |                                  ",
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "   ___     X                         \r\n" +
                    "    _@                               \r\n" +
                    "  | |                                \r\n" +
                    " _| |                                \r\n" +
                    "|   _                                \r\n" +
                    "| |                                  ",
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "   ____    X                         \r\n" +
                    "    __@                              \r\n" +
                    "  | |                                \r\n" +
                    " _| |                                \r\n" +
                    "|   _                                \r\n" +
                    "| |                                  ",
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "   _____   X                         \r\n" +
                    "    ___@                             \r\n" +
                    "  | |                                \r\n" +
                    " _| |                                \r\n" +
                    "|   _                                \r\n" +
                    "| |                                  ",
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "   ______  X                         \r\n" +
                    "    ____@                            \r\n" +
                    "  | |                                \r\n" +
                    " _| |                                \r\n" +
                    "|   _                                \r\n" +
                    "| |                                  ",
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "   _______ X                         \r\n" +
                    "    _____@                           \r\n" +
                    "  | |                                \r\n" +
                    " _| |                                \r\n" +
                    "|   _                                \r\n" +
                    "| |                                  ",
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "   ________X                         \r\n" +
                    "    ______@                          \r\n" +
                    "  | |                                \r\n" +
                    " _| |                                \r\n" +
                    "|   _                                \r\n" +
                    "| |                                  ",
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "   ________X                         \r\n" +
                    "    _______@|                        \r\n" +
                    "  | |                                \r\n" +
                    " _| |                                \r\n" +
                    "|   _                                \r\n" +
                    "| |                                  ",
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "                                     \r\n" +
                    "           __                        \r\n" +
                    "   ________@|                        \r\n" +
                    "    ________|                        \r\n" +
                    "  | |                                \r\n" +
                    " _| |                                \r\n" +
                    "|   _                                \r\n" +
                    "| |                                  ",
                }
            },
            {
                "ZOOM",
                new List<string>
                {
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)==============|!|==============(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)=============|!|===============(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)============|!|================(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)===========|!|=================(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)==========|!|==================(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)=========|!|===================(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)==========|!|==================(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)===========|!|=================(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)============|!|================(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)=============|!|===============(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)==============|!|==============(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)===============|!|=============(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)================|!|============(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)=================|!|===========(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)==================|!|==========(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)=================|!|===========(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)================|!|============(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)===============|!|=============(+)\r\n" +
                    "-------------------------------------",
                    "___________________________________  \r\n" +
                    "| _____ |   | ___ | ___ ___ | |   | |\r\n" +
                    "| |   | |_| |__ | |_| __|____ | | | |\r\n" +
                    "| | | |_________|__ |______ |___|_| |\r\n" +
                    "| |_|   | _______ |______ |   | ____|\r\n" +
                    "| ___ | |____ | |______ | |_| |____ |\r\n" +
                    "|___|_|___ DAEDALUS WINDOW_______ | |\r\n" +
                    "|   ________| | |__ | |______ | | | |\r\n" +
                    "| | | ________| | __|____ | | | __| |\r\n" +
                    "|_| |__ |   | __|__ | ____| | |_| __|\r\n" +
                    "|   ____| | |____ | |__ |   |__ |__ |\r\n" +
                    "| |_______|_______|___|___|___|_____|\r\n" +
                    "-------------------------------------\r\n" +
                    "(-)==============|!|==============(+)\r\n" +
                    "-------------------------------------",
                }
            },
            {
                "TOWER",
                new List<string>
                {
                    "                                                |=>=\r\n" +
                    "                                                |\r\n" +
                    "                                            _  _|_  _\r\n" +
                    "                                           |;|_|;|_|;|\r\n" +
                    "                                           \\\\.    .  /\r\n" +
                    "                                            \\\\:  .  /\r\n" +
                    "                                             ||:   |\r\n" +
                    "                                             ||:.  |\r\n" +
                    "                                             ||:  .|\r\n" +
                    "                                             ||:   |       \\,/\r\n" +
                    "                                             ||: , |            /`\\\r\n" +
                    "                                             ||:   |\r\n" +
                    "                                             ||: . |\r\n" +
                    "              __                            _||_   |\r\n" +
                    "     ____--`~    '--~~__            __ ----~    ~`---,              ___\r\n" +
                    "-~--~                   ~---__ ,--~'                  ~~----_____-~'   `~----~~",
                    "BUFFER=0",
                    "BUFFER=0",
                    "BUFFER=0",
                    "BUFFER=0",
                    "                                                |>=>\r\n" +
                    "                                                |\r\n" +
                    "                                            _  _|_  _\r\n" +
                    "                                           |;|_|;|_|;|\r\n" +
                    "                                           \\\\.    .  /\r\n" +
                    "                                            \\\\:  .  /\r\n" +
                    "                                             ||:   |\r\n" +
                    "                                             ||:.  |\r\n" +
                    "                                             ||:  .|\r\n" +
                    "                                             ||:   |       /'\\\r\n" +
                    "                                             ||: , |            \\,/\r\n" +
                    "                                             ||:   |\r\n" +
                    "                                             ||: . |\r\n" +
                    "              __                            _||_   |\r\n" +
                    "     ____--`~    '--~~__            __ ----~    ~`---,              ___\r\n" +
                    "-~--~                   ~---__ ,--~'                  ~~----_____-~'   `~----~~",
                    "BUFFER=5",
                    "BUFFER=5",
                    "BUFFER=5",
                    "BUFFER=5",
                    "BUFFER=5",
                    "BUFFER=5",
                }
            },
            {
                "TITLE",
                new List<string>
                {
                    "\r\n" +
                    " ______   ________   ______   ______   ________   __       __  __   ______      \r\n" +
                    "/_____/\\ /_______/\\ /_____/\\ /_____/\\ /_______/\\ /_/\\     /_/\\/_/\\ /_____/\\     \r\n" +
                    "\\:::_ \\ \\\\::: _  \\ \\\\::::_\\/_\\:::_ \\ \\\\::: _  \\ \\\\:\\ \\    \\:\\ \\:\\ \\\\::::_\\/_    \r\n" +
                    " \\:\\ \\ \\ \\\\::(_)  \\ \\\\:\\/___/\\\\:\\ \\ \\ \\\\::(_)  \\ \\\\:\\ \\    \\:\\ \\:\\ \\\\:\\/___/\\   \r\n" +
                    "  \\:\\ \\ \\ \\\\:: __  \\ \\\\::___\\/_\\:\\ \\ \\ \\\\:: __  \\ \\\\:\\ \\____\\:\\ \\:\\ \\\\_::._\\:\\  \r\n" +
                    "   \\:\\/.:| |\\:.\\ \\  \\ \\\\:\\____/\\\\:\\/.:| |\\:.\\ \\  \\ \\\\:\\/___/\\\\:\\_\\:\\ \\ /____\\:\\ \r\n" +
                    "    \\____/_/ \\__\\/\\__\\/ \\_____\\/ \\____/_/ \\__\\/\\__\\/ \\_____\\/ \\_____\\/ \\_____\\/ \r\n" +
                    "                                                                                \r\n",
                    "\r\n" +
                    " ______   ________   ______   ______   ________   __       __  __   ______      \r\n" +
                    "/_____/\\ /_______/\\ /_____/\\ /_____/\\ /_______/\\ /_/\\     /_/\\/_/\\ /_____/\\     \r\n" +
                    "\\:*:_ \\ \\\\*:: _  \\ \\\\::*:_\\/_\\:*:_ \\ \\\\:*: _  \\ \\\\:\\ \\    \\:\\ \\*\\ \\\\:*::_\\/_    \r\n" +
                    " \\:\\ \\ \\ \\\\*:(_)  \\ \\\\:\\/___/\\\\:\\ \\ \\ \\\\::(_)  \\ \\\\:\\ \\    \\:\\ \\:\\ \\\\:\\/___/\\   \r\n" +
                    "  \\*\\ \\ \\ \\\\:: __  \\ \\\\:*___\\/_\\:\\ \\ \\ \\\\:* __  \\ \\\\*\\ \\____\\:\\ \\*\\ \\\\_:*._\\*\\  \r\n" +
                    "   \\:\\/.*| |\\:.\\ \\  \\ \\\\:\\____/\\\\*\\/.*| |\\*.\\ \\  \\ \\\\:\\/___/\\\\*\\_\\:\\ \\ /____\\:\\ \r\n" +
                    "    \\____/_/ \\__\\/\\__\\/ \\_____\\/ \\____/_/ \\__\\/\\__\\/ \\_____\\/ \\_____\\/ \\_____\\/ \r\n" +
                    "                                                                                \r\n",
                    "\r\n" +
                    " ______   ________   ______   ______   ________   __       __  __   ______      \r\n" +
                    "/_____/\\ /_______/\\ /_____/\\ /_____/\\ /_______/\\ /_/\\     /_/\\/_/\\ /_____/\\     \r\n" +
                    "\\*::_ \\ \\\\::: _  \\ \\\\*:::_\\/_\\::*_ \\ \\\\::* _  \\ \\\\:\\ \\    \\:\\ \\:\\ \\\\:::*_\\/_    \r\n" +
                    " \\*\\ \\ \\ \\\\:*(_)  \\ \\\\:\\/___/\\\\:\\ \\ \\ \\\\::(_)  \\ \\\\:\\ \\    \\:\\ \\:\\ \\\\:\\/___/\\   \r\n" +
                    "  \\:\\ \\ \\ \\\\*: __  \\ \\\\::___\\/_\\*\\ \\ \\ \\\\*: __  \\ \\\\*\\ \\____\\*\\ \\:\\ \\\\_::._\\:\\  \r\n" +
                    "   \\:\\/.:| |\\*.\\ \\  \\ \\\\:\\____/\\\\:\\/.:| |\\:.\\ \\  \\ \\\\:\\/___/\\\\:\\_\\:\\ \\ /____\\*\\ \r\n" +
                    "    \\____/_/ \\__\\/\\__\\/ \\_____\\/ \\____/_/ \\__\\/\\__\\/ \\_____\\/ \\_____\\/ \\_____\\/ \r\n" +
                    "                                                                                \r\n",
                    "\r\n" +
                    " ______   ________   ______   ______   ________   __       __  __   ______      \r\n" +
                    "/_____/\\ /_______/\\ /_____/\\ /_____/\\ /_______/\\ /_/\\     /_/\\/_/\\ /_____/\\     \r\n" +
                    "\\::*_ \\ \\\\**: _  \\ \\\\::::_\\/_\\*:*_ \\ \\\\:*: _  \\ \\\\:\\ \\    \\*\\ \\:\\ \\\\**::_\\/_    \r\n" +
                    " \\:\\ \\ \\ \\\\::(_)  \\ \\\\:\\/___/\\\\:\\ \\ \\ \\\\::(_)  \\ \\\\:\\ \\    \\:\\ \\:\\ \\\\:\\/___/\\   \r\n" +
                    "  \\:\\ \\ \\ \\\\:* __  \\ \\\\:*___\\/_\\:\\ \\ \\ \\\\:: __  \\ \\\\*\\ \\____\\*\\ \\:\\ \\\\_:*._\\*\\  \r\n" +
                    "   \\*\\/.:| |\\:.\\ \\  \\ \\\\:\\____/\\\\:\\/*:| |\\:.\\ \\  \\ \\\\:\\/___/\\\\:\\_\\:\\ \\ /____\\:\\ \r\n" +
                    "    \\____/_/ \\__\\/\\__\\/ \\_____\\/ \\____/_/ \\__\\/\\__\\/ \\_____\\/ \\_____\\/ \\_____\\/ \r\n" +
                    "                                                                                \r\n",
                }
            },
            {
                "GEAR",
                new List<string>
                {
                    "                                                  \r\n" +
                    "                  @@.  @@/  @@   @@               \r\n" +
                    "             ,@@@@@@@@@@@@@@@@@@@@@   @#          \r\n" +
                    "         @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@           \r\n" +
                    "      @& *@@@@@@       @@@@@       @@@@@@@@       \r\n" +
                    "       @@@@@@          @@@@@          @@@@@@@@#   \r\n" +
                    "   @@@@@@@@@@          @@@@@          @@@@@@@     \r\n" +
                    "     @@@@@@@@@@@@. @@@@@@@@@@@@@ *@@@@@@@@@@@@@@@ \r\n" +
                    " #@@@@@@*   @@@@@@@@@        .@@@@@@@@@   %@@@@   \r\n" +
                    "    @@@@        @@@*           (@@@        @@@@@@@\r\n" +
                    " @@@@@@@        @@@             @@@        @@@@   \r\n" +
                    "    @@@@        @@@/           %@@@        @@@@@@@\r\n" +
                    " (@@@@@@#   @@@@@@@@@,       (@@@@@@@@@   &@@@@   \r\n" +
                    "     @@@@@@@@@@@@  @@@@@@@@@@@@@  @@@@@@@@@@@@@@@ \r\n" +
                    "   @@@@@@@@@@          @@@@@          @@@@@@@     \r\n" +
                    "       @@@@@@          @@@@@          @@@@@#@@/   \r\n" +
                    "      @,  @@@@@@       @@@@@       @@@@@@@@       \r\n" +
                    "         @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@           \r\n" +
                    "             *@@/@@@@@@@@@@@@@@@@@@   @,          \r\n" +
                    "                  @@   @@*  @@   @@               ",
                    "                                                  \r\n" +
                    "                 @@   @@.  @@   @@                \r\n" +
                    "            @@@ .@@@@@@@@@@@@@@@@@  @@@           \r\n" +
                    "        &@& #@@@@@@@@@#./@@@@@@@@@@@@@* ,@/       \r\n" +
                    "         &@@@@@@         /@@@@*    @@@@@@@        \r\n" +
                    "     @@@@@@@@@%          @@@@@        @@@@@@@@    \r\n" +
                    "   .  @@@@@@@@@@@       /@@@@%          @@@@@     \r\n" +
                    "    @@@@@,  ,@@@@@@@@@@@@@@@@@@@      /@@@@@@@@#  \r\n" +
                    "  ##@@@@,      .@@@@@        ,@@@@@@@@@@@@@@@@@   \r\n" +
                    "   @@@@@        @@@*           #@@@@@@@    @@@@@* \r\n" +
                    " .&@@@@@        @@@             @@@        @@@@@  \r\n" +
                    "   ,@@@@   *@@@@@@@(           %@@@        @@@@&* \r\n" +
                    "  ,@@@@@@@@@@@@@@@@@@*       (@@@@@,      %@@@@@  \r\n" +
                    "     @@@@@@@       @@@@@@@@@@@@@@@@@@@*  #@@@@    \r\n" +
                    "    @@@@@@@          @@@@@.       @@@@@@@@@@@@&   \r\n" +
                    "        @@@@@        @@@@@          &@@@@@@       \r\n" +
                    "      %@@@@@@@@@    &@@@@          @@@@@@@@@,     \r\n" +
                    "          #@@@@@@@@@@@@@@@#/@@@@@@@@@@@@          \r\n" +
                    "               @@@@@@@@@@@@@@@@@@@@@              \r\n" +
                    "                   @@&  @@&  @@/                  ",
                    "                                                  \r\n" +
                    "                @@   @@   @@   @@                 \r\n" +
                    "           ,@@  @@@@@@@@@@@@@@@@@@ @@@            \r\n" +
                    "        *   @@@@@@@@@@#,   %@@@@@@@@@@*@@@        \r\n" +
                    "        &@@@@@@@@           @@@@@@@@@@@@@   ,     \r\n" +
                    "    (@@@@@@@@@@@@@         @@@@@*     @@@@@@/     \r\n" +
                    "      @@@@@   @@@@@@      @@@@@#        @@@@@@@@  \r\n" +
                    "  @@@@@@@,      @@@@@@@@@@@@@@@&         #@@@@    \r\n" +
                    "    @@@@/        @@@@.       ,@@@@    .%@@@@@@@@@.\r\n" +
                    " @@@@@@@        @@@*           %@@@@@@@@@@@@@@@   \r\n" +
                    "    @@@@(  *&@@@@@@             @@@@@@(   (@@@@@@@\r\n" +
                    " @@@@@@@@@@@@@@@@@@(           %@@@        @@@@   \r\n" +
                    "    @@@@@@@*     @@@@/       (@@@@        %@@@@@@ \r\n" +
                    "  @@@@@@@/         &@@@@@@@@@@@@@@@      #@@@@    \r\n" +
                    "     /@@@@@        @@@@@#      @@@@@@   @@@@@@@&  \r\n" +
                    "    *@ .@@@@@     %@@@@%         @@@@@@@@@@&      \r\n" +
                    "       %@@@@@@@@@@@@@@@           @@@@@@@ .@&     \r\n" +
                    "           ,@@@@@@@@@@@&,,,(@@@@@@@@@@@@@         \r\n" +
                    "           ,%   @@@@@@@@@@@@@@@@@&@@@             \r\n" +
                    "                %   @@&  @@#  @@*                 ",
                    "                                                  \r\n" +
                    "                &   @@/  @@.  @@                  \r\n" +
                    "           #(  ,@@@@@@@@@@@@@@@@@@@@@             \r\n" +
                    "           (@@@@@@@@@@%,. .*%@@@@@@@@@@@@         \r\n" +
                    "       &@@@@@@@@@@@%           @@@@@@@@@@ %@&     \r\n" +
                    "    (@ *@@@@@  @@@@@@         @@@@@/  @@@@@(      \r\n" +
                    "     /@@@@@      @@@@@*     %@@@@@      @@@@@@@(  \r\n" +
                    "  @@@@@@@,        @@@@@@@@@@@@@@(        #@@@@    \r\n" +
                    "    @@@@/        @@@@.       *@@@@        %@@@@@@ \r\n" +
                    " @@@@@@@@#*****/@@@*           %@@@//////&@@@@@   \r\n" +
                    "   .@@@@@@@@@@@@@@@             @@@@@@@@@@@@@@@@@@\r\n" +
                    " @@@@@@@@(.,,,.,@@@(           %@@@......(@@@@@   \r\n" +
                    "    @@@@(        @@@@/       (@@@@        %@@@@@@.\r\n" +
                    "  %@@@@@@/        &@@@@@@@@@@@@@&        #@@@@    \r\n" +
                    "      @@@@@      @@@@@/     /@@@@@      @@@@@&@&  \r\n" +
                    "    ,@@@@@@@@  &@@@@@         @@@@@&  @@@@@@&     \r\n" +
                    "        (@@@@@@@@@@@           @@@@@@@@@@   .     \r\n" +
                    "        .   &@@@@@@@@@@(,.,(&@@@@@@@@@,&@@        \r\n" +
                    "            @@  #@@@@@@@@@@@@@@@@& @@@            \r\n" +
                    "                #@   @@/  @@,  @@                 ",
                    "                                                  \r\n" +
                    "                   @@   @@  .@@   (               \r\n" +
                    "              &@@@@@@@@@@@@@@@@@@@@#   ,          \r\n" +
                    "          @@@@@@@@@@@@@,  .*#@@@@@@@@@@&          \r\n" +
                    "      @@@%@@@@@@@@@@@@.          ,@@@@@@@@@@      \r\n" +
                    "       (@@@@@     @@@@@         (@@@@@@@@@@  ,    \r\n" +
                    "   *@@@@@@@        @@@@@*     #@@@@@&   @@@@@@    \r\n" +
                    "     @@@@,         @@@@@@@@@@@@@@@%      #@@@@&@% \r\n" +
                    "  &@@@@@@@*      @@@@.       /@@@@        %@@@@   \r\n" +
                    "   .@@@@@@@@@@@@@@@*           %@@@        @@@@@@#\r\n" +
                    " %@@@@@@@,/&@@@@@@@             @@@@@@@&(/@@@@@   \r\n" +
                    "   *@@@@        @@@(           %@@@@@@@@@@@@@@@@@,\r\n" +
                    " .@@@@@@(        @@@@*       (@@@@      ,@@@@@%   \r\n" +
                    "    &@@@@/      @@@@@@@@@@@@@@@%         #@@@@@@  \r\n" +
                    "   #/ @@@@@   @@@@@@,     *@@@@@        @@@@@     \r\n" +
                    "      @@@@@@@@@@@@.        ,@@@@@     @@@@@@@@    \r\n" +
                    "         ,@@@@@@@.          ,@@@@@@@@@@@@@        \r\n" +
                    "        .@@ ,@@@@@@@@@&/,,,(@@@@@@@@@@*  &*       \r\n" +
                    "             @@, @@@@@@@@@@@@@@@@@. .@@           \r\n" +
                    "                 &@(  @@&  @@%  #@,               ",
                    "                                                  \r\n" +
                    "                  @@.  @@,  @@   &%               \r\n" +
                    "             /@@#@@@@@@@@@@@@@@@@@@  *@.          \r\n" +
                    "         @@@&@@@@@@@@@@@@@,*%@@@@@@@@@@           \r\n" +
                    "      @# ,@@@@@@    @@@@@         .@@@@@@@@       \r\n" +
                    "       @@@@@@       .@@@@#          @@@@@@@#@@.   \r\n" +
                    "   @@@@@@@@          @@@@@.      #@@@@@@@@@@@     \r\n" +
                    "     @@@@@@%       @@@@@@@@@@@@@@@@@@@   %@@@@@@# \r\n" +
                    " *@@@@@@@@@@@@@@@@@@@.       /@@@@@       %@@@#   \r\n" +
                    "    @@@@,  (@@@@@@@/           %@@@        @@@@@@%\r\n" +
                    " @@@@@@@        @@@             @@@        @@@@   \r\n" +
                    "    @@@@        @@@(           %@@@@@@@#  (@@@@@@&\r\n" +
                    " ,@@@@@@(      .@@@@@*       (@@@@@@@@@@@@@@@@#   \r\n" +
                    "     @@@@(   @@@@@@@@@@@@@@@@@@#       %@@@@@@@@% \r\n" +
                    "   &@@@@@@@@@@@@@*      .@@@@@          @@@@@     \r\n" +
                    "       @@@@@@@@          &@@@@        @@@@@(@@,   \r\n" +
                    "      #/  @@@@@@,         @@@@@   ,@@@@@@@@       \r\n" +
                    "         @@@%@@@@@@@@@&(/@@@@@@@@@@@@@@           \r\n" +
                    "             ,@@(&@@@@@@@@@@@@@@@@@  .@,          \r\n" +
                    "                  @@*  @@/  @@.  #%               ",
                }
            },
            {
                "WALLDEMO",
                new List<string>
                {
                    "                                                           @@@                                      \r\n" +
                    "                                                         @@@ @@@@                                   \r\n" +
                    "                                                       @@@      %@@@/                               \r\n" +
                    "                                                     @@@           .@@@@                            \r\n" +
                    "                                                   @@@              @@@                             \r\n" +
                    "                                                 @@@              @@@                               \r\n" +
                    "                                               @@@              @@@                                 \r\n" +
                    "                                             @@@              @@@                                   \r\n" +
                    "                                           @@@              @@@                                     \r\n" +
                    "                                         @@@              @@@                                       \r\n" +
                    "                                       @@@,             @@@                                         \r\n" +
                    "                                     @@@/             @@@                                           \r\n" +
                    "                                   &@@#             @@@                                             \r\n" +
                    "                                 %@@&             @@@                                               \r\n" +
                    "                               (@@@             @@@,                                                \r\n" +
                    "                             *@@@             @@@/                                                  \r\n" +
                    "                            @@@@            @@@(                                                    \r\n" +
                    "                               @@@@       %@@%                                                      \r\n" +
                    "                                  @@@@  (@@@                                                        \r\n" +
                    "                                     @@@@@                                                          ",
                    "BUFFER=0",
                    "                                                           @@@                                      \r\n" +
                    "                                                         @@@@@@@@                                   \r\n" +
                    "                                                       @@@@@@@@@@@@@/                               \r\n" +
                    "                                                     @@@@@@@@@@@@@@@@@@@                            \r\n" +
                    "                                                   @@@@@@@@@@@@@@@@@@@@                             \r\n" +
                    "                                                 @@@@@@@@@@@@@@@@@@@@                               \r\n" +
                    "                                               @@@@@@@@@@@@@@@@@@@@                                 \r\n" +
                    "                                             @@@@@@@@@@@@@@@@@@@@                                   \r\n" +
                    "                                           @@@@@@@@@@@@@@@@@@@@                                     \r\n" +
                    "                                         @@@@@@@@@@@@@@@@@@@@                                       \r\n" +
                    "                                       @@@@@@@@@@@@@@@@@@@@                                         \r\n" +
                    "                                     @@@@@@@@@@@@@@@@@@@@                                           \r\n" +
                    "                                   &@@@@@@@@@@@@@@@@@@@                                             \r\n" +
                    "                                 %@@@@@@@@@@@@@@@@@@@                                               \r\n" +
                    "                               (@@@@@@@@@@@@@@@@@@@,                                                \r\n" +
                    "                             *@@@@@@@@@@@@@@@@@@@/                                                  \r\n" +
                    "                            @@@@@@@@@@@@@@@@@@@(                                                    \r\n" +
                    "                               @@@@@@@@@@@@@@%                                                      \r\n" +
                    "                                  @@@@@@@@@@                                                        \r\n" +
                    "                                     @@@@@                                                          ",
                    "BUFFER=2",
                }
            }
        };


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
            HelpTextBox.Font = new Font(FontFamily.GenericMonospace, 8);
            HelpTextBox.MouseWheel += HelpTextBox_MouseWheel;

            int[] FrameCounts = new int[Animations.Count];
            int i = 0;
            int Max = 0;
            foreach (List<string> item in Animations.Values)
            {
                FrameCounts[i++] = item.Count;
                if (item.Count > Max)
                    Max = item.Count;
            }
            MaxFrames = FrameCounts.Aggregate(GCD) * Max;
            TimeFrame = 1.0f / (float)Rate;
            Frame = TimeFrame;
        }

        private static void HelpTextBox_MouseWheel(object sender, MouseEventArgs e)
        {
            UpdateFrame = false;
        }

        public static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        private static void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (HelpTree.ContainsKey(e.Node))
            {
                DisplayText = HelpTree[e.Node];
                Frame = TimeFrame;
                HelpTextBox.SelectionStart = 1;
                HelpTextBox.ScrollToCaret();
            }
        }

        public static void Update(float DTime)
        {
            if (!UpdateFrame)
            {
                UpdateFrame = true;
                return;
            }
            if (Frame >= TimeFrame)
            {
                string Display = DisplayText + "\n\n\n";
                foreach (string item in Animations.Keys)
                {
                    List<string> Val = Animations[item];
                    string NewText = Val[Clock % Val.Count];
                    if (NewText.StartsWith(BUFFER))
                    {
                        if (int.TryParse(NewText.Remove(0, BUFFER.Length), out int Result))
                        {
                            if (Result >= 0 && Result < Val.Count)
                                NewText = Val[Result];
                        }
                    }
                    Display = Display.Replace("[" + item + "]", NewText);
                }
                foreach (string item in Images.Keys)
                {
                    Display = Display.Replace("{" + item + "}", Images[item]);
                }
                HelpTextBox.Text = Display;
                if (Clock >= MaxFrames)
                {
                    Clock = 0;
                }
                Clock++;
                Frame = 0;
            }
            else if (Frame < TimeFrame)
            {
                Frame += DTime;
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
