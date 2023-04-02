module P5Reference.Events.MouseClicked1

open P5.Core
open P5.Shape
open P5.Events

let draw _ _ = ()

let onMouseClicked p5 _ = circle p5 (mouseX p5) (mouseY p5) 5

let subscriptions = [ OnMouseClicked(Effect onMouseClicked) |> PreventDefault ]

let run node =
    play node noSetup noUpdate draw subscriptions
