module P5Reference.Shape.EllipseMode1

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    // Example showing CORNER and CORNERS ellipseMode with 2 overlaying ellipses
    ellipseMode p5 Corner
    fill p5 (Grayscale 255)
    ellipse p5 25 25 50 50 // Outer white ellipse
    ellipseMode p5 Corners
    fill p5 (Grayscale 100)
    ellipse p5 25 25 50 50 // Inner gray ellipse

let run node = display node draw
