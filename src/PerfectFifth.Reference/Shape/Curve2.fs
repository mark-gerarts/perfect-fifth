module P5Reference.Shape.Curve2

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    noFill p5
    stroke p5 (RGB(255, 102, 0))
    curve3D p5 5 26 0 5 26 0 73 24 0 73 61 0
    stroke p5 (Grayscale 0)
    curve3D p5 5 26 0 73 24 0 73 61 0 15 65 0
    stroke p5 (RGB(255, 102, 0))
    curve3D p5 73 24 0 73 61 0 15 65 0 15 65 0

let run node = display node draw
