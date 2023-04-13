module P5Reference.Math.Map1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Math
open P5.Events

let setup = noStroke

let draw p5 _ =
    background p5 (Grayscale 204)
    let x1 = map p5 (mouseX p5) 0 (width p5 |> float) 25 75
    circle p5 x1 25 25
    //This ellipse is constrained to the 0-100 range
    //after setting withinBounds to true
    let x2 = mapBounded p5 (mouseX p5) 0 (width p5 |> float) 0 100
    circle p5 x2 75 25

let run node = animate node setup draw
