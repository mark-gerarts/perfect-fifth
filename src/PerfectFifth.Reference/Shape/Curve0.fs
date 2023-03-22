module P5Reference.Shape.Curve0

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    noFill p5
    stroke p5 (RGB(255, 102, 0))
    curve p5 5 26 5 26 73 24 73 61
    stroke p5 (Grayscale 0)
    curve p5 5 26 73 24 73 61 15 65
    stroke p5 (RGB(255, 102, 0))
    curve p5 73 24 73 61 15 65 15 65

let run node = display node draw
