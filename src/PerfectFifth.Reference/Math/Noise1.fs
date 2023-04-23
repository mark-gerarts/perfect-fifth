module P5Reference.Math.Noise1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Math
open P5.Events

let noiseScale = 0.02

let draw p5 _ =
    background p5 (Grayscale 0)
    let width = width p5 |> float

    for x in { 0.0 .. width - 1.0 } do
        let noiseVal = noise2D p5 ((mouseX p5 + x) * noiseScale) (mouseY p5 * noiseScale)
        stroke p5 (Grayscale <| noiseVal * 255.0)
        line p5 x (mouseY p5 + noiseVal * 80.0) x (height p5 |> float)

let run node = animate node noSetup draw
