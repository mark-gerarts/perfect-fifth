module P5Reference.Transform.Rotate

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Transform
open P5.Math

let draw p5 =
    let width = width p5 |> float
    let height = height p5 |> float

    translate p5 (width / 2.0) (height / 2.0)
    rotate p5 (pi / 3.0)
    square p5 -26 -26 52

let run node = display node draw
