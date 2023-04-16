module P5Reference.Math.P5VectorMult3

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v0 = P5Vector.create (1, 2, 3)
    let v1 = P5Vector.create (2, 3, 4)
    let result = P5Vector.mult (v0, v1)
    print p5 (string result) // result's components are set to [2, 6, 12]

let run node = display node draw
