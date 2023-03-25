module P5Reference.Color.Fill6

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    // integer RGB notation
    fill p5 (Name "rgb(0,255,0)")
    square p5 20 20 60

let run node = display node draw
