module P5Reference.Shape.Arc4

open P5.Core
open P5.Environment
open P5.Shape
open P5.Math

let draw p5 =
    arcWithMode p5 50 50 80 80 0 (pi + quarterPi) Pie
    describe p5 "white ellipse with top right quarter missing with black outline around the shape"

let run node = display node draw
