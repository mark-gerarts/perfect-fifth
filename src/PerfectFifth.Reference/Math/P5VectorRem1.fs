module P5Reference.Math.P5VectorRem1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Math

let draw p5 =
    // Static method
    let v1 = P5Vector.create (3, 4, 5)
    let v2 = P5Vector.create (2, 3, 4)
    let v3 = P5Vector.rem (v1, v2)
    // v3 has components [1, 1, 1]
    print p5 (string v3)

let run node = display node draw
