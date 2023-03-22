module P5Reference.Shape.BeginShape6

open P5.Core
open P5.Shape

let draw p5 =
    beginShapeWithMode p5 TriangleStrip
    vertex p5 30 75
    vertex p5 40 20
    vertex p5 50 75
    vertex p5 60 20
    vertex p5 70 75
    vertex p5 80 20
    vertex p5 90 75
    endShape p5

let run node = display node draw
