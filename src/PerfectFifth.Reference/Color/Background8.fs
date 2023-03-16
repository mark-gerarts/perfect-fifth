module P5Reference.Color.Background8

open P5.Core
open P5.Color
open P5.Environment

let draw p5 =
    // percentage RGB notation
    background p5 (Name "rgb(100%,0%,10%)")
    describe p5 "canvas with red background"

let run node = display node draw
