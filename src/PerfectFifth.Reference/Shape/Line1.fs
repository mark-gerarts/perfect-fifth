module P5Reference.Shape.Line1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    line p5 30 20 85 20
    stroke p5 (Grayscale 126)
    line p5 85 20 85 75
    stroke p5 (Grayscale 255)
    line p5 85 75 30 75
    describe p5 "3 lines of various stroke colors. Form top, bottom and right sides of a square"

let run node = display node draw
