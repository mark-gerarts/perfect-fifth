module P5Reference.Color.Background9

open P5.Core
open P5.Color
open P5.Environment

let draw p5 =
    // percentage RGBA notation
    background p5 (Name "rgba(100%,0%,100%,0.5)")
    describe p5 "canvas with light purple background"

let run node = display node draw
