module P5Reference.Color.Fill10

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    // p5 Color object
    let c = color p5 (RGB(0, 0, 255))
    fill p5 (P5Color c)
    square p5 20 20 60
    describe p5 "blue rect with black outline in center of canvas"

let run node = display node draw
