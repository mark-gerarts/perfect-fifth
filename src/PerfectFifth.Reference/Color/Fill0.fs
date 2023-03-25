module P5Reference.Color.Fill0

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    // Grayscale integer value
    fill p5 (Grayscale 51)
    square p5 20 20 60

let run node = display node draw
