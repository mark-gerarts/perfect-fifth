module P5Examples.Form.PointsAndLines

open P5.Core
open P5.Rendering
open P5.Color
open P5.Shape
open P5.Transform

let draw p5 =
    let d = 70
    let p1 = d
    let p2 = p1 + d
    let p3 = p2 + d
    let p4 = p3 + d

    resizeCanvas p5 720 400
    background p5 (Grayscale 0)
    noSmooth p5

    translate p5 140 0

    // Draw gray box
    stroke p5 (Grayscale 153)
    line2D p5 p3 p3 p2 p3
    line2D p5 p2 p3 p2 p2
    line2D p5 p2 p2 p3 p2
    line2D p5 p3 p2 p3 p3

    // Draw white points
    stroke p5 (Grayscale 255)
    point2D p5 p1 p1
    point2D p5 p1 p3
    point2D p5 p2 p4
    point2D p5 p3 p1
    point2D p5 p4 p2
    point2D p5 p4 p4

let run node = display node draw
