module P5Reference.Color.Fill2

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    // H, S & B integer values
    colorMode p5 ModeHSB
    fill p5 (RGB(255, 204, 100))
    square p5 20 20 60

let run node = display node draw
