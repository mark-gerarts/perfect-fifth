module P5Reference.ThreeD.LightFalloff

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.ThreeD
open P5.Events
open P5.Structure
open P5.Transform

let setup p5 =
    createWebGLCanvas p5 100 100
    noStroke p5

let draw p5 _ =
    let width = width p5 |> float
    let height = height p5 |> float

    orthoWithDefaults p5
    background p5 (Grayscale 0)

    let locX = mouseX p5 - width / 2.0
    let locY = mouseY p5 - height / 2.0
    let locX' = locX / 2.0 // half scale

    lightFalloff p5 1 0 0
    push p5
    translate3D p5 -25 0 0
    pointLight p5 (Grayscale 250) (locX' - 25.0) locY 50
    sphere p5 20
    pop p5

    lightFalloff p5 0.97 0.03 0
    push p5
    translate3D p5 25 0 0
    pointLight p5 (Grayscale 250) (locX' + 25.0) locY 50
    sphere p5 20
    pop p5

let run node = animate node setup draw
