module P5Reference.Shape.RectMode0

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    rectMode p5 Corner
    fill p5 (Grayscale 255)
    square p5 25 25 50 // Draw white rectangle using CORNER mode

    rectMode p5 Corners
    fill p5 (Grayscale 100)
    square p5 25 25 50 // Draw gray rectangle using CORNERS mode

let run node = display node draw
