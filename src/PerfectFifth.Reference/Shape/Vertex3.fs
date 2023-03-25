module P5Reference.Shape.Vertex3

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    strokeWeight p5 3
    stroke p5 (RGB(237, 34, 93))
    beginShapeWithMode p5 Lines
    vertex p5 10 35
    vertex p5 90 35
    vertex p5 10 65
    vertex p5 90 65
    vertex p5 35 10
    vertex p5 35 90
    vertex p5 65 10
    vertex p5 65 90
    endShape p5

let run node = display node draw
