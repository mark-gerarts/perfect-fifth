module P5Reference.Shape.LoadModel

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.Transform
open P5.ThreeD

let mutable teapot = None

let preload p5 =
    let model = loadModel p5 "assets/teapot.obj" true
    teapot <- Some model

let setup p5 = createWebGLCanvas p5 100 100

let draw p5 _ =
    let frameCount = float (frameCount p5)
    background p5 (Grayscale 200)
    scale p5 0.4
    rotateX p5 (frameCount * 0.01)
    rotateY p5 (frameCount * 0.01)
    normalMaterial p5
    model p5 (Option.get teapot)

let run node =
    createSketch
        { defaultSketch setup with
            preload = Some preload
            draw = draw
            node = node }
