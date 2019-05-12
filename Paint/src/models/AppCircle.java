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
public class AppCircle {
    private AppPoint centerPoint; // toa do tam
    private int radius; // ban kinh

    public AppCircle(AppPoint centerPoint, int radius) {
        this.centerPoint = centerPoint;
        this.radius = radius;
    }

    public AppPoint getCenterPoint() {
        return centerPoint;
    }

    public void setCenterPoint(AppPoint centerPoint) {
        this.centerPoint = centerPoint;
    }

    public int getRadius() {
        return radius;
    }

    public void setRadius(int radius) {
        this.radius = radius;
    }
    
}
