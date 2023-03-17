module P5Reference.Color.Fill8

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    // percentage RGB notation
    fill p5 (Name "rgb(100%,0%,10%)")
    square p5 20 20 60
    describe p5 "red rect with black outline in center of canvas"

let run node = display node draw
