module P5Reference.Color.Stroke2

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    // H, S & B integer values
    colorMode p5 ModeHSB
    strokeWeight p5 4
    stroke p5 (RGB(255, 204, 100))
    square p5 20 20 60
    describe p5 "White rect at center with royal blue outline."

let run node = display node draw
