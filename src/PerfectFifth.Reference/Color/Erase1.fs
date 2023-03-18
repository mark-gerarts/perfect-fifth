module P5Reference.Color.Erase1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    background p5 (RGB(150, 250, 150))
    fill p5 (RGB(100, 100, 250))
    square p5 20 20 60
    strokeWeight p5 5
    eraseWithFillAndStroke p5 150 255
    triangle p5 50 10 70 50 90 10
    noErase p5

    describe
        p5
        "60×60 centered purple rect, mint green background. Triangle in top-right is partially erased with fully erased outline."

let run node = display node draw
