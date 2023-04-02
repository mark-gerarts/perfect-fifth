module P5Reference.Events.ExitPointerLock

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Events

let setup _ = false

let draw p5 _ = background p5 (RGB(237, 34, 93))

let onMouseClick p5 _ locked =
    if locked then exitPointerLock p5 else requestPointerLock p5

    not locked

let subscriptions = [ OnMouseClicked(Update onMouseClick) ]

let run node =
    play node setup noUpdate draw subscriptions
