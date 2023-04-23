module P5Reference.Math.P5VectorDiv0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v = P5Vector.create (6, 4, 2)
    v.divScalar 2
    print p5 (string v)

let run node = display node draw
