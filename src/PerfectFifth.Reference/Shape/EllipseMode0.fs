module P5Reference.Shape.EllipseMode0

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    // Example showing RADIUS and CENTER ellipsemode with 2 overlaying ellipses
    ellipseMode p5 Radius
    fill p5 (Grayscale 255)
    ellipse p5 50 50 30 30 // Outer white ellipse
    ellipseMode p5 Center
    fill p5 (Grayscale 100)
    ellipse p5 50 50 30 30 // Inner gray ellipse

let run node = display node draw
