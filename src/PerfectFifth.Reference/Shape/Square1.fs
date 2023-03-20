module P5Reference.Shape.Square1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    // Draw a square with rounded corners, each having a radius of 20.
    roundedSquare p5 30 20 55 20 20 20 20
    describe p5 "white square with black outline and round edges in mid-right of canvas"

let run node = display node draw
