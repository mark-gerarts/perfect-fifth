module P5Reference.Shape.Rect2

open P5.Core
open P5.Environment
open P5.Shape

let draw p5 =
    // Draw a rectangle with rounded corners having the following radii:
    // top-left = 20, top-right = 15, bottom-right = 10, bottom-left = 5.
    roundedRect p5 30 20 55 55 20 15 10 5
    describe p5 "white rect with black outline and round edges of different radii"

let run node = display node draw
