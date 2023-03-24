module P5Reference.Shape.Cylinder2

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.DOM
open P5.Transform

let setup p5 =
    createWebGLCanvas p5 100 100
    let detailY = createSliderWithOptions p5 3 16 3 1
    detailY.setPositionWithType 10 0 Relative
    detailY.style "width" "80px"
    detailY.style "display" "block"

    detailY

let draw p5 (detailY: P5Element<float>) =
    background p5 (RGB(205, 105, 94))
    rotateY p5 ((millis p5 |> float) / 1000.0)
    cylinderWithDetail p5 20 75 16 (detailY.getValue ())

let run node = simulate node setup noUpdate draw
