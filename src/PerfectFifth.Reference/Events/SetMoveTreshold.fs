module P5Reference.Events.SetMoveTreshold

open P5.Core
open P5.Color
open P5.Shape
open P5.Events

type State = { value: float; threshold: float }

let setup p5 =
    setMoveThreshold p5 0.5
    { value = 0; threshold = 0.5 }

let draw p5 state =
    fill p5 (Grayscale state.value)
    square p5 25 25 50

let onDeviceMoved p5 _ state =
    let newValue = state.value + 5.0
    let newTreshold = state.threshold + 0.1

    let newState =
        match newValue with
        | x when x > 255 -> { value = 0; threshold = 30 }
        | _ ->
            { value = newValue
              threshold = newTreshold }

    setMoveThreshold p5 newState.threshold
    newState

let subscriptions = [ OnDeviceMoved(Update onDeviceMoved) ]

let run node =
    play node setup noUpdate draw subscriptions
