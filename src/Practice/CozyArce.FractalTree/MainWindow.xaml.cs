﻿using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CozyArce.FractalTree
{
    public partial class MainWindow : Window
    {
        const double PI = 3.1415926;
        const double Arg = PI / 5;
        const double GoldenSection = 0.618;
        Random rand = new Random();

        public MainWindow()
        {
            InitializeComponent();
            DrawTree(new Point(300, 750), PI / 2, 200, 4);
        }

        public void DrawTree(Point begin, double angle, double length, short width)
        {
            if (length < 3) return;

            int x = (int)(begin.X + length * Math.Cos(angle));
            int y = (int)(begin.Y - length * Math.Sin(angle));
            var end = new Point(x, y);

            LineGeometry myLineGeometry = new LineGeometry();
            myLineGeometry.StartPoint = begin;
            myLineGeometry.EndPoint = end;

            Path myPath = new Path();
            myPath.Stroke = Brushes.Black;
            myPath.StrokeThickness = width;
            myPath.Data = myLineGeometry;
            xCanvas.Children.Add(myPath);

            if (--width < 1) width = 1;
            var sub = rand.Next(2, 4);
            for (var i = 0; i < sub; ++i)
            {
                DrawTree(end, angle + (rand.NextDouble() - 0.5) * PI / 2, rand.NextDouble() * length, width);
            }
        }
    }
}
