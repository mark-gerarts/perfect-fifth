module P5Reference.Shape.StrokeWeight0

open P5.Core
open P5.Shape

let draw p5 =
    strokeWeight p5 1 // Default
    line p5 20 20 80 20
    strokeWeight p5 4 // Thicker
    line p5 20 40 80 40
    strokeWeight p5 10 // Beastly
    line p5 20 70 80 70

let run node = display node draw
