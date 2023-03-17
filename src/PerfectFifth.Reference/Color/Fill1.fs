module P5Reference.Color.Fill1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    // R, G & B integer values
    fill p5 (RGB(255, 204, 0))
    square p5 20 20 60
    describe p5 "yellow rect with black outline in center of canvas"

let run node = display node draw
