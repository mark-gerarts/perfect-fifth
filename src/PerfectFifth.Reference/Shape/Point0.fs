module P5Reference.Shape.Point0

open P5.Core
open P5.Environment
open P5.Shape

let draw p5 =
    point p5 30 20
    point p5 85 20
    point p5 85 75
    point p5 30 75
    describe p5 "4 points create the corners of a square"

let run node = display node draw
