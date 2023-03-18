module P5Reference.Color.Stroke1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    // R, G & B integer values
    stroke p5 (RGB(255, 204, 0))
    strokeWeight p5 4
    square p5 20 20 60
    describe p5 "White rect at center with yellow outline."

let run node = display node draw
