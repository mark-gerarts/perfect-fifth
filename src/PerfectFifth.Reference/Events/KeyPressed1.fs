module P5Reference.Events.KeyPressed1

open P5.Core
open P5.Color
open P5.Shape
open P5.Events

let setup _ = 0

let draw p5 value =
    fill p5 (Grayscale(float value))
    square p5 25 25 50

let onKeyPressed p5 _ value =
    match keyCode p5 with
    | LeftArrow -> 255
    | RightArrow -> 0
    | _ -> value

let subscriptions = [ OnKeyPressed(Update onKeyPressed) ]

let run node =
    play node setup noUpdate draw subscriptions
