/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package features;

import java.awt.Color;
import java.awt.Graphics;
import models.AppCircle;
import models.AppPoint;
import utilities.Constants;

/**
 *
 * @author mini03
 */
public class DrawCircle {

    public void draw(Graphics g, AppCircle appCicrle, Color... color) {
        DrawPoint drawPoint = new DrawPoint();
        Color currentColor = color.length == 0 ? Color.BLACK : color[0];
        int r = appCicrle.getRadius();

        int x_centre = appCicrle.getCenterPoint().getX();
        int y_centre = appCicrle.getCenterPoint().getY();

        int x = r, y = 0;

        drawPoint.draw(g, new AppPoint(x + x_centre, y + y_centre), currentColor);

        if (r > 0) {

            drawPoint.draw(g, new AppPoint(x + x_centre, -y + y_centre), currentColor);

            drawPoint.draw(g, new AppPoint(y + x_centre, x + y_centre), currentColor);
            drawPoint.draw(g, new AppPoint(-y + x_centre, x + y_centre), currentColor);

        }

        // Initialising the value of P 
        int P = 1 - r;
        while (x > y) {

            y++;

            // Mid-point is inside or on the perimeter 
            if (P <= 0) {
                P = P + 2 * y + 1;
            } // Mid-point is outside the perimeter 
            else {
                x--;
                P = P + 2 * y - 2 * x + 1;
            }

            // All the perimeter points have already  
            // been printed 
            if (x < y) {
                break;
            }

            drawPoint.draw(g, new AppPoint(x + x_centre, y + y_centre), currentColor);

            drawPoint.draw(g, new AppPoint(-x + x_centre, y + y_centre), currentColor);
            drawPoint.draw(g, new AppPoint(x + x_centre, -y + y_centre), currentColor);

            drawPoint.draw(g, new AppPoint(-x + x_centre, -y + y_centre), currentColor);

            if (x != y) {

                drawPoint.draw(g, new AppPoint(y + x_centre, x + y_centre), currentColor);

                drawPoint.draw(g, new AppPoint(-y + x_centre, x + y_centre), currentColor);
                drawPoint.draw(g, new AppPoint(y + x_centre, -x + y_centre), currentColor);

                drawPoint.draw(g, new AppPoint(-y + x_centre, -x + y_centre), currentColor);

            }
        }

//        g.setColor(currentColor);
//        g.drawOval(-(r * Constants.PIXCEL_SIZE), -(r * Constants.PIXCEL_SIZE), 2 * r
//                * Constants.PIXCEL_SIZE, 2 * r * Constants.PIXCEL_SIZE);

    }
}
