module P5Reference.ThreeD.TextureMode1

open P5.Core
open P5.Shape
open P5.Image
open P5.Rendering
open P5.ThreeD

let preload p5 = loadImage p5 "assets/laDefense.png"

let draw p5 (img: P5Image) =
    createWebGLCanvas p5 100 100
    texture p5 img
    textureMode p5 Image
    beginShape p5
    vertexWithTexture p5 -50 -50 0 0 0
    vertexWithTexture p5 50 -50 0 img.width 0
    vertexWithTexture p5 50 50 0 img.width img.height
    vertexWithTexture p5 -50 50 0 0 img.height
    endShape p5

let run node = displayWithPreload node preload draw
