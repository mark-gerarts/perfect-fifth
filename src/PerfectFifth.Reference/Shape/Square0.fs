module P5Reference.Shape.Square0

open P5.Core
open P5.Shape

let draw p5 =
    // Draw a square at location (30, 20) with a side size of 55.
    square p5 30 20 55

let run node = display node draw
