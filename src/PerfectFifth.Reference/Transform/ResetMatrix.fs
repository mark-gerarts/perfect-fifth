module P5Reference.Transform.ResetMatrix

open P5.Core
open P5.Shape
open P5.Transform

let draw p5 =
    translate p5 50 50
    applyMatrix2x3 p5 0.5 0.5 -0.5 0.5 0 0
    rect p5 0 0 20 20
    // Note that the translate is also reset.
    resetMatrix p5
    square p5 0 0 20

let run node = display node draw
