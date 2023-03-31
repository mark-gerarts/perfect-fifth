module P5Reference.Transform.Translate2

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Transform
open P5.Math

let draw p5 t =
    background p5 (Grayscale 200)
    rectMode p5 Center
    translate p5 (width p5 / 2 |> float) (height p5 / 2 |> float)

    let v = P5Vector.fromAngleAndLength (float t / 1000.0) 40
    translateFromVector p5 v
    square p5 0 0 20

let run node = animate node noSetup draw
