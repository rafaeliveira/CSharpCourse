﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractMethods.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double area();
    }
}