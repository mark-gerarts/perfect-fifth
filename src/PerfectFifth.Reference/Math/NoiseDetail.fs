module P5Reference.Math.NoiseDetail

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Math
open P5.Events

let noiseScale = 0.02

let draw p5 _ =
    background p5 (Grayscale 0)

    let height = height p5 |> float
    let width = width p5 |> float
    let mouseX = mouseX p5
    let mouseY = mouseY p5

    for y in { 0.0 .. height } do
        for x in { 0.0 .. width / 2.0 } do
            noiseDetail p5 2 0.2
            let noiseVal = noise2D p5 ((mouseX + x) * noiseScale) ((mouseY + y) * noiseScale)
            stroke p5 (Grayscale <| noiseVal * 255.0)
            point p5 x y
            noiseDetail p5 8 0.65

            let noiseVal' =
                noise2D p5 ((mouseX + x + width / 2.0) * noiseScale) ((mouseY + y) * noiseScale)

            stroke p5 (Grayscale <| noiseVal' * 255.0)
            point p5 (x + width / 2.0) y

let run node = animate node noSetup draw
