module P5Reference.Math.P5VectorMult0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v = P5Vector.create (1, 2, 3)
    v.multScalar 2
    print p5 (string v)

let run node = display node draw
