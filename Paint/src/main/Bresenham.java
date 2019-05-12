package main;

import java.awt.*;
import java.awt.event.*;
import javax.swing.JFrame;
import ui.UICanvasBresenham;

public class Bresenham extends JFrame {

	private static final long serialVersionUID = 7716286508117538157L;

	public static void main(String[] args) {

		new Bresenham();
	}

	Bresenham() {

		// initialize the window
		super("Bresenham");

		addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				System.exit(0);
			}
		});
		setSize(900, 720);

		getContentPane().add("Center", new UICanvasBresenham());
		setVisible(true);
	}
}

