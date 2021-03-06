﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Snake
{
    class HorizontalLine: Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char symb)
        {
            pList = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, symb);
                pList.Add(p);
            }
        }
        
    }
}
