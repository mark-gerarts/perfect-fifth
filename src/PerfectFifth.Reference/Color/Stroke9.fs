module P5Reference.Color.Stroke9

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    // percentage RGBA notation
    stroke p5 (Name "rgba(100%,0%,100%,0.5)")
    strokeWeight p5 4
    square p5 20 20 60
    describe p5 "White rect at center with dark fuchsia outline."

let run node = display node draw
