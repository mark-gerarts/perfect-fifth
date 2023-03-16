module P5Reference.Color.Background5

open P5.Core
open P5.Color
open P5.Environment

let draw p5 =
    // six-digit hexadecimal RGB notation
    background p5 (Name "#222222")
    describe p5 "canvas with black background"

let run node = display node draw
