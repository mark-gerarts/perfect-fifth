module P5Reference.Structure.NoLoop0

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    background p5 (Grayscale 200)
    line p5 10 10 90 90

let run node = display node draw
