module P5Reference.Color.Stroke8

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    // percentage RGB notation
    stroke p5 (Name "rgb(100%,0%,10%)")
    strokeWeight p5 4
    square p5 20 20 60
    describe p5 "White rect at center with red outline."

let run node = display node draw
