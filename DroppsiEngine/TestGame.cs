﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DroppsiEngine.Engine;

namespace DroppsiEngine
{
    class TestGame : DroppsiEngine.Engine.DroppsiEngine
    {
        public TestGame() : base(new Vector2D(1920, 1080), "Test")
        {
        }
        
        public override void OnInitalize()
        {
            Console.WriteLine("Readdy");
        }
    }
}
