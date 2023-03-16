module P5Reference.Color.Background2

open P5.Core
open P5.Color
open P5.Environment

let draw p5 =
    // H, S & B integer values
    colorMode p5 ModeHSB
    background p5 (RGB(255, 204, 100))
    describe p5 "canvas with royal blue background"

let run node = display node draw
