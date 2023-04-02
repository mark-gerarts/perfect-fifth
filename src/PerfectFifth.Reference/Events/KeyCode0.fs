module P5Reference.Events.KeyCode0

open P5.Core
open P5.Color
open P5.Shape
open P5.Events

let setup p5 = 126

let draw p5 fillValue =
    fill p5 (Grayscale(float fillValue))
    square p5 25 25 50

let onKeyPressed p5 _ fillValue =
    match keyCode p5 with
    | UpArrow -> 255
    | DownArrow -> 0
    | _ -> fillValue

let subscriptions = [ OnKeyPressed(Update onKeyPressed) ]

let run node =
    play node setup noUpdate draw subscriptions
