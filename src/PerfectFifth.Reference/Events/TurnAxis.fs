module P5Reference.Events.TurnAxis

open P5.Core
open P5.Color
open P5.Shape
open P5.Events

let setup _ = 0

let draw p5 value =
    fill p5 (Grayscale(float value))
    square p5 25 25 50

let onDeviceTurned p5 _ value =
    match turnAxis p5 with
    | X when value = 255 -> 0
    | X when value = 0 -> 255
    | _ -> value

let subscriptions = [ OnDeviceTurned(Update onDeviceTurned) ]

let run node =
    play node setup noUpdate draw subscriptions
