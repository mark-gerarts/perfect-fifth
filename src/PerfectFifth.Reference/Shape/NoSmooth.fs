module P5Reference.Shape.NoSmooth

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    background p5 (Grayscale 0)
    noStroke p5
    smooth p5
    circle p5 30 48 36
    noSmooth p5
    circle p5 70 48 36

let run node = display node draw
