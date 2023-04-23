module P5Reference.Math.Atan2

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Transform
open P5.Events

let draw p5 _ =
    let width = width p5 |> float
    let height = height p5 |> float

    background p5 (Grayscale 204)
    translate p5 (width / 2.0) (height / 2.0)
    let a = atan2 (mouseY p5 - height / 2.0) (mouseX p5 - width / 2.0)
    rotate p5 a
    rect p5 -30 -5 60 10

let run node = animate node noSetup draw
