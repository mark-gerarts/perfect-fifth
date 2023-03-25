module P5Reference.Structure.NoLoop1

open P5.Core
open P5.Color
open P5.Shape
open P5.Environment
open P5.Structure

let setup p5 =
    noLoop p5
    0.0

let update p5 x =
    match x + 0.1 with
    | x when x > (width p5 |> float) -> 0.0
    | x -> x

let draw p5 x =
    background p5 (Grayscale 204)
    line p5 x 0 x (height p5 |> float)

let onMousePressed p5 ev = loop p5

let onMouseReleased p5 ev = noLoop p5

let subscriptions =
    [ OnMousePressed(Effect onMousePressed)
      OnMouseReleased(Effect onMouseReleased) ]

let run node =
    play node setup update draw subscriptions
