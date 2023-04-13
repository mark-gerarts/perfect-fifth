module P5Reference.Math.Round0

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Typography

let draw p5 =
    let x = round 3.7
    text p5 (string x) (width p5 / 2 |> float) (height p5 / 2 |> float)

let run node = display node draw
