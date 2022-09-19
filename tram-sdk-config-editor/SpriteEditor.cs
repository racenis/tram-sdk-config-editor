using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tram_sdk_config_editor {
    public partial class SpriteEditor : UserControl {
        public SpriteEditor() {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            //MessageBox.Show("Pimpis!");
        }

        public void AddSprite(Sprite sprite) {
            allSpritesList.Items.Add(sprite);
        }

        public void RemoveSprite(Sprite sprite) {
            allSpritesList.Items.Remove(sprite);
        }

        public void RefreshSprite(Sprite sprite) {
            var spriteIndex = allSpritesList.Items.IndexOf(sprite);
            allSpritesList.Items[spriteIndex] = allSpritesList.Items[spriteIndex];
        }

        public void AddFrame(Sprite sprite, SpriteFrame frame) {
            if (selectedSprite == sprite) {
                framesInSpriteList.Items.Add(frame);
            }
        }

        public void RemoveFrame(Sprite sprite, SpriteFrame frame) {
            if (selectedSprite == sprite) {
                framesInSpriteList.Items.Remove(frame);
            }
        }

        public void ShowSpriteFrames(Sprite frame) {
            selectedSprite = frame;
            framesInSpriteList.Items.Clear();
            foreach (var f in selectedSprite.frames) {
                framesInSpriteList.Items.Add(f);
            }
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e) {
            EditorManager.PerformAction(new ActionNewSprite());
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e) {
            if (allSpritesList.SelectedItem != null) {
                Sprite ee = (Sprite)allSpritesList.SelectedItem;
                EditorManager.PerformAction(new ActionDeleteSprite(ee));
            }
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e) {
            EditorManager.PerformAction(new ActionSpriteNewFrame(selectedSprite));
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (framesInSpriteList.SelectedItem != null) {
                EditorManager.PerformAction(new ActionSpriteDeleteFrame(selectedSprite, (SpriteFrame)framesInSpriteList.SelectedItem));
            }
        }

        private void allSpritesList_SelectedIndexChanged(object sender, EventArgs e) {
            if (allSpritesList.SelectedItem != null) {
                ShowSpriteFrames((Sprite)allSpritesList.SelectedItem);
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e) {
            if (allSpritesList.SelectedItem != null) {
                var sprite = (Sprite)allSpritesList.SelectedItem;
                var renamePrompt = new RenamePrompt(sprite.name);
                if (renamePrompt.ShowDialog() == DialogResult.OK) {
                    EditorManager.PerformAction(new ActionRenameSprite(sprite, renamePrompt.GetNewName()));
                }
            }
        }

        Sprite selectedSprite = null;
    }

    public class ActionNewSprite : EditorAction {
        public void Perform() {
            SpriteManager.sprites.Add(actionSprite);
            EditorManager.spriteEditor.AddSprite(actionSprite);
        }

        public void Unperform() {
            SpriteManager.sprites.Remove(actionSprite);
            EditorManager.spriteEditor.RemoveSprite(actionSprite);
        }

        public Sprite actionSprite = new Sprite();
    }

    public class ActionDeleteSprite : EditorAction {
        public ActionDeleteSprite(Sprite sprite) {
            actionSprite = sprite;
        }

        public void Perform() {
            SpriteManager.sprites.Remove(actionSprite);
            EditorManager.spriteEditor.RemoveSprite(actionSprite);
        }

        public void Unperform() {
            SpriteManager.sprites.Add(actionSprite);
            EditorManager.spriteEditor.AddSprite(actionSprite);
        }

        public Sprite actionSprite;
    }

    public class ActionRenameSprite : EditorAction {
        public ActionRenameSprite(Sprite sprite, string name) {
            actionSprite = sprite;
            newName = name;
            oldName = sprite.name;
        }

        public void Perform() {
            actionSprite.name = newName;
            EditorManager.spriteEditor.RefreshSprite(actionSprite);
        }

        public void Unperform() {
            actionSprite.name = oldName;
            EditorManager.spriteEditor.RefreshSprite(actionSprite);
        }

        public Sprite actionSprite;
        public string newName;
        public string oldName;
    }

    public class ActionSpriteNewFrame : EditorAction {
        public ActionSpriteNewFrame(Sprite sprite) {
            actionSprite = sprite;
            actionFrame = new SpriteFrame(actionSprite);
        }

        public void Perform() {
            actionSprite.frames.Add(actionFrame);
            EditorManager.spriteEditor.AddFrame(actionSprite, actionFrame);
        }

        public void Unperform() {
            actionSprite.frames.Remove(actionFrame);
            EditorManager.spriteEditor.RemoveFrame(actionSprite, actionFrame);
        }

        public Sprite actionSprite;
        public SpriteFrame actionFrame;
    }

    public class ActionSpriteDeleteFrame : EditorAction {
        public ActionSpriteDeleteFrame(Sprite sprite, SpriteFrame frame) {
            actionSprite = sprite;
            actionFrame = frame;
        }

        public void Perform() {
            actionSprite.frames.Remove(actionFrame);
            EditorManager.spriteEditor.RemoveFrame(actionSprite, actionFrame);
        }

        public void Unperform() {
            actionSprite.frames.Add(actionFrame);
            EditorManager.spriteEditor.AddFrame(actionSprite, actionFrame);
        }

        public Sprite actionSprite;
        public SpriteFrame actionFrame;
    }
}
