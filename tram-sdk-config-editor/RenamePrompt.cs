using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tram_sdk_config_editor {
    public partial class RenamePrompt : Form {
        public RenamePrompt(string name) {
            InitializeComponent();
            nameTextBox.Text = name;
        }

        public string GetNewName() {
            return nameTextBox.Text;
        }
    }
}
