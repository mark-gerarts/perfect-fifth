module P5Reference.Color.Stroke6

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    // integer RGB notation
    stroke p5 (Name "rgb(0,255,0)")
    strokeWeight p5 4
    square p5 20 20 60

let run node = display node draw
