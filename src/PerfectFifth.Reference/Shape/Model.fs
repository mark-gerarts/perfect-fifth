module P5Reference.Shape.Model

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.Transform

// Preloading state has to use a mutable var at the moment. It should definitely
// be handled in a more elegant way in the future, but this requires some
// thinking first.
let mutable octahedron = None

let preload p5 =
    let model = loadModel p5 "assets/octahedron.obj" false
    octahedron <- Some model

let setup p5 = createWebGLCanvas p5 100 100

let draw p5 _ =
    let frameCount = float (frameCount p5)
    background p5 (Grayscale 200)
    rotateX p5 (frameCount * 0.01)
    rotateY p5 (frameCount * 0.01)
    model p5 (Option.get octahedron)

let run node =
    // Also, until the preload problem is handled, we have to run createSketch
    // manually.
    createSketch
        { defaultSketch setup with
            preload = Some preload
            draw = draw
            node = node }
