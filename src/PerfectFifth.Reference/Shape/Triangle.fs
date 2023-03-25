module P5Reference.Shape.Triangle

open P5.Core
open P5.Shape

let draw p5 = triangle p5 30 75 58 20 86 75

let run node = display node draw
