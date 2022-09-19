using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tram_sdk_config_editor
{
    public partial class MainForm : Form
    {
        public MainForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void editorModeMenu_DoubleClicked(object sender, EventArgs e) {
            
            
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            new EditorAboutBox().Show();
        }

        private void editorModeMenu_MouseDoubleClick(object sender, MouseEventArgs e) {
            var selected = editorModeMenu.SelectedItems;

            if (selected.Count > 0) {
                editorMainPanelSplit.Panel2.Controls.Clear();

                switch ((string)selected[0].Tag) {
                    case "sprite_menu":
                        editorMainPanelSplit.Panel2.Controls.Add(EditorManager.spriteEditor);
                        break;
                    default:
                        MessageBox.Show("selected index: " + selected[0]);
                        break;
                }
            }
            
        }
    }

    public static class EditorManager {
        public static SpriteEditor spriteEditor = new SpriteEditor();

        static List<EditorAction> editorActions = new List<EditorAction>();

        public static void PerformAction(EditorAction action) {
            editorActions.Add(action);
            action.Perform();
        }
    }
}
