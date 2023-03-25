module P5Reference.Shape.StrokeWeight1

open P5.Core
open P5.Transform
open P5.Shape

let draw p5 =
    strokeWeight p5 1 // Default
    line p5 20 20 80 20
    scale p5 5 // Adding scale transformation
    strokeWeight p5 1 // Resulting strokeweight is 5
    line p5 4 8 16 8 // Coordinates adjusted for scaling

let run node = display node draw
