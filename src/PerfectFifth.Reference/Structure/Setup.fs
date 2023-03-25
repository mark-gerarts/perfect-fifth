module P5Reference.Structure.Setup

open P5.Core
open P5.Color
open P5.Shape
open P5.Environment

let setup p5 =
    background p5 (Grayscale 0)
    noStroke p5
    fill p5 (Grayscale 102)

    0 // Initial state. Can be anything.

let update _ a = a + 1

let draw p5 (a: int) =
    let width = width p5
    rect p5 (a % width |> float) 10 2 80

let run node = simulate node setup update draw
