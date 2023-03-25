module P5Reference.Shape.LoadModel

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.Transform
open P5.ThreeD

let preload p5 = loadModel p5 "assets/teapot.obj" true

let setup p5 teapot =
    createWebGLCanvas p5 100 100
    teapot

let draw p5 teapot =
    let frameCount = float (frameCount p5)
    background p5 (Grayscale 200)
    scale p5 0.4
    rotateX p5 (frameCount * 0.01)
    rotateY p5 (frameCount * 0.01)
    normalMaterial p5
    model p5 teapot

let run node =
    simulateWithPreload node preload setup noUpdate draw
