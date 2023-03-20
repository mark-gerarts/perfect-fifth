module P5Reference.Shape.Rect1

open P5.Core
open P5.Shape

let draw p5 =
    // Draw a rectangle with rounded corners, each having a radius of 20.
    roundedRect p5 30 20 55 55 20 20 20 20

let run node = display node draw
