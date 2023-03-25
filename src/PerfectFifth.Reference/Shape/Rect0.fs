module P5Reference.Shape.Rect0

open P5.Core
open P5.Shape

let draw p5 =
    // Draw a rectangle at location (30, 20) with a width and height of 55.
    rect p5 30 20 55 55

let run node = display node draw
