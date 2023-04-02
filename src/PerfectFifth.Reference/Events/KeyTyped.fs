module P5Reference.Events.KeyTyped

open P5.Core
open P5.Color
open P5.Shape
open P5.Events

let setup _ = 0

let draw p5 value =
    fill p5 (Grayscale(float value))
    square p5 25 25 50

let onKeyTyped p5 _ value =
    match key p5 with
    | "a" -> 255
    | "b" -> 0
    | _ -> value

// To prevent the default behaviour:
//     OnKeyTyped(Update onKeyTyped) |> PreventDefault
let subscriptions = [ OnKeyTyped(Update onKeyTyped) ]

let run node =
    play node setup noUpdate draw subscriptions
