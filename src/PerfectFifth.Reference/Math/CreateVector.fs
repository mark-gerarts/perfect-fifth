module P5Reference.Math.CreateVector

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.Math
open P5.Events

let setup p5 =
    createCanvas p5 100 100
    stroke p5 (RGB(255, 0, 255))
    createVector2D (width p5 / 2 |> float) (height p5 / 2 |> float)

let draw p5 (v1: P5Vector) =
    background p5 (Grayscale 255)
    line p5 v1.x v1.y (mouseX p5) (mouseY p5)

let run node = simulate node setup noUpdate draw
