module P5Reference.Shape.Square2

open P5.Core
open P5.Shape

let draw p5 =
    // Draw a square with rounded corners having the following radii:
    // top-left = 20, top-right = 15, bottom-right = 10, bottom-left = 5.
    roundedSquare p5 30 20 55 20 15 10 5

let run node = display node draw
