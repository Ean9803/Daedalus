using Daedalus;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

public class Map
{
    public Map()
    {

    }

    public void CreateBuffer(List<PointF> collisionPoints, PointF location, float Radius)
    {
        // Sorting Points
        SortedDictionary<double, PointF> orderedList = new SortedDictionary<double, PointF>();
        double angle;
        for (int i = 0; i < collisionPoints.Count; i++)
        {
            angle = getAngleRad(location, collisionPoints[i]);
            orderedList.Add(angle, collisionPoints[i]);
        }
        int index = 0;
        int prevIndex = 0;

        // Connecting points
        List<Lclass.Line> preBuffers = new List<Lclass.Line>();
        PointF? PrevSlope = null;
        List<KeyValuePair<double, PointF>> currentPoints = orderedList.ToList();
        for (int i = 1; i < currentPoints.Count + 1; i++)
        {
            prevIndex = i - 1;
            index = i % orderedList.Count;

            // Check to see if we have reached the end of the list
            float currentSlopeX = currentPoints[index].Value.X - currentPoints[prevIndex].Value.X;
            float currentSlopeY = currentPoints[index].Value.Y - currentPoints[prevIndex].Value.Y;
            if (PrevSlope == null)
            {
                PrevSlope = new PointF(currentSlopeX, currentSlopeY);
                preBuffers.Add(new Lclass.Line() { P1 = currentPoints[prevIndex].Value, P2 = currentPoints[index].Value, Width = 2 });
            }
            else
            {
                bool match = ((PointF)(PrevSlope)).X == currentSlopeX && ((PointF)(PrevSlope)).Y == currentSlopeY;
                if (match)
                {
                    Lclass.Line existingLine = preBuffers[preBuffers.Count - 1];
                    existingLine.P1 = currentPoints[index].Value;
                }
                else
                {
                    PrevSlope = new PointF(currentSlopeX, currentSlopeY);
                    preBuffers.Add(new Lclass.Line() { P1 = currentPoints[prevIndex].Value, P2 = currentPoints[index].Value, Width = 2 });
                }
            }
        }
        foreach (Lclass.Line item in preBuffers)
        {
            Knossos.KnossosUI.addLine(item);
        }
    }

    public void Refresh(float Radius)
    {

    }

    private double getAngleRad(PointF p1, PointF p2)
    {
        // returns the angle between 2 points in radians
        // p1 = {x: 1, y: 2};
        // p2 = {x: 3, y: 4};
        return ((MathF.Atan2(p2.Y - p1.Y, p2.X - p1.X)) * (180 / MathF.PI)) + 180;
    }
}