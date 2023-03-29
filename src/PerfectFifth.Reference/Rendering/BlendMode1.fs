module P5Reference.Rendering.BlendMode1

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering

let draw p5 =
    blendMode p5 Multiply
    strokeWeight p5 30
    stroke p5 (RGB(80, 150, 255))
    line p5 25 25 75 75
    stroke p5 (RGB(255, 50, 50))
    line p5 75 25 25 75

let run node = display node draw
