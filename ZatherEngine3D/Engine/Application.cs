using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ZatherEngine3D.Engine
{
    public class Application
    {
        public delegate void Action();
        public Action rndLoop;
        public void Run(ImguiController cntrl)
        {
            InitWindow(1000, 800, "Zather - v0.01b");
            cntrl.Load(GetScreenWidth(), GetScreenHeight());
            while (!WindowShouldClose())
            {
                rndLoop();
            }

            CloseWindow();
        }
        public Application(Action rnd)
        {
            rndLoop = rnd;
        }
    }
}
