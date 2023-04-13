module P5Reference.Math.Round1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Typography

let draw p5 =
    let x = System.Math.Round(12.782383, 2)
    text p5 (string x) (width p5 / 2 |> float) (height p5 / 2 |> float)

let run node = display node draw
