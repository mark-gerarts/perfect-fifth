module P5Reference.Color.P5ColorToString0

open P5.Core
open P5.Color
open P5.Typography
open P5.Rendering
open P5.Transform
open P5.Math
open P5.Environment

let draw p5 =
    let myColor = color p5 (RGB(100, 100, 250))
    stroke p5 (Grayscale 255)

    fill p5 (P5Color myColor)
    rotate p5 halfPi

    text p5 (myColor.toString ()) 0 -5
    text p5 (myColor.toStringf "#rrggbb") 0 -30
    text p5 (myColor.toStringf "rgba%") 0 -55
    describe p5 "A canvas with 3 text representation of their color."

let run node = display node draw
