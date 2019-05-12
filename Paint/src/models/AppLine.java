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
public class AppLine {
    private AppPoint  pointA, pointB;

    public AppLine(AppPoint pointA, AppPoint pointB) {
        this.pointA = pointA;
        this.pointB = pointB;
    }

    public AppPoint getPointA() {
        return pointA;
    }

    public void setPointA(AppPoint pointA) {
        this.pointA = pointA;
    }

    public AppPoint getPointB() {
        return pointB;
    }

    public void setPointB(AppPoint pointB) {
        this.pointB = pointB;
    }
    
}
