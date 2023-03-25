module P5Reference.Shape.Rect1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    strokeWeight p5 4
    stroke p5 (Grayscale 51)
    square p5 20 20 60

let run node = display node draw
