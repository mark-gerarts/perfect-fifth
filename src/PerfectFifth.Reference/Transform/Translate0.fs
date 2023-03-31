module P5Reference.Transform.Translate0

open P5.Core
open P5.Shape
open P5.Transform

let draw p5 =
    translate p5 30 20
    square p5 0 0 55

let run node = display node draw
