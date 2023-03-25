module P5Reference.Shape.Vertex4

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.Math
open P5.Transform
open P5.Environment

// Click to change the number of sides.
// In WebGL mode, custom shapes will only
// display hollow fill sections when
// all calls to vertex() use the same z-value.

let ngon p5 n x y d =
    beginShapeWithMode p5 Tess

    for i in seq { 0.0 .. n } do
        let angle = twoPi / n * i
        let px = x + sin angle * d / 2.0
        let py = y - cos angle * d / 2.0
        vertex3D p5 px py 0

    for i in seq { 0.0 .. n } do
        let angle = twoPi / n * i
        let px = x + sin angle * d / 4.0
        let py = y - cos angle * d / 4.0
        vertex3D p5 px py 0

    endShape p5

let setup p5 =
    createCanvasWithMode p5 100 100 WebGL
    setAttributes p5 "antialias" true
    fill p5 (RGB(237, 34, 93))
    strokeWeight p5 3

    3 // Initial state

let update p5 = id

let onMousePressed _ _ sides =
    match sides with
    | sides when sides > 6 -> 3
    | _ -> sides + 1

let subscriptions = [ OnMousePressed(Update onMousePressed) ]

let draw p5 sides =
    let frameCount = frameCount p5 |> float
    background p5 (Grayscale 200)
    rotateX p5 (frameCount * 0.01)
    rotateZ p5 (frameCount * 0.01)
    ngon p5 (float sides) 0 0 80

let run node =
    play node setup update draw subscriptions
