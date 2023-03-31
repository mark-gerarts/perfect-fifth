module P5Reference.Transform.Translate1

open P5.Core
open P5.Shape
open P5.Transform

let draw p5 =
    square p5 0 0 55 // Draw rect at original 0,0
    translate p5 30 20
    square p5 0 0 55 // Draw rect at new 0,0
    translate p5 14 14
    square p5 0 0 55 // Draw rect at new 0,0

let run node = display node draw
