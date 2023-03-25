module P5Reference.Shape.Arc1

open P5.Core
open P5.Shape
open P5.Math

let draw p5 = arc p5 50 50 80 80 0 (pi + quarterPi)

let run node = display node draw
