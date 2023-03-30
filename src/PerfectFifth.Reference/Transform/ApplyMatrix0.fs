module P5Reference.Transform.ApplyMatrix0

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Transform

let setup p5 =
    setFrameRate p5 10
    rectMode p5 Center

let draw p5 _ =
    let step = frameCount p5 % 20
    background p5 (Grayscale 200)
    // Equivalent to translate(x, y);
    applyMatrix2x3 p5 1 0 0 1 (40.0 + float step) 50
    rect p5 0 0 50 50

let run node = animate node setup draw
