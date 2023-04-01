module P5Reference.Events.MouseMoved1

open P5.Core
open P5.Shape
open P5.Events

let draw _ _ = ()

let onMouseMoved p5 _ = circle p5 (mouseX p5) (mouseY p5) 5

let subscriptions = [ OnMouseMoved(Effect onMouseMoved) |> PreventDefault ]

let run node =
    play node noSetup noUpdate draw subscriptions
