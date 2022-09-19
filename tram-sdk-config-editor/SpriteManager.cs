using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tram_sdk_config_editor {
    public class SpriteFrame {
        public Sprite parent;
        public uint offsetX;
        public uint offsetY;
        public uint width;
        public uint height;
        public float scale;
        public float length;
        public SpriteFrame(Sprite parent) { this.parent = parent; }
        public override string ToString() { return parent.frames.IndexOf(this).ToString(); } 
    }

    public class Sprite {
        public List<SpriteFrame> frames = new List<SpriteFrame>();
        public string name = "New Sprite";
        public override string ToString() { return name; }  
    }

    public static class SpriteManager {
        public static List<Sprite> sprites = new List<Sprite>();
    }
}
