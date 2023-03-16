module P5Reference.Color.Background0

open P5.Core
open P5.Color
open P5.Environment

let draw p5 =
    // Grayscale integer value
    background p5 (Grayscale 51)
    describe p5 "canvas with darkest charcoal grey background"

let run node = display node draw
