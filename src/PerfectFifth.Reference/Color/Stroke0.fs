module P5Reference.Color.Stroke0

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    // Grayscale integer value
    stroke p5 (Grayscale 51)
    strokeWeight p5 4
    square p5 20 20 60

let run node = display node draw
