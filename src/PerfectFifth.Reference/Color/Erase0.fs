module P5Reference.Color.Erase0

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    background p5 (RGB(100, 100, 250))
    fill p5 (RGB(250, 100, 100))
    square p5 20 20 60
    erase p5
    circle p5 25 30 30
    noErase p5

let run node = display node draw
