module P5Reference.Shape.Ellipse

open P5.Core
open P5.Shape

let draw p5 = ellipse p5 56 46 55 55

let run node = display node draw
