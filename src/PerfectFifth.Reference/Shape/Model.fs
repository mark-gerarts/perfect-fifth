module P5Reference.Shape.Model

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.Transform

let preload p5 =
    loadModel p5 "assets/octahedron.obj" false

let setup p5 octahedron =
    createWebGLCanvas p5 100 100
    octahedron

let draw p5 octahedron =
    let frameCount = float (frameCount p5)
    background p5 (Grayscale 200)
    rotateX p5 (frameCount * 0.01)
    rotateY p5 (frameCount * 0.01)
    model p5 octahedron

let run node =
    simulateWithPreload node preload setup noUpdate draw
