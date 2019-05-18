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
      public Graphics draw(Graphics g, AppLine appline, Color ...color ) {
        AppPoint pointA,pointB;
        pointA = appline.getPointA();
        pointB = appline.getPointB();
          
        int x1 = pointA.getX();
        int y1= pointA.getY();
        
        int x2 = pointB.getX();
        int y2 = pointB.getY();
        
        DrawPoint drawPoint = new DrawPoint();

        int x, y, dx, dy, p;

        dy = y2 - y1;
        dx = x2 - x1;
  
        x = x1;
        y = y1;
   
        p = 2 * dy-dx;
        Color currentColor = color.length == 0 ? Color.BLACK : color[0];

        
        while (x <= x2) { 
            drawPoint.draw(g,new AppPoint(x, y),currentColor);
            x += 1 ;
            if (p<0){
                p = p + 2 * dy;                
            } else {
                p = p + 2 * dy - 2*dx;
                y += 1;
            }
            
        }
        
//        // the line to approximate
//        g.setColor(color.length == 0?Color.BLACK:color[0]);
//        g.drawLine(x1 * Constants.PIXCEL_SIZE, y1 * Constants.PIXCEL_SIZE, x2 * Constants.PIXCEL_SIZE, y2
//                * Constants.PIXCEL_SIZE);

        return g;
    }
}
