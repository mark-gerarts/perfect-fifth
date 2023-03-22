module P5Reference.Shape.BeginContour

open P5.Core
open P5.Color
open P5.Shape
open P5.Transform

let draw p5 =
    translate p5 50 50
    stroke p5 (RGB(255, 0, 0))
    beginShape p5

    // Exterior part of shape, clockwise winding
    vertex p5 -40 -40
    vertex p5 40 -40
    vertex p5 40 40
    vertex p5 -40 40

    // Interior part of shape, counter-clockwise winding
    beginContour p5
    vertex p5 -20 -20
    vertex p5 -20 20
    vertex p5 20 20
    vertex p5 20 -20
    endContour p5

    endShapeAndClose p5

let run node = display node draw
