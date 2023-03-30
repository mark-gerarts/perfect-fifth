module P5Reference.Transform.ApplyMatrix5

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Transform

let draw p5 =
    background p5 (Grayscale 200)
    let testMatrix = [| 1.0; 0.0; 0.0; 1.0; 0.0; 0.0 |]
    applyMatrix p5 testMatrix
    rect p5 0 0 50 50

let run node = display node draw
