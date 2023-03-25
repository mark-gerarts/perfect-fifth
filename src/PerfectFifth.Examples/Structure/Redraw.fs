module P5Examples.Structure.Redraw

open P5.Core
open P5.Rendering
open P5.Color
open P5.Environment
open P5.Shape
open P5.Structure

let setup p5 =
    resizeCanvas p5 720 400
    stroke p5 (Grayscale 255)
    noLoop p5

    height p5 / 2

let update p5 state =
    match state - 4 with
    | y when y < 0 -> height p5
    | y -> y

let draw p5 state =
    let y = float state
    background p5 (Grayscale 0)
    line p5 0 y (width p5) y

let onMousePressed p5 _ = redraw p5

let subscriptions = [ OnMousePressed(Effect onMousePressed) ]

let run node =
    play node setup update draw subscriptions
