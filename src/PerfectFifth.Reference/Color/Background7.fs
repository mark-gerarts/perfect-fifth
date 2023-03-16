module P5Reference.Color.Background7

open P5.Core
open P5.Color
open P5.Environment

let draw p5 =
    // integer RGBA notation
    background p5 (Name "rgba(0,255,0, 0.25)")
    describe p5 "canvas with soft green background"

let run node = display node draw
