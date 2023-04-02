module P5Reference.Events.DeviceShaken

open P5.Core
open P5.Color
open P5.Shape

let setup _ = 0.0

let draw p5 value =
    fill p5 (Grayscale value)
    square p5 25 25 50

let onDeviceShaken _ _ value =
    match value + 5.0 with
    | x when x > 255.0 -> 0.0
    | x -> x

let subscriptions = [ OnDeviceShaken(Update onDeviceShaken) ]

let run node =
    play node setup noUpdate draw subscriptions
