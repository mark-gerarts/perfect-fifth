module P5Examples.Structure.WidthAndHeight

open P5.Core
open P5.Color
open P5.Rendering
open P5.Environment
open P5.Shape

let setup p5 = resizeCanvas p5 720 400

let draw p5 =
    let height = height p5
    let width = width p5

    background p5 (Grayscale 127)
    noStroke p5

    for i in { 0..20..height } do
        fill p5 (RGB(129, 206, 15))
        rect p5 0 i width 10
        fill p5 (Grayscale 255)
        rect p5 i 0 10 height

let run node : Unit = display node setup draw
