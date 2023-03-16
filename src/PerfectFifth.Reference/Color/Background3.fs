module P5Reference.Color.Background3

open P5.Core
open P5.Color
open P5.Environment

let draw p5 =
    // Named SVG/CSS color string
    background p5 (Name "red")
    describe p5 "canvas with red background"

let run node = display node draw
