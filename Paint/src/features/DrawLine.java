/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package features;

import java.awt.Color;
import java.awt.Graphics;
import models.AppLine;
import models.AppPoint;
import utilities.Constants;

/**
 *
 * @author mini03
 */
public class DrawLine {
      public Graphics drawBresenhamLine(Graphics g, AppLine appline, Color ...color ) {
        AppPoint pointA,pointB;
        pointA = appline.getPointA();
        pointB = appline.getPointB();
          
        int x1 = pointA.getX();
        int y1= pointA.getY();
        int x2 = pointB.getX();
        int y2 = pointB.getY();
        
        int x, y, dx, dy;
        DrawPoint drawPoint = new DrawPoint();
        
        double gradient, f;

        dy = y2 - y1;
        dx = x2 - x1;

        x = x1;
        y = y1;

        f = 0.0;
        gradient = (double) dy / (double) dx;

        while (x <= x2) {
            drawPoint.draw(g, new AppPoint(x,y));
            x++;
            f += gradient;
            if (f > 0.5) {
                y++;
                f--;
            }
        }

        // the line to approximate
        g.setColor(color.length == 0?Color.BLACK:color[0]);
        g.drawLine(x1 * Constants.PIXCEL_SIZE, y1 * Constants.PIXCEL_SIZE, x2 * Constants.PIXCEL_SIZE, y2
                * Constants.PIXCEL_SIZE);

        return g;
    }
}
