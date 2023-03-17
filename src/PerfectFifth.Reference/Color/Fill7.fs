module P5Reference.Color.Fill7

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    // integer RGBA notation
    fill p5 (Name "rgba(0,255,0, 0.25)")
    square p5 20 20 60
    describe p5 "soft green rect with black outline in center of canvas"

let run node = display node draw
