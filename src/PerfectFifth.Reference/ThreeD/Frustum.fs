module P5Reference.ThreeD.Frustum

open P5.Core
open P5.Color
open P5.Shape
open P5.ThreeD
open P5.Rendering
open P5.Math
open P5.Transform
open P5.Structure

let setup p5 =
    createWebGLCanvas p5 100 100
    setAttribute p5 "antialias" true
    frustum p5 -0.1 0.1 -0.1 0.1 0.1 200

let draw p5 t =
    let t' = float t / 300.0
    background p5 (Grayscale 200)
    orbitControl p5
    normalMaterial p5

    rotateX p5 -0.2
    rotateY p5 -0.3

    push p5
    translate3D p5 -15 0 (sin t' * 25.0)
    cube p5 30
    pop p5
    push p5
    translate3D p5 15 0 (sin (t' + pi) * 25.0)
    cube p5 30
    pop p5

let run node = animate node setup draw
