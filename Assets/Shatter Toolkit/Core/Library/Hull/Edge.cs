/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

// Shatter Toolkit
// Copyright 2015 Gustav Olsson
using System.Collections.Generic;
using UnityEngine;

namespace ShatterToolkit
{
    public class Edge
    {
        public int index;
        public Point point0, point1;
        public Vector3 line;
        
        public Edge(Point point0, Point point1)
        {
            this.point0 = point0;
            this.point1 = point1;
            this.line = point1.position - point0.position;
        }
    }
}
