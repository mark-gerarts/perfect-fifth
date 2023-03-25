module P5Reference.Shape.Bezier0

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    noFill p5
    stroke p5 (RGB(255, 102, 0))
    line p5 85 20 10 10
    line p5 90 90 15 80
    stroke p5 (Grayscale 0)
    bezier p5 85 20 10 10 90 90 15 80

let run node = display node draw
