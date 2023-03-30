module P5Reference.Transform.ApplyMatrix2

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
    let angle = map p5 step 0 20 0 twoPi
    let cosA = cos angle
    let sinA = sin angle
    background p5 (Grayscale 200)
    translate p5 50 50
    // Equivalent to rotate(angle);
    applyMatrix2x3 p5 cosA sinA -sinA cosA 0 0
    square p5 0 0 50

let run node = animate node setup draw
