module P5Reference.ThreeD.Texture3

open P5.Core
open P5.Color
open P5.Shape
open P5.Image
open P5.Rendering
open P5.ThreeD

let preload p5 = loadImage p5 "assets/laDefense.png"

let setup p5 img =
    createWebGLCanvas p5 100 100
    img

let draw p5 img =
    background p5 (Grayscale 0)
    texture p5 img
    textureMode p5 Normal
    beginShape p5
    vertexWithTexture p5 -40 -40 0 0 0
    vertexWithTexture p5 40 -40 0 1 0
    vertexWithTexture p5 40 40 0 1 1
    vertexWithTexture p5 -40 40 0 0 1
    endShape p5

let run node =
    simulateWithPreload node preload setup noUpdate draw
