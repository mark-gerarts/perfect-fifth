module P5Reference.Math.Sq

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Typography
open P5.Math
open P5.Events

let draw p5 _ =
    let mouseX = mouseX p5
    let width = width p5 |> float
    let height = height p5 |> float

    background p5 (Grayscale 200)
    let eSize = 7
    let x1 = map p5 mouseX 0 width 0 10
    let y1 = 80.0
    let x2 = x1 ** 2
    let y2 = 20.0

    // Draw the non-squared.
    line p5 0 y1 width y1
    circle p5 x1 y1 eSize

    // Draw the squared.
    line p5 0 y2 width y2
    circle p5 x2 y2 eSize

    // Draw dividing line.
    stroke p5 (Grayscale 100)
    line p5 0 (height / 2.0) width (height / 2.0)

    // Draw text.
    let spacing = 15.0
    noStroke p5
    fill p5 (Grayscale 0)
    text p5 (sprintf "x = %.2f" x1) 0 (y1 + spacing)
    text p5 (sprintf "sq(x) = %.2f" x2) 0 (y2 + spacing)

let run node = animate node noSetup draw
