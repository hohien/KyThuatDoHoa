/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package features;

import com.sun.istack.internal.Nullable;
import java.awt.Color;
import static java.awt.Color.BLACK;
import java.awt.Graphics;
import models.AppPoint;
import utilities.Constants;

/**
 *
 * @author mini03
 */
public class DrawPoint {
    	public Graphics draw(Graphics g, AppPoint point,Color ...color) {
 
		g.setColor(color.length == 0?Color.BLACK:color[0]);
		g.fillRect((point.getX() * Constants.PIXCEL_SIZE) - (Constants.PIXCEL_SIZE / 2), (point.getY() * Constants.PIXCEL_SIZE)
				- (Constants.PIXCEL_SIZE / 2), Constants.PIXCEL_SIZE, Constants.PIXCEL_SIZE);
                return g;
	}
}
