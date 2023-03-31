module P5Reference.Events.SetShakeTreshold

open P5.Core
open P5.Color
open P5.Shape
open P5.Events

type State = { value: float; threshold: float }

let setup p5 =
    setShakeThreshold p5 30
    { value = 0; threshold = 30 }

let draw p5 state =
    fill p5 (Grayscale state.value)
    square p5 25 25 50

let onDeviceMoved p5 _ state =
    let newValue = state.value + 5.0
    let newTreshold = state.threshold + 5.0

    let newState =
        match newValue with
        | x when x > 255 -> { value = 0; threshold = 30 }
        | _ ->
            { value = newValue
              threshold = newTreshold }

    setShakeThreshold p5 newState.threshold
    newState

let subscriptions = [ OnDeviceMoved(Update onDeviceMoved) ]

let run node =
    play node setup noUpdate draw subscriptions
