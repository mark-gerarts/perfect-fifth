module P5Reference.Environment.NoCursor

open P5.Core
open P5.Shape
open P5.Color
open P5.Environment
open P5.Events

let setup p5 = noCursor p5

let draw p5 _ =
    background p5 (Grayscale 200)
    circle p5 (mouseX p5) (mouseY p5) 10

let run node = animate node setup draw
