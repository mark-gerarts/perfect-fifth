module P5Reference.Shape.Quad

open P5.Core
open P5.Color
open P5.Shape

let draw p5 = quad p5 38 31 86 20 69 63 30 76

let run node = display node draw
