module P5Reference.Transform.ShearY

open P5.Core
open P5.Environment
open P5.Shape
open P5.Transform
open P5.Math

let draw p5 =
    let width = width p5 |> float
    let height = height p5 |> float

    translate p5 (width / 4.0) (height / 4.0)
    shearY p5 (pi / 4.0)
    square p5 0 0 30

let run node = display node draw
