module P5Reference.Events.MovedY

open P5.Core
open P5.Color
open P5.Shape
open P5.Events

let setup p5 =
    rectMode p5 Center
    50.0

let update p5 y =
    let y' =
        match y with
        | y when y > 48.0 -> y - 2.0
        | y -> y + 2.0

    y' + (movedY p5 / 5.0 |> floor)

let draw p5 y =
    fill p5 (Grayscale 0)
    background p5 (RGB(237, 34, 93))
    square p5 50 y 50

let run node = simulate node setup update draw
