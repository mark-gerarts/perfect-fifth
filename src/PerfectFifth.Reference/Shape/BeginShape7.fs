module P5Reference.Shape.BeginShape7

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    beginShapeWithMode p5 TriangleFan
    vertex p5 57.5 50
    vertex p5 57.5 15
    vertex p5 92 50
    vertex p5 57.5 85
    vertex p5 22 50
    vertex p5 57.5 15
    endShape p5

let run node = display node draw
