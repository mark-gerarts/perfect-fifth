module P5Reference.Shape.StrokeCap

open P5.Core
open P5.Shape

let draw p5 =
    strokeWeight p5 12.0
    strokeCap p5 CapRound
    line p5 20 30 80 30
    strokeCap p5 CapSquare
    line p5 20 50 80 50
    strokeCap p5 CapProject
    line p5 20 70 80 70

let run node = display node draw
