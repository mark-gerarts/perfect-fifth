module P5Reference.DOM.P5ElementMouseWheel

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.DOM
open Browser.Types

let mutable d = 10.0

let changeSize _ (event: WheelEvent) =
    d <- if event.deltaY > 0 then d + 10.0 else d - 10.0


let setup p5 =
    let cnv = createCanvasAndReturn p5 100 100
    let cnv' = unbox<P5Element<Unit>> cnv
    cnv'.mouseWheel (changeSize) // attach listener for activity on canvas only
    100.0

let draw p5 g =
    background p5 (Grayscale g)
    circle p5 (width p5 / 2 |> float) (height p5 / 2 |> float) d

let onMouseWheel _ _ g = g + 10.0

let subscriptions = [ OnMouseWheel(Update onMouseWheel) ]

let run node =
    play node setup noUpdate draw subscriptions
