module P5Reference.Shape.Line0

open P5.Core
open P5.Shape

let draw p5 = line p5 30 20 85 75

let run node = display node draw
