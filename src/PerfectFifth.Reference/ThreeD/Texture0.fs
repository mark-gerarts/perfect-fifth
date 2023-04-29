module P5Reference.ThreeD.Texture0

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Image
open P5.Rendering
open P5.Transform
open P5.ThreeD

let preload p5 = loadImage p5 "assets/laDefense.png"

let setup p5 img =
    createWebGLCanvas p5 100 100
    img

let draw p5 img =
    let frameCount = frameCount p5 |> float
    background p5 (Grayscale 0)
    rotateZ p5 (frameCount * 0.01)
    rotateX p5 (frameCount * 0.01)
    rotateY p5 (frameCount * 0.01)
    //pass image as texture
    texture p5 img
    cube p5 (width p5 / 2 |> float)

let run node =
    simulateWithPreload node preload setup noUpdate draw
