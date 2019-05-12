/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package models;

/**
 *
 * @author mini03
 */
public class AppSquare {
    private AppPoint point;
    private int width, height;

    public AppSquare(AppPoint point, int width, int height) {
        this.point = point;
        this.width = width;
        this.height = height;
    }

    public AppPoint getPoint() {
        return point;
    }

    public void setPoint(AppPoint point) {
        this.point = point;
    }

    public int getWidth() {
        return width;
    }

    public void setWidth(int width) {
        this.width = width;
    }

    public int getHeight() {
        return height;
    }

    public void setHeight(int height) {
        this.height = height;
    }
    
    
    
}
