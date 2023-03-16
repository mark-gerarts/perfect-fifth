module P5Reference.Color.Background4

open P5.Core
open P5.Color
open P5.Environment

let draw p5 =
    // three-digit hexadecimal RGB notation
    background p5 (Name "#fae")
    describe p5 "canvas with pink background"

let run node = display node draw
