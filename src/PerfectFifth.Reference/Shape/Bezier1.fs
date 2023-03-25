module P5Reference.Shape.Bezier1

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    background p5 (Grayscale 0)
    noFill p5
    stroke p5 (Grayscale 255)
    bezier3D p5 250 250 0 100 100 0 100 0 0 0 100 0

let run node = display node draw
