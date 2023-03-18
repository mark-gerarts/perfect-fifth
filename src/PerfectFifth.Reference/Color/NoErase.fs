module P5Reference.Color.NoErase

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    background p5 (RGB(235, 145, 15))
    noStroke p5
    fill p5 (RGB(30, 45, 220))
    rect p5 30 10 10 80
    erase p5
    circle p5 50 50 60
    noErase p5
    rect p5 70 10 10 80

    describe
        p5
        "Orange background, with two tall blue rectangles. A centered ellipse erased the first blue rect but not the second."

let run node = display node draw
