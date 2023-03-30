module P5Reference.Transform.ApplyMatrix1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Transform

let setup p5 =
    setFrameRate p5 10
    rectMode p5 Center

let draw p5 _ =
    let step = frameCount p5 % 20 |> float
    background p5 (Grayscale 200)
    translate p5 50 50
    // Equivalent to scale(x, y);
    applyMatrix2x3 p5 (1.0 / step) 0 0 (1.0 / step) 0 0
    rect p5 0 0 50 50

let run node = animate node setup draw
