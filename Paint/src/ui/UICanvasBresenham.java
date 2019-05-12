/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ui;

import features.DrawCircle;
import features.DrawPoint;
import java.awt.Canvas;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import models.AppCircle;
import models.AppPoint;
import utilities.Constants;

/**
 *
 * @author mini03
 */
public class UICanvasBresenham extends Canvas {

    private static final long serialVersionUID = 4012295323526936729L;

    int centerX, centerY, pixelSize;

    DrawPoint drawPoint = new DrawPoint();

    // initialize the graphics
    void initgr() {

        pixelSize = Constants.PIXCEL_SIZE;
        centerX = pixelSize * ((getWidth() / pixelSize) / 2);
        centerY = pixelSize * ((getHeight() / pixelSize) / 2);

    }

    // draw one pixel with center (x, y)
    void putPixel(Graphics g, int x, int y) {
        g.setColor(Color.GREEN);
        g.fillRect((x * pixelSize) - (pixelSize / 2), (y * pixelSize)
                - (pixelSize / 2), pixelSize, pixelSize);
    }

    void drawBresenhamCircle(Graphics g, int radius, Color... color) {
        Color currentColor = color.length == 0 ? Color.BLACK : color[0];

        int x = 0;
        int y = radius;

        double F = -radius + 0.25;

        drawPoint.draw(g, new AppPoint(0, radius), currentColor);
        drawPoint.draw(g, new AppPoint(radius, 0), currentColor);
        drawPoint.draw(g, new AppPoint(0, -radius), currentColor);
        drawPoint.draw(g, new AppPoint(-radius, 0), currentColor);

        while (x < y) {

            F = F + 2 * x + 1;
            x = x + 1;

            if (F >= 0) {
                F = F - 2 * y + 2;
                y = y - 1;
            }

            drawPoint.draw(g, new AppPoint(x, y), currentColor);
            drawPoint.draw(g, new AppPoint(y, x), currentColor);
            drawPoint.draw(g, new AppPoint(-x, y), currentColor);
            drawPoint.draw(g, new AppPoint(y, -x), currentColor);

            drawPoint.draw(g, new AppPoint(x, -y), currentColor);
            drawPoint.draw(g, new AppPoint(-y, x), currentColor);
            drawPoint.draw(g, new AppPoint(-x, -y), currentColor);
            drawPoint.draw(g, new AppPoint(-y, -x), currentColor);

        }

        // the circle to approximate
//        g.setColor(currentColor);
//        g.drawOval(-(radius * pixelSize), -(radius * pixelSize), 2 * radius
//                * pixelSize, 2 * radius * pixelSize);

    }

    void drawBresenhamLine(Graphics g, int x1, int y1, int x2, int y2) {

        int x, y, dx, dy;
        double gradient, f;

        dy = y2 - y1;
        dx = x2 - x1;

        x = x1;
        y = y1;

        f = 0.0;
        gradient = (double) dy / (double) dx;

        while (x <= x2) {
            putPixel(g, x, y);
            x++;
            f += gradient;
            if (f > 0.5) {
                y++;
                f--;
            }
        }

        // the line to approximate
        g.setColor(Color.black);
        g.drawLine(x1 * pixelSize, y1 * pixelSize, x2 * pixelSize, y2
                * pixelSize);

    }

    private double F(double x, double y, int a, int b) {
        return Math.pow(b, 2) * Math.pow(x, 2) + Math.pow(a, 2)
                * Math.pow(y, 2) - Math.pow(a, 2) * Math.pow(b, 2);
    }

    void drawBresenhamEllipse(Graphics g, int a, int b) {

        int x = 0;
        int y = b;

        putPixel(g, x, y);
        putPixel(g, x, -y);

        while (2 * b * b * x < 2 * a * a * y) {
            if (F(x + 1, y - 0.5, a, b) > 0) {
                y--;
            }
            x++;
            putPixel(g, x, y);
            putPixel(g, -x, y);
            putPixel(g, x, -y);
            putPixel(g, -x, -y);
        }
        while (y >= 0) {
            if (F(x + 0.5, y - 1, a, b) <= 0) {
                x++;
            }
            y--;
            putPixel(g, x, y);
            putPixel(g, -x, y);
            putPixel(g, x, -y);
            putPixel(g, -x, -y);
        }

        // the ellipse to approximate
        g.setColor(Color.black);
        g.drawOval(-(a * pixelSize), -(b * pixelSize), 2 * a * pixelSize, 2 * b
                * pixelSize);

    }

    // override the canvas paint method
    public void paint(Graphics g) {

        initgr();

        paintCoordinateSystem(g);

        // drawBresenhamLine(g, 0, 0, 5, 3);

        // drawBresenhamCircle(g, 20, Color.BLUE);

        // drawBresenhamEllipse(g, 15, 10);
        
        
        DrawCircle drawCicrle = new DrawCircle();
        drawCicrle.draw(g, new AppCircle(new AppPoint(10,10),60),Color.BLUE);

    }

    private void paintCoordinateSystem(Graphics g) {

        g.setColor(Color.WHITE);
        g.fillRect(0, 0, getWidth(), getHeight());

        // coordinate grid
        g.setColor(Color.BLACK);

        for (int i = 0; i <= getWidth(); i += pixelSize) {
            g.drawLine(i, 0, i, getHeight());
            g.drawLine(0, i, getWidth(), i);
        }

        g.setColor(Color.RED);
        g.drawLine(centerX, 0, centerX, getHeight());
        g.drawLine(0, centerY, getWidth(), centerY);
        g.drawLine(centerX - 5, 10, centerX, 0);
        g.drawLine(centerX + 5, 10, centerX, 0);
        g.drawLine(getWidth() - 10, centerY - 5, getWidth(), centerY);
        g.drawLine(getWidth() - 10, centerY + 5, getWidth(), centerY);
        g.drawString("x", getWidth() - 20, centerY - 10);
        g.drawString("y", centerX + 10, 20);
        for (int i = -170; i <= 190; i += 10) {
            g.drawLine(centerX - 4, centerY + i, centerX + 4, centerY + i);
        }
        for (int i = -240; i <= 220; i += 10) {
            g.drawLine(centerX + i, centerY - 4, centerX + i, centerY + 4);
        }

        for (int i = -150; i <= 150; i += 50) {
            g.drawLine(centerX - 10, centerY + i, centerX + 10, centerY + i);
        }
        for (int i = -200; i <= 200; i += 50) {
            g.drawLine(centerX + i, centerY - 10, centerX + i, centerY + 10);
        }
        g.drawString("5", centerX - 25, centerY - 45);
        g.drawString("5", centerX + 45, centerY - 15);

        // translate origin and orientation
        g.translate(centerX, centerY);
        ((Graphics2D) g).scale(1.0, -1.0);

        // center
        g.fillOval(-pixelSize / 2, -pixelSize / 2, pixelSize, pixelSize);

    }

}
