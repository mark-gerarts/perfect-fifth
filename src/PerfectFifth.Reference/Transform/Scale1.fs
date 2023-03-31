module P5Reference.Transform.Scale1

open P5.Core
open P5.Shape
open P5.Transform

let draw p5 =
    rect p5 30 20 50 50
    scaleXY p5 0.5 1.3
    square p5 30 20 50

let run node = display node draw
