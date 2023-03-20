module P5Reference.Color.Background0

open P5.Core
open P5.Color

let draw p5 =
    // Grayscale integer value
    background p5 (Grayscale 51)

let run node = display node draw
