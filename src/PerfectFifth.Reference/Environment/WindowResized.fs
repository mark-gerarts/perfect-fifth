module P5Reference.Environment.WindowResized

open P5.Core
open P5.Typography
open P5.Color
open P5.Environment

let draw p5 t =
    let width = width p5
    let x = (t / 100) % width

    background p5 (Grayscale 200)
    text p5 "TODO" x 20

let run node = animate node noSetup draw
