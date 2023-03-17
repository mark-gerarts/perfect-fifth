module P5Reference.Color.Fill5

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    // six-digit hexadecimal RGB notation
    fill p5 (Name "#222222")
    square p5 20 20 60
    describe p5 "black rect with black outline in center of canvas"

let run node = display node draw
