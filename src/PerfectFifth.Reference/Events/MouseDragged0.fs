module P5Reference.Events.MouseDragged0

open P5.Core
open P5.Color
open P5.Shape

let setup _ = 5

let draw p5 value =
    fill p5 (Grayscale(float value))
    square p5 25 25 50

let onMouseDragged _ _ value =
    match value + 5 with
    | value when value > 255 -> 0
    | value -> value

let subscriptions = [ OnMouseDragged(Update onMouseDragged) ]

let run node =
    play node setup noUpdate draw subscriptions
