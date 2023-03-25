module P5Reference.Shape.BeginShape9

open P5.Core
open P5.Shape

let draw p5 =
    beginShapeWithMode p5 QuadStrip
    vertex p5 30 20
    vertex p5 30 75
    vertex p5 50 20
    vertex p5 50 75
    vertex p5 65 20
    vertex p5 65 75
    vertex p5 85 20
    vertex p5 85 75
    endShape p5

let run node = display node draw
