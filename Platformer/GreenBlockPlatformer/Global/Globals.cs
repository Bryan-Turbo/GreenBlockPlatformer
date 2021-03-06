﻿using Microsoft.Xna.Framework;

namespace GreenBlockPlatformer.Global {
    static class Globals {
        public static Vector2 Gravity = new Vector2(0, 2F);
        public const int MaxSpeed = 5;

        public const int ScreenWidth = 1920;
        public const int ScreenHeight = 1080;
        public const bool FullScreen = true;

        public static float Zoom = 1.0f;
    }
}