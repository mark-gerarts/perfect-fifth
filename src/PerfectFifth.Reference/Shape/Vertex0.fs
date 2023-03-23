module P5Reference.Shape.Vertex0

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    strokeWeight p5 3
    beginShapeWithMode p5 Points
    vertex p5 30 20
    vertex p5 85 20
    vertex p5 85 75
    vertex p5 30 75
    endShape p5

let run node = display node draw
