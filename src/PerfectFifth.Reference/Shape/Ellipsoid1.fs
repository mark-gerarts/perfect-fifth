module P5Reference.Shape.Ellipsoid1

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.DOM
open P5.Transform

let setup p5 =
    createWebGLCanvas p5 100 100
    let detailX = createSliderWithOptions p5 3 24 3 1
    detailX.setPositionWithType 10 0 Relative
    detailX.style "width" "80px"
    detailX.style "display" "block"

    detailX

let draw p5 (detailX: P5Element<float>) =
    background p5 (RGB(205, 105, 94))
    rotateY p5 ((millis p5 |> float) / 1000.0)
    ellipsoidWithDetail p5 30 40 40 (detailX.getValue ()) 8

let run node = simulate node setup noUpdate draw
