module P5Reference.Rendering.SetAttributes0

open P5.Core
open P5.Color
open P5.Shape
open P5.Structure
open P5.Transform
open P5.Rendering

let setup p5 = createWebGLCanvas p5 100 100

let draw p5 t =
    let rotateAmount = (float t) * 0.001

    background p5 (Grayscale 255)
    push p5
    rotateZ p5 rotateAmount
    rotateX p5 rotateAmount
    rotateY p5 rotateAmount
    fill p5 (Grayscale 0)
    cube p5 50
    pop p5

let run node = animate node setup draw
