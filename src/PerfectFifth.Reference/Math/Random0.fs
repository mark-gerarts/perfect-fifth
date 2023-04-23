module P5Reference.Math.Random0

open P5.Core
open P5.Color
open P5.Shape
open P5.Math

let draw p5 =
    for i in { 0.0 .. 100.0 } do
        let r = randomMax p5 50
        stroke p5 (Grayscale <| r * 5.0)
        line p5 50 i (50.0 + r) i

let run node = display node draw
