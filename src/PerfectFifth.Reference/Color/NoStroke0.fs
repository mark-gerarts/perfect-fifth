module P5Reference.Color.NoStroke0

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    noStroke p5
    square p5 20 20 60
    describe p5 "White rect at center; no outline."

let run node = display node draw
