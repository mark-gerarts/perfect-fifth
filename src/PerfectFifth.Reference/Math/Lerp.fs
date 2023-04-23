module P5Reference.Math.Lerp

open P5.Core
open P5.Color
open P5.Shape
open P5.Math

let draw p5 =
    background p5 (Grayscale 200)
    let a = 20
    let b = 80
    let c = lerp p5 a b 0.2
    let d = lerp p5 a b 0.5
    let e = lerp p5 a b 0.8

    let y = 50

    strokeWeight p5 5
    stroke p5 (Grayscale 0) // Draw the original points in black
    point p5 a y
    point p5 b y

    stroke p5 (Grayscale 100) // Draw the lerp points in gray
    point p5 c y
    point p5 d y
    point p5 e y

let run node = display node draw
