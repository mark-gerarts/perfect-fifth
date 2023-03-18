module P5Reference.Shape.Arc3

open P5.Core
open P5.Environment
open P5.Shape
open P5.Math

let draw p5 =
    arcWithMode p5 50 50 80 80 0 (pi + quarterPi) Chord
    describe p5 "white open arc with black outline with top right missing"

let run node = display node draw
