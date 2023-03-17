module P5Reference.Color.Fill4

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    // three-digit hexadecimal RGB notation
    fill p5 (Name "#fae")
    square p5 20 20 60
    describe p5 "pink rect with black outline in center of canvas"

let run node = display node draw
