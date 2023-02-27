module P5Examples.Form.ShapePrimitives

open P5.Core
open P5.Rendering
open P5.Color
open P5.Shape
open P5.Math

let draw p5 =
    resizeCanvas p5 720 400
    background p5 (Grayscale 0)
    noStroke p5

    fill p5 (Grayscale 204)
    triangle p5 18 18 18 360 81 360

    fill p5 (Grayscale 102)
    square p5 81 81 63

    fill p5 (Grayscale 204)
    quad p5 189 18 216 18 216 360 144 360

    fill p5 (Grayscale 255)
    ellipse p5 252 144 72 72

    fill p5 (Grayscale 204)
    triangle p5 288 18 351 360 288 360

    fill p5 (Grayscale 255)
    arc p5 479 300 280 280 pi twoPi

let run node = display node draw
