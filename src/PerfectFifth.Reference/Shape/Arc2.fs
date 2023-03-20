module P5Reference.Shape.Arc2

open P5.Core
open P5.Shape
open P5.Math

let draw p5 =
    arcWithMode p5 50 50 80 80 0 (pi + quarterPi) Open

let run node = display node draw
