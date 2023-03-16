module P5Reference.Color.Background6

open P5.Core
open P5.Color
open P5.Environment

let draw p5 =
    // integer RGB notation
    background p5 (Name "rgb(0,255,0)")
    describe p5 "canvas with bright green background"

let run node = display node draw
