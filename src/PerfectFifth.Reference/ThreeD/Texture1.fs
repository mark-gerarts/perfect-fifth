module P5Reference.ThreeD.Texture1

open P5.Core
open P5.Color
open P5.ThreeD
open P5.Shape
open P5.Rendering
open P5.Typography
open P5.Transform

let draw p5 =
    createWebGLCanvas p5 100 100
    let pg = createGraphics p5 200 200
    setTextSize pg 75

    background p5 (Grayscale 0)
    background pg (Grayscale 255)
    text pg "hello!" 0 100
    //pass image as texture
    texture p5 pg
    rotateX p5 0.5
    noStroke p5
    plane p5 50 50

let run node = display node draw
