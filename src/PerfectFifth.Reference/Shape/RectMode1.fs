module P5Reference.Shape.RectMode1

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    rectMode p5 Radius
    fill p5 (Grayscale 255)
    square p5 50 50 30 // Draw white rectangle using RADIUS mode

    rectMode p5 Center
    fill p5 (Grayscale 100)
    square p5 50 50 30 // Draw gray rectangle using CENTER mode

let run node = display node draw
