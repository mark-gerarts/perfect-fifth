module P5Reference.Events.MousePressed1

open P5.Core
open P5.Shape
open P5.Events

let draw _ _ = ()

let onMousePressed p5 _ = circle p5 (mouseX p5) (mouseY p5) 5

let subscriptions = [ OnMousePressed(Effect onMousePressed) |> PreventDefault ]

let run node =
    play node noSetup noUpdate draw subscriptions
