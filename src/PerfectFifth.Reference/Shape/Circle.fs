module P5Reference.Shape.Circle

open P5.Core
open P5.Shape

let draw p5 = circle p5 30 30 20

let run node = display node draw
