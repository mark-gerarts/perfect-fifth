module P5Reference.Events.DoubleClicked0

open P5.Core
open P5.Color
open P5.Shape

let setup _ = 0

let draw p5 value =
    fill p5 (Grayscale(float value))
    square p5 25 25 50

let onDoubleClicked _ _ value =
    match value with
    | 255 -> 0
    | _ -> 255

let subscriptions = [ OnDoubleClicked(Update onDoubleClicked) ]

let run node =
    play node setup noUpdate draw subscriptions
