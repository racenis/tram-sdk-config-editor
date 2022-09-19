using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tram_sdk_config_editor {
    public interface EditorAction {
        void Perform();
        void Unperform();
    }
}
