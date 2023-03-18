module P5Reference.Shape.Arc4

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    strokeWeight p5 4
    stroke p5 (Grayscale 51)
    square p5 20 20 60
    describe p5 "White rect at center with dark charcoal grey outline."

let run node = display node draw
