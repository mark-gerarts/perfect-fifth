module P5Reference.Shape.Point0

open P5.Core
open P5.Shape

let draw p5 =
    point p5 30 20
    point p5 85 20
    point p5 85 75
    point p5 30 75

let run node = display node draw
