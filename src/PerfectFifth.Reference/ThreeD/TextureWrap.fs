module P5Reference.ThreeD.TextureWrap

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Image
open P5.ThreeD
open P5.Rendering
open P5.Events
open P5.Math
open P5.Transform

let preload p5 = loadImage p5 "assets/rockies128.jpg"

let setup p5 img =
    createWebGLCanvas p5 100 100
    textureWrap p5 Mirror
    img

let draw p5 img =
    background p5 (Grayscale 0)

    let dX = mouseX p5
    let dY = mouseY p5

    let u = lerp p5 1.0 2.0 dX
    let v = lerp p5 1.0 2.0 dY

    scale p5 (width p5 / 2 |> float)

    texture p5 img

    beginShapeWithMode p5 Triangles
    vertexWithTexture p5 -1 -1 0 0 0
    vertexWithTexture p5 1 -1 0 u 0
    vertexWithTexture p5 1 1 0 u v

    vertexWithTexture p5 1 1 0 u v
    vertexWithTexture p5 -1 1 0 0 v
    vertexWithTexture p5 -1 -1 0 0 0
    endShape p5

let run node =
    simulateWithPreload node preload setup noUpdate draw
