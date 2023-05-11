module P5Reference.DOM.P5ElementMouseReleased

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.DOM
open P5.Math

let mutable g = 100.0

let changeGray p5 _ =
    let randomGrayscale = randomInRange p5 0 255 |> round
    g <- randomGrayscale

let setup p5 =
    let cnv = createCanvasAndReturn p5 100 100
    let cnv' = unbox<P5Element<Unit>> cnv
    cnv'.mouseReleased changeGray
    10.0

let draw p5 d =
    background p5 (Grayscale g)
    circle p5 (width p5 / 2 |> float) (height p5 / 2 |> float) d

let onMouseReleased _ _ d = d + 10.0

let subscriptions = [ OnMouseReleased(Update onMouseReleased) ]

let run node =
    play node setup noUpdate draw subscriptions
