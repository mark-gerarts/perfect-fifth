module P5Reference.ThreeD.NoLights

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD
open P5.Transform

let draw p5 =
    createWebGLCanvas p5 100 100
    background p5 (Grayscale 200)
    noStroke p5

    ambientLight p5 (RGB(255, 0, 0))
    translate3D p5 -30 0 0
    ambientMaterial p5 (Grayscale 255)
    sphere p5 13

    noLights p5
    translate3D p5 30 0 0
    ambientMaterial p5 (Grayscale 255)
    sphere p5 13

    ambientLight p5 (RGB(0, 255, 0))
    translate3D p5 30 0 0
    ambientMaterial p5 (Grayscale 255)
    sphere p5 13

let run node = display node draw
