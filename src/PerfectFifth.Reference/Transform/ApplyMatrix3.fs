module P5Reference.Transform.ApplyMatrix3

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Transform
open P5.Math

let setup p5 =
    setFrameRate p5 10
    rectMode p5 Center

let draw p5 _ =
    let step = frameCount p5 % 20 |> float
    let angle = map p5 step 0 20 (-pi / 4.0) (pi / 4.0)
    background p5 (Grayscale 200)
    translate p5 50 50
    // equivalent to shearX(angle);
    let shearFactor = 1.0 / tan (pi / 2.0 - angle)
    applyMatrix2x3 p5 1 0 shearFactor 1 0 0
    rect p5 0 0 50 50

let run node = animate node setup draw
