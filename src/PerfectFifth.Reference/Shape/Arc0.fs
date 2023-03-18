module P5Reference.Shape.Arc0

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Math

let draw p5 =
    arc p5 50 55 50 50 0 halfPi
    noFill p5
    arc p5 50 55 60 60 halfPi pi
    arc p5 50 55 70 70 pi (pi + quarterPi)
    arc p5 50 55 80 80 (pi + quarterPi) twoPi
    describe p5 "shattered outline of ellipse with a quarter of a white circle bottom-right"

let run node = display node draw
