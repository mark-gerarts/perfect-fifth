module P5Reference.Color.Stroke7

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    // integer RGBA notation
    stroke p5 (Name "rgba(0,255,0,0.25)")
    strokeWeight p5 4
    square p5 20 20 60
    describe p5 "White rect at center with soft green outline."

let run node = display node draw
