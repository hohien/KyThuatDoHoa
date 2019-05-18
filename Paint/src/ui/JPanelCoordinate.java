/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ui;

import features.DrawCircle;
import features.DrawLine;
import features.DrawPoint;
import java.awt.Canvas;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Image;
import java.awt.RenderingHints;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.MouseMotionAdapter;
import javax.swing.JPanel;
import models.AppCircle;
import models.AppLine;
import models.AppPoint;
import utilities.Constants;

/**
 *
 * @author mini03
 */
public class JPanelCoordinate extends JPanel {

    private static final long serialVersionUID = 4012295323526936729L;

    int centerX, centerY, pixelSize;
    private Graphics2D g2;
    private Image image;

    DrawPoint drawPoint;
    DrawCircle drawCicrle;

    int currentX, currentY, oldX = 0, oldY = 0;

    public JPanelCoordinate() {

    }

    // initialize the graphics
    void initgr() {

        pixelSize = Constants.PIXCEL_SIZE;
        centerX = pixelSize * ((getWidth() / pixelSize) / 2);
        centerY = pixelSize * ((getHeight() / pixelSize) / 2);

        drawPoint = new DrawPoint();
        drawCicrle = new DrawCircle();
    }

    @Override
    protected void paintComponent(Graphics g) {
        if (image == null) {
            initgr();
            // image to draw null ==> we create
            image = createImage(getWidth(), getHeight());
            g2 = (Graphics2D) image.getGraphics();

            clear();
        }

        g.drawImage(image, 0, 0, null);
    }

    public Graphics drawCoordinate(Graphics g) {

        g.setColor(Color.WHITE);
        g.fillRect(0, 0, getWidth(), getHeight());

        // coordinate grid
        g.setColor(Color.GRAY);

        for (int i = 0; i <= getWidth(); i += pixelSize) {
            g.drawLine(i, 0, i, getHeight());
            g.drawLine(0, i, getWidth(), i);
        }

        g.setColor(Color.BLUE);
        g.drawLine(centerX, 0, centerX, getHeight());
        g.drawLine(0, centerY, getWidth(), centerY);
        g.drawLine(centerX - 5, 10, centerX, 0);
        g.drawLine(centerX + 5, 10, centerX, 0);
        g.drawLine(getWidth() - 10, centerY - 5, getWidth(), centerY);
        g.drawLine(getWidth() - 10, centerY + 5, getWidth(), centerY);

        g.drawString("x", getWidth() - 20, centerY - 10);
        g.drawString("y", centerX + 10, 20);

        g.translate(centerX, centerY);
        ((Graphics2D) g).scale(1.0, -1.0);

        // center
        g.fillOval(-pixelSize / 2, -pixelSize / 2, pixelSize, pixelSize);
        return g;
    }

    public void drawCircle() {
        AppLine line = new AppLine(new AppPoint(10, 10), new AppPoint(50, 10));
        DrawLine drawline = new DrawLine();
        drawline.draw(g2, line);

        repaint();
    }

    public void clear() {
        g2.setPaint(Color.white);
        // draw white on entire draw area to clear
        g2.fillRect(0, 0, getSize().width, getSize().height);
        g2.setPaint(Color.black);
        drawCoordinate(g2);
        repaint();
    }
}
