module P5Reference.Shape.BezierVertex0

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    noFill p5
    beginShape p5
    vertex p5 30 20
    bezierVertex p5 80 0 80 75 30 75
    endShape p5

let run node = display node draw
