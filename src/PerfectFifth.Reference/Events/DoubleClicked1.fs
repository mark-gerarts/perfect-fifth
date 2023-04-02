module P5Reference.Events.DoubleClicked1

open P5.Core
open P5.Shape
open P5.Events

let draw _ _ = ()

let onDoubleClicked p5 _ = circle p5 (mouseX p5) (mouseY p5) 5

let subscriptions = [ OnDoubleClicked(Effect onDoubleClicked) |> PreventDefault ]

let run node =
    play node noSetup noUpdate draw subscriptions
