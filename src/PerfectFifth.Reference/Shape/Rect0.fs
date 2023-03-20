module P5Reference.Shape.Rect0

open P5.Core
open P5.Environment
open P5.Shape

let draw p5 =
    // Draw a rectangle at location (30, 20) with a width and height of 55.
    rect p5 30 20 55 55
    describe p5 "white rect with black outline in mid-right of canvas"

let run node = display node draw
