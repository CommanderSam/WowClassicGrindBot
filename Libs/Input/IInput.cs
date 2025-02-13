﻿using System;
using System.Drawing;
using System.Threading.Tasks;

namespace Libs
{
    public interface IInput
    {
        void KeyDown(int key);

        void KeyUp(int key);

        Task KeyPress(int key, int milliseconds);

        void KeyPressSleep(int key, int milliseconds);

        void SetCursorPosition(Point position);

        Task RightClickMouse(Point position);

        Task LeftClickMouse(Point position);

        Task SendText(string text);

        void PasteFromClipboard();
    }
}
