module P5Reference.DOM.P5ElementMouseMoved

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.DOM

let mutable d = 10.0

let changeSize p5 _ =
    let newD =
        match d + 2.0 with
        | d when d > 100.0 -> 0.0
        | d -> d

    d <- newD

let setup p5 =
    let cnv = createCanvasAndReturn p5 100 100
    let cnv' = unbox<P5Element<Unit>> cnv
    cnv'.mouseMoved changeSize
    100.0

let draw p5 g =
    background p5 (Grayscale g)
    circle p5 (width p5 / 2 |> float) (height p5 / 2 |> float) d

let onMouseMoved _ _ g =
    match g + 5.0 with
    | g when g > 255.0 -> 0.0
    | g -> g

let subscriptions = [ OnMouseMoved(Update onMouseMoved) ]

let run node =
    play node setup noUpdate draw subscriptions
