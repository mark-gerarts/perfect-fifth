module P5Reference.DOM.P5ElementMouseOut

open P5.Core
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.DOM

let mutable d = 10.0

let changeSize p5 _ =
    let newD =
        match d + 10.0 with
        | d when d > 100.0 -> 0.0
        | d -> d

    d <- newD

let setup p5 =
    let cnv = createCanvasAndReturn p5 100 100
    let cnv' = unbox<P5Element<Unit>> cnv
    cnv'.mouseOut changeSize

let draw p5 _ =
    circle p5 (width p5 / 2 |> float) (height p5 / 2 |> float) d

let run node = animate node setup draw
