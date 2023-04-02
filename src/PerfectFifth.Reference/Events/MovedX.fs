module P5Reference.Events.MovedX

open P5.Core
open P5.Color
open P5.Shape
open P5.Events

let setup p5 =
    rectMode p5 Center
    50.0

let update p5 x =
    let x' =
        match x with
        | x when x > 48.0 -> x - 2.0
        | x -> x + 2.0

    x' + (movedX p5 / 5.0 |> floor)

let draw p5 x =
    fill p5 (Grayscale 0)
    background p5 (RGB(237, 34, 93))
    square p5 x 50 50

let run node = simulate node setup update draw
